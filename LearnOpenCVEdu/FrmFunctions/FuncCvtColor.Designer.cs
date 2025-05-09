﻿namespace LearnOpenCVEdu.FrmFunctions
{
    partial class FuncCvtColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncCvtColor));
            this.RadioBGR2GRAY = new System.Windows.Forms.RadioButton();
            this.RadioBGR2HSV = new System.Windows.Forms.RadioButton();
            this.RadioGRAY2BGR = new System.Windows.Forms.RadioButton();
            this.RadioOthers = new System.Windows.Forms.RadioButton();
            this.CbbCvtColorTypes = new System.Windows.Forms.ComboBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RadioBGR2GRAY
            // 
            this.RadioBGR2GRAY.AutoSize = true;
            this.RadioBGR2GRAY.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioBGR2GRAY.Location = new System.Drawing.Point(25, 70);
            this.RadioBGR2GRAY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioBGR2GRAY.Name = "RadioBGR2GRAY";
            this.RadioBGR2GRAY.Size = new System.Drawing.Size(397, 28);
            this.RadioBGR2GRAY.TabIndex = 1;
            this.RadioBGR2GRAY.Text = "彩色图转灰度图（cv2.COLOR_BGR2GRAY）";
            this.RadioBGR2GRAY.UseVisualStyleBackColor = true;
            this.RadioBGR2GRAY.CheckedChanged += new System.EventHandler(this.RadioBGR2GRAY_CheckedChanged);
            // 
            // RadioBGR2HSV
            // 
            this.RadioBGR2HSV.AutoSize = true;
            this.RadioBGR2HSV.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioBGR2HSV.Location = new System.Drawing.Point(25, 116);
            this.RadioBGR2HSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioBGR2HSV.Name = "RadioBGR2HSV";
            this.RadioBGR2HSV.Size = new System.Drawing.Size(366, 28);
            this.RadioBGR2HSV.TabIndex = 2;
            this.RadioBGR2HSV.Text = "彩色图转HSV（cv2.COLOR_BGR2HSV）";
            this.RadioBGR2HSV.UseVisualStyleBackColor = true;
            this.RadioBGR2HSV.CheckedChanged += new System.EventHandler(this.RadioBGR2HSV_CheckedChanged);
            // 
            // RadioGRAY2BGR
            // 
            this.RadioGRAY2BGR.AutoSize = true;
            this.RadioGRAY2BGR.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioGRAY2BGR.Location = new System.Drawing.Point(25, 162);
            this.RadioGRAY2BGR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioGRAY2BGR.Name = "RadioGRAY2BGR";
            this.RadioGRAY2BGR.Size = new System.Drawing.Size(397, 28);
            this.RadioGRAY2BGR.TabIndex = 3;
            this.RadioGRAY2BGR.Text = "灰度图转彩色图（cv2.COLOR_GRAY2BGR）";
            this.RadioGRAY2BGR.UseVisualStyleBackColor = true;
            this.RadioGRAY2BGR.CheckedChanged += new System.EventHandler(this.RadioGRAY2BGR_CheckedChanged);
            // 
            // RadioOthers
            // 
            this.RadioOthers.AutoSize = true;
            this.RadioOthers.Enabled = false;
            this.RadioOthers.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioOthers.Location = new System.Drawing.Point(25, 208);
            this.RadioOthers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioOthers.Name = "RadioOthers";
            this.RadioOthers.Size = new System.Drawing.Size(125, 28);
            this.RadioOthers.TabIndex = 4;
            this.RadioOthers.Text = "其他常用：";
            this.RadioOthers.UseVisualStyleBackColor = true;
            this.RadioOthers.CheckedChanged += new System.EventHandler(this.RadioOthers_CheckedChanged);
            // 
            // CbbCvtColorTypes
            // 
            this.CbbCvtColorTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.CbbCvtColorTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbCvtColorTypes.Enabled = false;
            this.CbbCvtColorTypes.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CbbCvtColorTypes.FormattingEnabled = true;
            this.CbbCvtColorTypes.Location = new System.Drawing.Point(153, 207);
            this.CbbCvtColorTypes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbbCvtColorTypes.Name = "CbbCvtColorTypes";
            this.CbbCvtColorTypes.Size = new System.Drawing.Size(238, 32);
            this.CbbCvtColorTypes.TabIndex = 5;
            this.CbbCvtColorTypes.SelectedIndexChanged += new System.EventHandler(this.CbbCvtColorTypes_SelectedIndexChanged);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(303, 266);
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
            this.BtnConfirm.Location = new System.Drawing.Point(194, 266);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(105, 54);
            this.BtnConfirm.TabIndex = 6;
            this.BtnConfirm.Text = "确定";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // FuncCvtColor
            // 
            this.AcceptButton = this.BtnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(436, 336);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.CbbCvtColorTypes);
            this.Controls.Add(this.RadioOthers);
            this.Controls.Add(this.RadioGRAY2BGR);
            this.Controls.Add(this.RadioBGR2HSV);
            this.Controls.Add(this.RadioBGR2GRAY);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FuncCvtColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "颜色空间转换（cv2.cvtColor()）";
            this.Load += new System.EventHandler(this.FuncCvtColor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioBGR2GRAY;
        private System.Windows.Forms.RadioButton RadioBGR2HSV;
        private System.Windows.Forms.RadioButton RadioGRAY2BGR;
        private System.Windows.Forms.RadioButton RadioOthers;
        private System.Windows.Forms.ComboBox CbbCvtColorTypes;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnConfirm;
    }
}