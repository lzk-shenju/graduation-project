namespace LearnOpenCVEdu.BasicFrms
{
    partial class FrmProperties
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProperties));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFilename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNumberOfChannels = new System.Windows.Forms.TextBox();
            this.TxtWidth = new System.Windows.Forms.TextBox();
            this.TxtHeight = new System.Windows.Forms.TextBox();
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBlackPixel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtWhitePixel = new System.Windows.Forms.TextBox();
            this.BtnHistogram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(14, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "通道数（shape）：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(14, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "宽（shape）：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(14, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "高（shape）：";
            // 
            // TxtFilename
            // 
            this.TxtFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtFilename.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtFilename.Location = new System.Drawing.Point(180, 73);
            this.TxtFilename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtFilename.Name = "TxtFilename";
            this.TxtFilename.ReadOnly = true;
            this.TxtFilename.Size = new System.Drawing.Size(174, 31);
            this.TxtFilename.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(14, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "总像素数（size）：";
            // 
            // TxtNumberOfChannels
            // 
            this.TxtNumberOfChannels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtNumberOfChannels.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtNumberOfChannels.Location = new System.Drawing.Point(180, 112);
            this.TxtNumberOfChannels.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNumberOfChannels.Name = "TxtNumberOfChannels";
            this.TxtNumberOfChannels.ReadOnly = true;
            this.TxtNumberOfChannels.Size = new System.Drawing.Size(174, 31);
            this.TxtNumberOfChannels.TabIndex = 2;
            // 
            // TxtWidth
            // 
            this.TxtWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtWidth.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtWidth.Location = new System.Drawing.Point(180, 152);
            this.TxtWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtWidth.Name = "TxtWidth";
            this.TxtWidth.ReadOnly = true;
            this.TxtWidth.Size = new System.Drawing.Size(174, 31);
            this.TxtWidth.TabIndex = 3;
            // 
            // TxtHeight
            // 
            this.TxtHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtHeight.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtHeight.Location = new System.Drawing.Point(180, 192);
            this.TxtHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtHeight.Name = "TxtHeight";
            this.TxtHeight.ReadOnly = true;
            this.TxtHeight.Size = new System.Drawing.Size(174, 31);
            this.TxtHeight.TabIndex = 4;
            // 
            // TxtSize
            // 
            this.TxtSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtSize.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtSize.Location = new System.Drawing.Point(180, 232);
            this.TxtSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.ReadOnly = true;
            this.TxtSize.Size = new System.Drawing.Size(174, 31);
            this.TxtSize.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(14, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "黑点数：";
            // 
            // TxtBlackPixel
            // 
            this.TxtBlackPixel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtBlackPixel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtBlackPixel.Location = new System.Drawing.Point(180, 272);
            this.TxtBlackPixel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBlackPixel.Name = "TxtBlackPixel";
            this.TxtBlackPixel.ReadOnly = true;
            this.TxtBlackPixel.Size = new System.Drawing.Size(174, 31);
            this.TxtBlackPixel.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(14, 311);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "非黑点：";
            // 
            // TxtWhitePixel
            // 
            this.TxtWhitePixel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtWhitePixel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtWhitePixel.Location = new System.Drawing.Point(180, 311);
            this.TxtWhitePixel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtWhitePixel.Name = "TxtWhitePixel";
            this.TxtWhitePixel.ReadOnly = true;
            this.TxtWhitePixel.Size = new System.Drawing.Size(174, 31);
            this.TxtWhitePixel.TabIndex = 7;
            // 
            // BtnHistogram
            // 
            this.BtnHistogram.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnHistogram.Location = new System.Drawing.Point(20, 354);
            this.BtnHistogram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnHistogram.Name = "BtnHistogram";
            this.BtnHistogram.Size = new System.Drawing.Size(332, 53);
            this.BtnHistogram.TabIndex = 8;
            this.BtnHistogram.Text = "直方图";
            this.BtnHistogram.UseVisualStyleBackColor = true;
            this.BtnHistogram.Click += new System.EventHandler(this.BtnHistogram_Click);
            // 
            // FrmProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(365, 425);
            this.Controls.Add(this.BtnHistogram);
            this.Controls.Add(this.TxtWhitePixel);
            this.Controls.Add(this.TxtBlackPixel);
            this.Controls.Add(this.TxtSize);
            this.Controls.Add(this.TxtHeight);
            this.Controls.Add(this.TxtWidth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtNumberOfChannels);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtFilename);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "图片基本属性";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFilename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNumberOfChannels;
        private System.Windows.Forms.TextBox TxtWidth;
        private System.Windows.Forms.TextBox TxtHeight;
        private System.Windows.Forms.TextBox TxtSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBlackPixel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtWhitePixel;
        private System.Windows.Forms.Button BtnHistogram;
    }
}