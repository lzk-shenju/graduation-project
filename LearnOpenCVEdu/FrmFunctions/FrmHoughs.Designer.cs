﻿namespace LearnOpenCVEdu.FrmFunctions
{
    partial class FrmHoughs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoughs));
            this.NumberRho = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblThreshold = new System.Windows.Forms.Label();
            this.TrackThreshold = new System.Windows.Forms.TrackBar();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NumericThickness = new System.Windows.Forms.NumericUpDown();
            this.BtnCustomColor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberRho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackThreshold)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericThickness)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberRho
            // 
            this.NumberRho.DecimalPlaces = 1;
            this.NumberRho.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NumberRho.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumberRho.Location = new System.Drawing.Point(134, 79);
            this.NumberRho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumberRho.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumberRho.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumberRho.Name = "NumberRho";
            this.NumberRho.Size = new System.Drawing.Size(90, 31);
            this.NumberRho.TabIndex = 0;
            this.NumberRho.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.NumberRho.ValueChanged += new System.EventHandler(this.NumberRho_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "距离值rho：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "阈值：";
            // 
            // LblThreshold
            // 
            this.LblThreshold.AutoSize = true;
            this.LblThreshold.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblThreshold.Location = new System.Drawing.Point(509, 122);
            this.LblThreshold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblThreshold.Name = "LblThreshold";
            this.LblThreshold.Size = new System.Drawing.Size(52, 24);
            this.LblThreshold.TabIndex = 15;
            this.LblThreshold.Text = "label";
            // 
            // TrackThreshold
            // 
            this.TrackThreshold.Location = new System.Drawing.Point(71, 118);
            this.TrackThreshold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrackThreshold.Maximum = 255;
            this.TrackThreshold.Name = "TrackThreshold";
            this.TrackThreshold.Size = new System.Drawing.Size(442, 69);
            this.TrackThreshold.SmallChange = 2;
            this.TrackThreshold.TabIndex = 14;
            this.TrackThreshold.Value = 90;
            this.TrackThreshold.Scroll += new System.EventHandler(this.TrackThreshold_Scroll);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(364, 256);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(105, 54);
            this.BtnCancel.TabIndex = 17;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConfirm.Location = new System.Drawing.Point(255, 256);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(105, 54);
            this.BtnConfirm.TabIndex = 16;
            this.BtnConfirm.Text = "确定";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.NumericThickness);
            this.groupBox2.Controls.Add(this.BtnCustomColor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(18, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(222, 130);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "绘制选项";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(16, 44);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "颜色：";
            // 
            // NumericThickness
            // 
            this.NumericThickness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.NumericThickness.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NumericThickness.Location = new System.Drawing.Point(102, 82);
            this.NumericThickness.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumericThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericThickness.Name = "NumericThickness";
            this.NumericThickness.ReadOnly = true;
            this.NumericThickness.Size = new System.Drawing.Size(106, 31);
            this.NumericThickness.TabIndex = 13;
            this.NumericThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericThickness.ValueChanged += new System.EventHandler(this.NumericThickness_ValueChanged);
            // 
            // BtnCustomColor
            // 
            this.BtnCustomColor.BackColor = System.Drawing.Color.Red;
            this.BtnCustomColor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCustomColor.Location = new System.Drawing.Point(102, 38);
            this.BtnCustomColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCustomColor.Name = "BtnCustomColor";
            this.BtnCustomColor.Size = new System.Drawing.Size(106, 37);
            this.BtnCustomColor.TabIndex = 11;
            this.BtnCustomColor.UseVisualStyleBackColor = false;
            this.BtnCustomColor.Click += new System.EventHandler(this.BtnCustomColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(16, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "线宽：";
            // 
            // FrmHoughs
            // 
            this.AcceptButton = this.BtnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(570, 320);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.LblThreshold);
            this.Controls.Add(this.TrackThreshold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberRho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHoughs";
            this.Text = "FrmHoughs";
            this.Load += new System.EventHandler(this.FrmHoughs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberRho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackThreshold)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericThickness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumberRho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblThreshold;
        private System.Windows.Forms.TrackBar TrackThreshold;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown NumericThickness;
        private System.Windows.Forms.Button BtnCustomColor;
        private System.Windows.Forms.Label label9;
    }
}