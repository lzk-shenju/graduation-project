namespace LearnOpenCVEdu.FrmFunctions
{
    partial class FrmHistogram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistogram));
            this.MainHistogram = new Emgu.CV.UI.HistogramBox();
            this.CbbGrayHistogram = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // MainHistogram
            // 
            this.MainHistogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainHistogram.Location = new System.Drawing.Point(0, 0);
            this.MainHistogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainHistogram.Name = "MainHistogram";
            this.MainHistogram.Size = new System.Drawing.Size(789, 466);
            this.MainHistogram.TabIndex = 0;
            this.MainHistogram.Load += new System.EventHandler(this.MainHistogram_Load);
            // 
            // CbbGrayHistogram
            // 
            this.CbbGrayHistogram.AutoSize = true;
            this.CbbGrayHistogram.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CbbGrayHistogram.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CbbGrayHistogram.Location = new System.Drawing.Point(0, 438);
            this.CbbGrayHistogram.Margin = new System.Windows.Forms.Padding(2);
            this.CbbGrayHistogram.Name = "CbbGrayHistogram";
            this.CbbGrayHistogram.Size = new System.Drawing.Size(789, 28);
            this.CbbGrayHistogram.TabIndex = 1;
            this.CbbGrayHistogram.Text = "灰度直方图";
            this.CbbGrayHistogram.UseVisualStyleBackColor = true;
            this.CbbGrayHistogram.CheckedChanged += new System.EventHandler(this.CbbGrayHistogram_CheckedChanged);
            // 
            // FrmHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(789, 466);
            this.Controls.Add(this.CbbGrayHistogram);
            this.Controls.Add(this.MainHistogram);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmHistogram";
            this.Text = "直方图";
            this.Load += new System.EventHandler(this.FrmHistogram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.HistogramBox MainHistogram;
        private System.Windows.Forms.CheckBox CbbGrayHistogram;
    }
}