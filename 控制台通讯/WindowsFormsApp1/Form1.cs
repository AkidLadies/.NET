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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void btn_coneect_Click(object sender, EventArgs e)
        {
            string text = this.txt_port.Text;
            Plc plc = new Plc(CpuType.S71500, "text", 0, 0);
            plc.Open();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            
        }
    }
}
