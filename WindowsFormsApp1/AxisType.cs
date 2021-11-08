using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    enum EAxisTypeName
    {
        汇川,
        西门子,
        倍福,
        三菱
    }
    class AxisType
    {
        
        private int _axisId;
        [Category("AxisParameters"),Description("轴的ID设置")]
        public int AxisId
        {
            get { return _axisId; }
            set { _axisId = value; }
        }

        private string _name;
        [Category("AxisParameters"), Description("轴的ID名称")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private EAxisTypeName _axisTypeName;
        [Category("AxisParameters")]
        public EAxisTypeName AxisTypeName
        {
            get { return _axisTypeName; }
            set { _axisTypeName = value; }
        }


        private double[] _points = new double[] { 1.0,2.0};
        [Category("Points"), Description("轴的ID点位")]
        public double[] Points
        {
            get { return _points; }
            set { _points = value; }
        }
    }
}
