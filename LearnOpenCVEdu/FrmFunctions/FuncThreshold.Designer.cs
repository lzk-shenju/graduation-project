namespace LearnOpenCVEdu.FrmFunctions
{
    partial class FuncThreshold
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncThreshold));
            this.label1 = new System.Windows.Forms.Label();
            this.TrackThreshold = new System.Windows.Forms.TrackBar();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CbbThresholdType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckOtsu = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblThreshold = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "阈值：";
            // 
            // TrackThreshold
            // 
            this.TrackThreshold.Location = new System.Drawing.Point(80, 76);
            this.TrackThreshold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrackThreshold.Maximum = 255;
            this.TrackThreshold.Name = "TrackThreshold";
            this.TrackThreshold.Size = new System.Drawing.Size(322, 69);
            this.TrackThreshold.TabIndex = 1;
            this.TrackThreshold.Value = 127;
            this.TrackThreshold.Scroll += new System.EventHandler(this.TrackThreshold_Scroll);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConfirm.Location = new System.Drawing.Point(244, 278);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(105, 54);
            this.BtnConfirm.TabIndex = 4;
            this.BtnConfirm.Text = "确定";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(353, 278);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(105, 54);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "阈值方式：";
            // 
            // CbbThresholdType
            // 
            this.CbbThresholdType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.CbbThresholdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbThresholdType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CbbThresholdType.FormattingEnabled = true;
            this.CbbThresholdType.Items.AddRange(new object[] {
            "cv2.THRESH_BINARY",
            "cv2.THRESH_BINARY_INV",
            "cv2.THRESH_TRUNC",
            "cv2.THRESH_TOZERO",
            "cv2.THRESH_TOZERO_INV"});
            this.CbbThresholdType.Location = new System.Drawing.Point(126, 195);
            this.CbbThresholdType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbbThresholdType.Name = "CbbThresholdType";
            this.CbbThresholdType.Size = new System.Drawing.Size(333, 32);
            this.CbbThresholdType.TabIndex = 2;
            this.CbbThresholdType.SelectedIndexChanged += new System.EventHandler(this.CbbThresholdType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(21, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "最大阈值：";
            // 
            // CheckOtsu
            // 
            this.CheckOtsu.AutoSize = true;
            this.CheckOtsu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckOtsu.Location = new System.Drawing.Point(126, 236);
            this.CheckOtsu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckOtsu.Name = "CheckOtsu";
            this.CheckOtsu.Size = new System.Drawing.Size(149, 28);
            this.CheckOtsu.TabIndex = 3;
            this.CheckOtsu.Text = "Otsu自动阈值";
            this.CheckOtsu.UseVisualStyleBackColor = true;
            this.CheckOtsu.CheckedChanged += new System.EventHandler(this.CheckOtsu_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(114, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "255";
            // 
            // LblThreshold
            // 
            this.LblThreshold.AutoSize = true;
            this.LblThreshold.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblThreshold.Location = new System.Drawing.Point(407, 78);
            this.LblThreshold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblThreshold.Name = "LblThreshold";
            this.LblThreshold.Size = new System.Drawing.Size(52, 24);
            this.LblThreshold.TabIndex = 14;
            this.LblThreshold.Text = "label";
            // 
            // FuncThreshold
            // 
            this.AcceptButton = this.BtnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(481, 348);
            this.Controls.Add(this.LblThreshold);
            this.Controls.Add(this.CheckOtsu);
            this.Controls.Add(this.CbbThresholdType);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.TrackThreshold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FuncThreshold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "阈值分割";
            this.Load += new System.EventHandler(this.FuncThreshold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar TrackThreshold;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbbThresholdType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckOtsu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblThreshold;
    }
}