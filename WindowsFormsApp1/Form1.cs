using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicLibraries.CommonControl.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            propertyGrid1.SelectedObject = new AxisType();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AxisType axisType = (AxisType)propertyGrid1.SelectedObject;
            using (System.IO.FileStream fs = new System.IO.FileStream($"{axisType.Name}.json",System.IO.FileMode.Create,System.IO.FileAccess.Write))
            {
                byte[] d = Encoding.UTF8.GetBytes(axisType.ObjToJson());
                fs.Write(d, 0, d.Length);
            }
        }
    }
}
