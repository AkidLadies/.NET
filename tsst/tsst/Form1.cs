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

namespace tsst
{
    public partial class btn_stop : Form
    {
        public btn_stop()
        {
            InitializeComponent();

            
            bool isConnected= siemens.Connect("192.168.0.1",xktComm.Common.CPU_Type.S71500,0,0);

            
            updatatimer.Interval = 500;

            updatatimer.Tick += Updatatimer_Tick;

            if (isConnected)
            {
                updatatimer.Start();
                MessageBox.Show("连接成功");
            }
            else
            {
                MessageBox.Show("连接失败");
            }
        }

        
        private xktComm.SiemensS7 siemens = new SiemensS7();

        
        private void Updatatimer_Tick(object sender, EventArgs e)
        {
            bool value = Convert.ToBoolean(siemens.Read("M0.2", xktComm.Common.VarType.Bit));
            

        }

        
        private Timer updatatimer = new Timer();

        private void btn_start_BtnClick(object sender, EventArgs e)
        {
            siemens.Write("M0.0", 1);

            siemens.Write("M0.0", 0);
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            siemens.Write("M0.1", 1);

            siemens.Write("M0.1", 0);
        }
    }
}
