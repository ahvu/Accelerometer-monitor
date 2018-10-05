using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ToolViewAccel
{
    interface IGraph
    {
        bool AddCurve(string label, Color color);
        bool DeleteCurve(string curveToDelete);

        bool AddNewPoint(double[] point, string curveToAdd);
        bool ClearGraph();
        bool Render();

        bool SetGraphTitle(string title);
        bool SetAxisXTitle(string xTitle);
        bool SetAxisYTitle(string yTitle);

        bool SetXRangeFixed(double range);
        bool SetYRangeFixed(double range);

        bool SetXAxis_MinValue(double value);
        bool SetXAxis_MaxValue(double value);
        bool SetYAxis_MinValue(double value);
        bool SetYAxis_MaxValue(double value);
    }
}
