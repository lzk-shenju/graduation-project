namespace LearnOpenCVEdu.FrmFunctions
{
    partial class FrmBlur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBlur));
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.TrackKernelSize = new System.Windows.Forms.TrackBar();
            this.CheckEnablePreview = new System.Windows.Forms.CheckBox();
            this.CheckNormalize = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblKernelSize = new System.Windows.Forms.Label();
            this.CbbFilterType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackKernelSize)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(136, 240);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(105, 54);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConfirm.Location = new System.Drawing.Point(26, 240);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(105, 54);
            this.BtnConfirm.TabIndex = 10;
            this.BtnConfirm.Text = "确定";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // TrackKernelSize
            // 
            this.TrackKernelSize.Location = new System.Drawing.Point(135, 172);
            this.TrackKernelSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrackKernelSize.Maximum = 21;
            this.TrackKernelSize.Minimum = 3;
            this.TrackKernelSize.Name = "TrackKernelSize";
            this.TrackKernelSize.Size = new System.Drawing.Size(441, 69);
            this.TrackKernelSize.SmallChange = 2;
            this.TrackKernelSize.TabIndex = 12;
            this.TrackKernelSize.Value = 3;
            this.TrackKernelSize.Scroll += new System.EventHandler(this.TrackKernelSize_Scroll);
            // 
            // CheckEnablePreview
            // 
            this.CheckEnablePreview.AutoSize = true;
            this.CheckEnablePreview.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckEnablePreview.Location = new System.Drawing.Point(25, 74);
            this.CheckEnablePreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckEnablePreview.Name = "CheckEnablePreview";
            this.CheckEnablePreview.Size = new System.Drawing.Size(108, 28);
            this.CheckEnablePreview.TabIndex = 13;
            this.CheckEnablePreview.Text = "启用预览";
            this.CheckEnablePreview.UseVisualStyleBackColor = true;
            this.CheckEnablePreview.CheckedChanged += new System.EventHandler(this.CheckEnablePreview_CheckedChanged);
            // 
            // CheckNormalize
            // 
            this.CheckNormalize.AutoSize = true;
            this.CheckNormalize.Checked = true;
            this.CheckNormalize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckNormalize.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckNormalize.Location = new System.Drawing.Point(309, 122);
            this.CheckNormalize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckNormalize.Name = "CheckNormalize";
            this.CheckNormalize.Size = new System.Drawing.Size(90, 28);
            this.CheckNormalize.TabIndex = 13;
            this.CheckNormalize.Text = "归一化";
            this.CheckNormalize.UseVisualStyleBackColor = true;
            this.CheckNormalize.CheckedChanged += new System.EventHandler(this.CheckNormalize_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "卷积核大小：";
            // 
            // LblKernelSize
            // 
            this.LblKernelSize.AutoSize = true;
            this.LblKernelSize.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblKernelSize.Location = new System.Drawing.Point(572, 174);
            this.LblKernelSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblKernelSize.Name = "LblKernelSize";
            this.LblKernelSize.Size = new System.Drawing.Size(52, 24);
            this.LblKernelSize.TabIndex = 13;
            this.LblKernelSize.Text = "label";
            // 
            // CbbFilterType
            // 
            this.CbbFilterType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.CbbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbFilterType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CbbFilterType.FormattingEnabled = true;
            this.CbbFilterType.Items.AddRange(new object[] {
            "均值滤波",
            "方框滤波",
            "高斯滤波",
            "中值滤波"});
            this.CbbFilterType.Location = new System.Drawing.Point(146, 119);
            this.CbbFilterType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbbFilterType.Name = "CbbFilterType";
            this.CbbFilterType.Size = new System.Drawing.Size(138, 32);
            this.CbbFilterType.TabIndex = 15;
            this.CbbFilterType.SelectedIndexChanged += new System.EventHandler(this.CbbFilterType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "滤波类型：";
            // 
            // FrmBlur
            // 
            this.AcceptButton = this.BtnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(628, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblKernelSize);
            this.Controls.Add(this.CheckNormalize);
            this.Controls.Add(this.CbbFilterType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrackKernelSize);
            this.Controls.Add(this.CheckEnablePreview);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBlur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "平滑/模糊";
            this.Load += new System.EventHandler(this.FrmBlurAverage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackKernelSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.TrackBar TrackKernelSize;
        private System.Windows.Forms.CheckBox CheckEnablePreview;
        private System.Windows.Forms.Label LblKernelSize;
        private System.Windows.Forms.ComboBox CbbFilterType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckNormalize;
        private System.Windows.Forms.Label label2;
    }
}