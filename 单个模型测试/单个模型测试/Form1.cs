using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;


namespace 单个模型测试
{
    public partial class btn_stop : Form
    {
        public btn_stop()
        {
            InitializeComponent();
        }
        Plc plc = new Plc(CpuType.S71500, "192.168.0.1", 0, 1);
        

        private void btn_run_Click(object sender, EventArgs e)
        {
            plc.Write("I0.0", 1);
            plc.Write("I0.1", 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plc.Write("I0.0", 0);
            plc.Write("I0.1", 1);
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            plc.Open();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            plc.Close();
        }
    }
}
