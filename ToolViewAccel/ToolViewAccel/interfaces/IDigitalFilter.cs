using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolViewAccel
{
    interface IDigitalFilter
    {
        AccelerometerData FilterRawData(AccelerometerData rawData);
        bool Enable();
        bool Disable();
    }
}
