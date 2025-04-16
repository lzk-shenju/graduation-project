namespace LearnOpenCVEdu.FrmTeachingPages
{
    partial class TeachingCardControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panAndZoomPictureBox2 = new Emgu.CV.UI.PanAndZoomPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnHistogram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(43, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(743, 548);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panAndZoomPictureBox2
            // 
            this.panAndZoomPictureBox2.Location = new System.Drawing.Point(598, 353);
            this.panAndZoomPictureBox2.Name = "panAndZoomPictureBox2";
            this.panAndZoomPictureBox2.Size = new System.Drawing.Size(8, 8);
            this.panAndZoomPictureBox2.TabIndex = 3;
            this.panAndZoomPictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(992, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.BtnClose.BackgroundImage = global::LearnOpenCVEdu.Properties.Resources.appbar_close;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(1336, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(39, 39);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnHistogram
            // 
            this.BtnHistogram.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnHistogram.Location = new System.Drawing.Point(1043, 837);
            this.BtnHistogram.Margin = new System.Windows.Forms.Padding(2);
            this.BtnHistogram.Name = "BtnHistogram";
            this.BtnHistogram.Size = new System.Drawing.Size(332, 53);
            this.BtnHistogram.TabIndex = 9;
            this.BtnHistogram.Text = "了解详情";
            this.BtnHistogram.UseVisualStyleBackColor = true;
            this.BtnHistogram.Click += new System.EventHandler(this.BtnHistogram_Click);
            // 
            // TeachingCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnHistogram);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panAndZoomPictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "TeachingCardControl";
            this.Size = new System.Drawing.Size(1378, 892);
            this.Load += new System.EventHandler(this.TeachingCardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Emgu.CV.UI.PanAndZoomPictureBox panAndZoomPictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnHistogram;
    }
}
