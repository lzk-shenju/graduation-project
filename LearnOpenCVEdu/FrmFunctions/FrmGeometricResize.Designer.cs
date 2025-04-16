namespace LearnOpenCVEdu.FrmFunctions
{
    partial class FrmGeometricResize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeometricResize));
            this.RadioPercent = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtHorizen = new System.Windows.Forms.TextBox();
            this.TxtVertical = new System.Windows.Forms.TextBox();
            this.RadioPixel = new System.Windows.Forms.RadioButton();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.CheckHoldRatio = new System.Windows.Forms.CheckBox();
            this.BtnPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RadioPercent
            // 
            this.RadioPercent.AutoSize = true;
            this.RadioPercent.Checked = true;
            this.RadioPercent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioPercent.Location = new System.Drawing.Point(25, 70);
            this.RadioPercent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadioPercent.Name = "RadioPercent";
            this.RadioPercent.Size = new System.Drawing.Size(143, 28);
            this.RadioPercent.TabIndex = 0;
            this.RadioPercent.TabStop = true;
            this.RadioPercent.Text = "按百分比缩放";
            this.RadioPercent.UseVisualStyleBackColor = true;
            this.RadioPercent.CheckedChanged += new System.EventHandler(this.RadioPercent_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "水平：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "垂直：";
            // 
            // TxtHorizen
            // 
            this.TxtHorizen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtHorizen.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtHorizen.Location = new System.Drawing.Point(86, 118);
            this.TxtHorizen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtHorizen.Name = "TxtHorizen";
            this.TxtHorizen.Size = new System.Drawing.Size(87, 31);
            this.TxtHorizen.TabIndex = 2;
            this.TxtHorizen.Text = "100";
            this.TxtHorizen.TextChanged += new System.EventHandler(this.TxtHorizen_TextChanged);
            this.TxtHorizen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // TxtVertical
            // 
            this.TxtVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtVertical.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtVertical.Location = new System.Drawing.Point(86, 164);
            this.TxtVertical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtVertical.Name = "TxtVertical";
            this.TxtVertical.Size = new System.Drawing.Size(89, 31);
            this.TxtVertical.TabIndex = 3;
            this.TxtVertical.Text = "100";
            this.TxtVertical.TextChanged += new System.EventHandler(this.TxtVertical_TextChanged);
            this.TxtVertical.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // RadioPixel
            // 
            this.RadioPixel.AutoSize = true;
            this.RadioPixel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioPixel.Location = new System.Drawing.Point(215, 70);
            this.RadioPixel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadioPixel.Name = "RadioPixel";
            this.RadioPixel.Size = new System.Drawing.Size(125, 28);
            this.RadioPixel.TabIndex = 1;
            this.RadioPixel.Text = "按像素缩放";
            this.RadioPixel.UseVisualStyleBackColor = true;
            this.RadioPixel.CheckedChanged += new System.EventHandler(this.RadioPixel_CheckedChanged);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(272, 217);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(105, 54);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConfirm.Location = new System.Drawing.Point(162, 217);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(105, 54);
            this.BtnConfirm.TabIndex = 6;
            this.BtnConfirm.Text = "确定";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // CheckHoldRatio
            // 
            this.CheckHoldRatio.AutoSize = true;
            this.CheckHoldRatio.Checked = true;
            this.CheckHoldRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckHoldRatio.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckHoldRatio.Location = new System.Drawing.Point(214, 166);
            this.CheckHoldRatio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckHoldRatio.Name = "CheckHoldRatio";
            this.CheckHoldRatio.Size = new System.Drawing.Size(126, 28);
            this.CheckHoldRatio.TabIndex = 4;
            this.CheckHoldRatio.Text = "保持纵横比";
            this.CheckHoldRatio.UseVisualStyleBackColor = true;
            // 
            // BtnPreview
            // 
            this.BtnPreview.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPreview.Location = new System.Drawing.Point(26, 217);
            this.BtnPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(105, 54);
            this.BtnPreview.TabIndex = 5;
            this.BtnPreview.Text = "预览";
            this.BtnPreview.UseVisualStyleBackColor = true;
            this.BtnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // FrmGeometricResize
            // 
            this.AcceptButton = this.BtnPreview;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(388, 282);
            this.Controls.Add(this.CheckHoldRatio);
            this.Controls.Add(this.BtnPreview);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.TxtVertical);
            this.Controls.Add(this.TxtHorizen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RadioPixel);
            this.Controls.Add(this.RadioPercent);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGeometricResize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "缩放";
            this.Load += new System.EventHandler(this.FrmGeometricResize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioPercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtHorizen;
        private System.Windows.Forms.TextBox TxtVertical;
        private System.Windows.Forms.RadioButton RadioPixel;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.CheckBox CheckHoldRatio;
        private System.Windows.Forms.Button BtnPreview;
    }
}