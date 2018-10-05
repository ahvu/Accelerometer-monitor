using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolViewAccel
{
    class CAccelerometerDataMessageHandler : IMessageHandler
    {
        bool IsAllResourcesProvided = false;
        public const byte MessageType = 0xAD;

        IDigitalFilter lowPassFilter;
        SystemManager AccelerometerErrorManager;
        IGraph MainGraph;

        public CAccelerometerDataMessageHandler(List<object> necessaryResources)
        {
            provideNecessaryResources(necessaryResources);
        }

        // From IMessageHandler
        public bool handleMessage(byte[] message)
        {
            if (IsAllResourcesProvided == false)
            {
                return false;
            }

            if(message == null)
            {
                return false;
            }

            if (message.Length == 0)
            {
                return false;
            }

            if ((message.Length % 3) != 0)
            {
                while (true) ;
            }

            sbyte[] signedData = message.Select(b => (sbyte)b).ToArray();
            for (int i = 0; i < signedData.Length; i += 3)
            {
                fetchAccelDataToGraph(lowPassFilter.FilterRawData(new AccelerometerData(signedData[i], signedData[i + 1], signedData[i + 2])));
                AccelerometerErrorManager.AcknowledgeNewAccelerometerData();
            }
            MainGraph.Render();
            return true;
        }
        public bool provideNecessaryResources(List<Object> resources)
        {
            for(int i = 0; i < resources.Count; i++)
            {
                if (resources[i].GetType().GetInterfaces().Length < 1)
                {
                    switch(resources[i].GetType().Name)
                    {
                        case "SystemManager":
                            AccelerometerErrorManager = (SystemManager)resources[i];
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (resources[i].GetType().GetInterfaces()[0].Name)
                    {
                        case "IDigitalFilter":
                            lowPassFilter = (IDigitalFilter)resources[i];
                            break;
                        case "IGraph":
                            MainGraph = (IGraph)resources[i];
                            break;
                        default:
                            break;
                    }
                }
            }
            IsAllResourcesProvided = (lowPassFilter != null &&
                                      MainGraph != null &&
                                      AccelerometerErrorManager != null);

            return IsAllResourcesProvided;
        }
        public bool IsAllNeccesaryResourcesProvided()
        {
            return IsAllResourcesProvided;
        }


        private double timeStamp = 0;
        private void fetchAccelDataToGraph(AccelerometerData accData)
        {
            double[] point = { timeStamp, accData.ax };
            MainGraph.AddNewPoint(point, "X");
            point[1] = accData.ay;
            MainGraph.AddNewPoint(point, "Y");
            point[1] = accData.az;
            MainGraph.AddNewPoint(point, "Z");

            timeStamp += 1 / AccelerometerData.samplingRate;
        }
    }
}
