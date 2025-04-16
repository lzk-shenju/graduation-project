namespace LearnOpenCVEdu.FrmFunctions
{
    partial class FrmGeometricFlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeometricFlip));
            this.RadioHorizontal = new System.Windows.Forms.RadioButton();
            this.RadioVertical = new System.Windows.Forms.RadioButton();
            this.RadioBothDirection = new System.Windows.Forms.RadioButton();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RadioHorizontal
            // 
            this.RadioHorizontal.AutoSize = true;
            this.RadioHorizontal.Checked = true;
            this.RadioHorizontal.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioHorizontal.Location = new System.Drawing.Point(25, 72);
            this.RadioHorizontal.Margin = new System.Windows.Forms.Padding(4);
            this.RadioHorizontal.Name = "RadioHorizontal";
            this.RadioHorizontal.Size = new System.Drawing.Size(107, 28);
            this.RadioHorizontal.TabIndex = 1;
            this.RadioHorizontal.TabStop = true;
            this.RadioHorizontal.Text = "水平翻转";
            this.RadioHorizontal.UseVisualStyleBackColor = true;
            this.RadioHorizontal.CheckedChanged += new System.EventHandler(this.RadioHorizontal_CheckedChanged);
            // 
            // RadioVertical
            // 
            this.RadioVertical.AutoSize = true;
            this.RadioVertical.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioVertical.Location = new System.Drawing.Point(25, 117);
            this.RadioVertical.Margin = new System.Windows.Forms.Padding(4);
            this.RadioVertical.Name = "RadioVertical";
            this.RadioVertical.Size = new System.Drawing.Size(107, 28);
            this.RadioVertical.TabIndex = 2;
            this.RadioVertical.Text = "垂直翻转";
            this.RadioVertical.UseVisualStyleBackColor = true;
            this.RadioVertical.CheckedChanged += new System.EventHandler(this.RadioVertical_CheckedChanged);
            // 
            // RadioBothDirection
            // 
            this.RadioBothDirection.AutoSize = true;
            this.RadioBothDirection.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioBothDirection.Location = new System.Drawing.Point(25, 162);
            this.RadioBothDirection.Margin = new System.Windows.Forms.Padding(4);
            this.RadioBothDirection.Name = "RadioBothDirection";
            this.RadioBothDirection.Size = new System.Drawing.Size(143, 28);
            this.RadioBothDirection.TabIndex = 3;
            this.RadioBothDirection.Text = "水平垂直翻转";
            this.RadioBothDirection.UseVisualStyleBackColor = true;
            this.RadioBothDirection.CheckedChanged += new System.EventHandler(this.RadioBothDirection_CheckedChanged);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(204, 134);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(136, 54);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConfirm.Location = new System.Drawing.Point(204, 74);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(136, 54);
            this.BtnConfirm.TabIndex = 4;
            this.BtnConfirm.Text = "确定";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "cv2.flip(src,flipCode)";
            // 
            // FrmGeometricFlip
            // 
            this.AcceptButton = this.BtnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(362, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.RadioBothDirection);
            this.Controls.Add(this.RadioVertical);
            this.Controls.Add(this.RadioHorizontal);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGeometricFlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "镜像翻转";
            this.Load += new System.EventHandler(this.FrmGeometricFlip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioHorizontal;
        private System.Windows.Forms.RadioButton RadioVertical;
        private System.Windows.Forms.RadioButton RadioBothDirection;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Label label1;
    }
}