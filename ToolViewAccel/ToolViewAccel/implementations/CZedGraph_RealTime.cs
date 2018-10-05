using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ZedGraph;

namespace ToolViewAccel
{
    class CZedGraph_RealTime : IGraph
    {
        int defaultCurveCapacity = 240000;
        ZedGraphControl zedGraphControl = null;
        ZedGraph.GraphPane myPane = null;
        List<RollingPointPairList> PointsLists;

        bool m_bIsXRangeFixed = false;
        double XRange = 0;
        bool m_bIsYRangeFixed = false;
        double YRange = 0;

        public CZedGraph_RealTime(ZedGraphControl zgc)
        {
            zedGraphControl = zgc;
            myPane = zgc.GraphPane;

            myPane.Title.Text = "Graph name";
            myPane.TitleGap = 0;

            myPane.XAxis.Title.Text = "X Axis";
            myPane.XAxis.Title.Gap = 0;

            myPane.YAxis.Title.Text = "Y Axis";
            myPane.YAxis.Title.Gap = 0;

            myPane.IsFontsScaled = false;

            myPane.XAxis.Scale.MaxAuto = true;
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);
            myPane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);
            myPane.Legend.Position = ZedGraph.LegendPos.InsideTopLeft;
            myPane.Legend.FontSpec = new FontSpec("Ariel", 25, Color.Black, true, false, false);

            PointsLists = new List<RollingPointPairList>();
        }
        public bool AddCurve(string label, Color color)
        {
            PointsLists.Add(new RollingPointPairList(defaultCurveCapacity));
            myPane.AddCurve(label, PointsLists.Last(), color, SymbolType.None);
            return true;
        }
        public bool DeleteCurve(string curveToDelete)
        {
            return true;
        }

        public bool AddNewPoint(double[] point, string curveToAdd)
        {
            int index = 0;
            foreach (CurveItem item in myPane.CurveList)
            {
                if (item.Label.Text == curveToAdd)
                {
                    double x = point[0];
                    double y = point[1];
                    PointsLists[index].Add(x, y);
                    AdjustScale_If_FixedRange(x, y);
                    return true;
                }
                index++;
            }
            return false;
        }
        public bool ClearGraph()
        {
            return true;
        }
        public bool Render()
        {
            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
            return true;
        }

        public bool SetGraphTitle(string title)
        {
            myPane.Title.Text = title;
            return true;
        }
        public bool SetAxisXTitle(string x_title)
        {
            myPane.XAxis.Title.Text = x_title;
            return true;
        }
        public bool SetAxisYTitle(string y_title)
        {
            myPane.YAxis.Title.Text = y_title;
            return true;
        }

        public bool SetXRangeFixed(double range)
        {
            if (range <= 0)
            {
                return false;
            }
            m_bIsXRangeFixed = true;
            XRange = range;
            return m_bIsXRangeFixed;
        }
        public bool SetYRangeFixed(double range)
        {
            if (range <= 0)
            {
                return false;
            }
            m_bIsXRangeFixed = true;
            XRange = range;
            return m_bIsXRangeFixed;
        }
        public bool SetXAxis_MinValue(double value)
        {
            myPane.XAxis.Scale.Min = value;
            return true;
        }
        public bool SetXAxis_MaxValue(double value)
        {
            myPane.YAxis.Scale.Max = value;
            return true;
        }
        public bool SetYAxis_MinValue(double value)
        {
            myPane.YAxis.Scale.Min = value;
            return true;
        }
        public bool SetYAxis_MaxValue(double value)
        {
            myPane.YAxis.Scale.Max = value;
            return true;
        }

        private void AdjustScale_If_FixedRange(double x, double y)
        {
            if (m_bIsXRangeFixed)
            {
                myPane.XAxis.Scale.Min = (x - XRange) > 0 ? x - XRange : 0;
                myPane.XAxis.Scale.Max = myPane.XAxis.Scale.Min + XRange * 1.2;
            }

            if (m_bIsYRangeFixed)
            {
                myPane.YAxis.Scale.Min = (y - YRange) > 0 ? x - YRange : 0;
                myPane.YAxis.Scale.Max = myPane.YAxis.Scale.Min + YRange * 1.2;
            }
        }
    }
}
