
namespace tsst
{
    partial class btn_stop
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_start_image = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_start_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_start_image
            // 
            this.pic_start_image.Image = global::tsst.Properties.Resources.Geer_off;
            this.pic_start_image.Location = new System.Drawing.Point(201, 69);
            this.pic_start_image.Name = "pic_start_image";
            this.pic_start_image.Size = new System.Drawing.Size(55, 53);
            this.pic_start_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_start_image.TabIndex = 3;
            this.pic_start_image.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(46, 33);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(96, 41);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "启动";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_BtnClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_stop
            // 
            this.ClientSize = new System.Drawing.Size(868, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pic_start_image);
            this.Name = "btn_stop";
            ((System.ComponentModel.ISupportInitialize)(this.pic_start_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_stsrt_image;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pic_start_image;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button button1;
    }
}

