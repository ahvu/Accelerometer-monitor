using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolViewAccel
{
    class CLowPassFilter : IDigitalFilter
    {
        AccelerometerData filteredData;
        double beta;
        bool IsEnabled;

        public CLowPassFilter(double _beta)
        {
            beta = _beta;
            IsEnabled = false;
        }
        public AccelerometerData FilterRawData(AccelerometerData rawData)
        {
            if(filteredData == null || IsEnabled == false)
            {
                filteredData = rawData;
            }
            else
            {
                filteredData = filteredData - (beta * (filteredData - rawData));
            }
            return filteredData;
        }

        public bool Enable()
        {
            IsEnabled = true;
            return true;
        }
        public bool Disable()
        {
            IsEnabled = false;
            return true;
        }
    }
}
