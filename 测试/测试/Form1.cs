using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xktComm;

namespace 测试
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bool isConnect= siemens.Connect("192.168.0.1", xktComm.Common.CPU_Type.S71500, 0, 0);
            if (isConnect)
            {
                MessageBox.Show("Test");
            }
        }
        private xktComm.SiemensS7 siemens = new SiemensS7();

        private void button1_Click(object sender, EventArgs e)
        {
            siemens.Write("M0.0", true);
        }
    }
}
