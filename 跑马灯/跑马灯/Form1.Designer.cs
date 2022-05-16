
namespace 跑马灯
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
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.txt_q01 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_run
            // 
            this.btn_run.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_run.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_run.FlatAppearance.BorderSize = 0;
            this.btn_run.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_run.Location = new System.Drawing.Point(654, 272);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(111, 49);
            this.btn_run.TabIndex = 0;
            this.btn_run.Text = "开始";
            this.btn_run.UseVisualStyleBackColor = false;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stop.FlatAppearance.BorderSize = 0;
            this.btn_stop.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_stop.Location = new System.Drawing.Point(654, 341);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(111, 49);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "停止";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // txt_q01
            // 
            this.txt_q01.Location = new System.Drawing.Point(88, 164);
            this.txt_q01.Name = "txt_q01";
            this.txt_q01.Size = new System.Drawing.Size(100, 25);
            this.txt_q01.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_q01);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_run);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TextBox txt_q01;
    }
}

