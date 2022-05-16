
namespace tsst
{
    partial class Umotor
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_start_image = new System.Windows.Forms.PictureBox();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.btn_start = new HZH_Controls.Controls.UCBtnExt();
            ((System.ComponentModel.ISupportInitialize)(this.pic_start_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_start_image
            // 
            this.pic_start_image.Image = global::tsst.Properties.Resources.Geer_off;
            this.pic_start_image.Location = new System.Drawing.Point(127, 30);
            this.pic_start_image.Name = "pic_start_image";
            this.pic_start_image.Size = new System.Drawing.Size(55, 53);
            this.pic_start_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_start_image.TabIndex = 6;
            this.pic_start_image.TabStop = false;
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "停止";
            this.ucBtnExt1.ConerRadius = 5;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(0, 81);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(96, 37);
            this.ucBtnExt1.TabIndex = 5;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucBtnExt1.TipsText = "停止";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.White;
            this.btn_start.BtnBackColor = System.Drawing.Color.White;
            this.btn_start.BtnFont = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_start.BtnForeColor = System.Drawing.Color.White;
            this.btn_start.BtnText = "启动";
            this.btn_start.ConerRadius = 5;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_start.EnabledMouseEffect = false;
            this.btn_start.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_start.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_start.IsRadius = true;
            this.btn_start.IsShowRect = true;
            this.btn_start.IsShowTips = false;
            this.btn_start.Location = new System.Drawing.Point(0, 0);
            this.btn_start.Margin = new System.Windows.Forms.Padding(0);
            this.btn_start.Name = "btn_start";
            this.btn_start.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_start.RectWidth = 1;
            this.btn_start.Size = new System.Drawing.Size(96, 37);
            this.btn_start.TabIndex = 4;
            this.btn_start.TabStop = false;
            this.btn_start.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_start.TipsText = "";
            // 
            // Umotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_start_image);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.btn_start);
            this.Name = "Umotor";
            this.Size = new System.Drawing.Size(187, 125);
            ((System.ComponentModel.ISupportInitialize)(this.pic_start_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_start_image;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private HZH_Controls.Controls.UCBtnExt btn_start;
    }
}
