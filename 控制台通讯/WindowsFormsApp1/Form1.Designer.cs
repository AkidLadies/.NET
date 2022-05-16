
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btn_coneect = new System.Windows.Forms.Button();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_portout = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_coneect
            // 
            this.btn_coneect.Location = new System.Drawing.Point(451, 72);
            this.btn_coneect.Name = "btn_coneect";
            this.btn_coneect.Size = new System.Drawing.Size(157, 57);
            this.btn_coneect.TabIndex = 0;
            this.btn_coneect.Text = "button1";
            this.btn_coneect.UseVisualStyleBackColor = true;
            this.btn_coneect.Click += new System.EventHandler(this.btn_coneect_Click);
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(131, 72);
            this.txt_port.Multiline = true;
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(143, 40);
            this.txt_port.TabIndex = 2;
            // 
            // txt_portout
            // 
            this.txt_portout.Location = new System.Drawing.Point(131, 156);
            this.txt_portout.Multiline = true;
            this.txt_portout.Name = "txt_portout";
            this.txt_portout.Size = new System.Drawing.Size(143, 40);
            this.txt_portout.TabIndex = 3;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(451, 200);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(157, 57);
            this.btn_run.TabIndex = 4;
            this.btn_run.Text = "button1";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(451, 306);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(157, 57);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "button1";
            this.btn_stop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.txt_portout);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.btn_coneect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_coneect;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_portout;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_stop;
    }
}

