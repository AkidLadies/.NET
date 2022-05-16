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
using NModbus;
using thinger.DataConvertLib;

namespace 跑马灯
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Plc plc = new Plc(CpuType.S71500, "192.168.0.1", 0, 1);
        //private bool SiemensRun = false;
        private void btn_run_Click(object sender, EventArgs e)
        {
            //SiemensRun=true;

            byte[] val = plc.ReadBytes(S7.Net.DataType.Memory, 0, 100, 7);

            float M100 = BitConverter.ToSingle(new byte[] { val[3], val[2], val[1], val[0] }, 0);

            MessageBox.Show(M100.ToString());

            //Task.Run(new Action(() =>
            //{
            //    SiemensrRun(); 
            //})); 
        }

        //private void SiemensrRun()
        //{
        //    while (SiemensRun)
        //    {
        //        //byte[] val = plc.ReadBytes(S7.Net.DataType.Memory, 0, 100, 7);

        //        //float M100 = BitConverter.ToSingle(new byte[] { val[3], val[2], val[1], val[0] }, 0);
        //        //MessageBox.Show(M100.ToString());
        //    }
        //}

        private void btn_stop_Click(object sender, EventArgs e)
        {
            plc.Open();
        }
    }
}
