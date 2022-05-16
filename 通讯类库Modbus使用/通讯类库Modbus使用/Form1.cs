using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通讯类库Modbus使用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Plc plc = new Plc(CpuType.S71200,"192.168.0.1",0,0);
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("连接成功");
            }
            MessageBox.Show("连接失败");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("断开成功");
            }
            MessageBox.Show("断开失败");
        }

        private void Ress_Click(object sender, EventArgs e)
        {
            object val = plc.Read("MD0");
            MessageBox.Show(val.ToString());
        }
    }
}
