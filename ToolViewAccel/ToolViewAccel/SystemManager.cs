using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ToolViewAccel
{
    class SystemManager
    {
        double ReceivingRate;
        UInt64 ReceivedDataCount;
        UInt64 LastDataCount;
        public bool IsAccelerometerRateSynchronized = false;
        public delegate void SyncAccelerometerSamplingRateDelegate();
        public SyncAccelerometerSamplingRateDelegate syncAccelerometerSamplingRateDelagate;

        Timer PeriodicTimer;
        public UInt64 PeriodicTimerInterval;

        public SystemManager()
        {
            ReceivedDataCount = 0;
            LastDataCount = 0;
            InitializeTimers();
        }

        public bool AcknowledgeNewAccelerometerData()
        {
            ReceivedDataCount++;
            return true;
        }

        private void InitializeTimers()
        {
            PeriodicTimerInterval = 3000;
            PeriodicTimer = new Timer(PeriodicTimerInterval);
            PeriodicTimer.Elapsed += new ElapsedEventHandler(PeriodicTimerHandler);
            PeriodicTimer.Enabled = true;
        }
        private void PeriodicTimerHandler(object source, ElapsedEventArgs e)
        {
            ReceivingRate = ((double)ReceivedDataCount - (double)LastDataCount) / (double)PeriodicTimerInterval * 1000;
            LastDataCount = ReceivedDataCount;

            if(!IsAccelerometerRateSynchronized)
            {
                if( 1.1 * AccelerometerData.samplingRate > ReceivingRate &&
                    0.9 * AccelerometerData.samplingRate < ReceivingRate)
                {
                    IsAccelerometerRateSynchronized = true;
                    Console.WriteLine("Accelerometer SYNCHRONIZED");
                }
                else
                {
                    Console.WriteLine("Accelerometer out of sync (Receive data rate and Accel ODR are not the same)");
                    syncAccelerometerSamplingRateDelagate();
                }
            }
            Console.WriteLine("Receiving rate: {0}", ReceivingRate);
        }
    }
}
