namespace LearnOpenCVEdu.FrmFunctions
{
    partial class FrmGeometricRotate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeometricRotate));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRotateX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRotateY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRotateAngle = new System.Windows.Forms.TextBox();
            this.TxtRotateScale = new System.Windows.Forms.TextBox();
            this.BtnPreview = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "旋转中心（默认图像中心点）：";
            // 
            // TxtRotateX
            // 
            this.TxtRotateX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtRotateX.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtRotateX.Location = new System.Drawing.Point(59, 109);
            this.TxtRotateX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtRotateX.Name = "TxtRotateX";
            this.TxtRotateX.Size = new System.Drawing.Size(96, 31);
            this.TxtRotateX.TabIndex = 1;
            this.TxtRotateX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "x：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(208, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "y：";
            // 
            // TxtRotateY
            // 
            this.TxtRotateY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtRotateY.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtRotateY.Location = new System.Drawing.Point(254, 110);
            this.TxtRotateY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtRotateY.Name = "TxtRotateY";
            this.TxtRotateY.Size = new System.Drawing.Size(96, 31);
            this.TxtRotateY.TabIndex = 2;
            this.TxtRotateY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(20, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "旋转角度（逆时针方向）：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(20, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "缩放比例：";
            // 
            // TxtRotateAngle
            // 
            this.TxtRotateAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtRotateAngle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtRotateAngle.Location = new System.Drawing.Point(254, 168);
            this.TxtRotateAngle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtRotateAngle.Name = "TxtRotateAngle";
            this.TxtRotateAngle.Size = new System.Drawing.Size(96, 31);
            this.TxtRotateAngle.TabIndex = 3;
            this.TxtRotateAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // TxtRotateScale
            // 
            this.TxtRotateScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtRotateScale.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtRotateScale.Location = new System.Drawing.Point(254, 212);
            this.TxtRotateScale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtRotateScale.Name = "TxtRotateScale";
            this.TxtRotateScale.Size = new System.Drawing.Size(96, 31);
            this.TxtRotateScale.TabIndex = 4;
            this.TxtRotateScale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // BtnPreview
            // 
            this.BtnPreview.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPreview.Location = new System.Drawing.Point(24, 280);
            this.BtnPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(105, 54);
            this.BtnPreview.TabIndex = 5;
            this.BtnPreview.Text = "预览";
            this.BtnPreview.UseVisualStyleBackColor = true;
            this.BtnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(244, 280);
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
            this.BtnConfirm.Location = new System.Drawing.Point(134, 280);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(105, 54);
            this.BtnConfirm.TabIndex = 6;
            this.BtnConfirm.Text = "确定";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // FrmGeometricRotate
            // 
            this.AcceptButton = this.BtnPreview;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(370, 352);
            this.Controls.Add(this.BtnPreview);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.TxtRotateY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtRotateScale);
            this.Controls.Add(this.TxtRotateAngle);
            this.Controls.Add(this.TxtRotateX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGeometricRotate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "旋转";
            this.Load += new System.EventHandler(this.FrmGeometricRotate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRotateX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtRotateY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtRotateAngle;
        private System.Windows.Forms.TextBox TxtRotateScale;
        private System.Windows.Forms.Button BtnPreview;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnConfirm;
    }
}