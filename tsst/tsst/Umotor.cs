using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tsst
{
    public partial class Umotor : UserControl
    {
        public Umotor()
        {
            InitializeComponent();
        }
        private bool start;

        public bool Start
        {
            get { 
                return start; 
            }
            set { 
                start = value;
                if (value)
                {
                    this.pic_start_image.Image = Properties.Resources.Geer_on;
                }
                else
                {
                    this.pic_start_image.Image = Properties.Resources.Geer_off;
                }
            }
        }
        public  string output { get; set; }

    }
}
