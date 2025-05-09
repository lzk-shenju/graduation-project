﻿namespace LearnOpenCVEdu.FrmFunctions
{
    partial class FrmContours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContours));
            this.label3 = new System.Windows.Forms.Label();
            this.CbbRetrType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbbApproxMethod = new System.Windows.Forms.ComboBox();
            this.BtnFindContours = new System.Windows.Forms.Button();
            this.BtnDrawAllContours = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NumListContours = new System.Windows.Forms.NumericUpDown();
            this.PanelContourFeatures = new System.Windows.Forms.Panel();
            this.CbbCascadeDarwing = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtHuMoments = new System.Windows.Forms.TextBox();
            this.TxtMoments = new System.Windows.Forms.TextBox();
            this.BtnDrawRectangle = new System.Windows.Forms.Button();
            this.BtnDrawMinCircle = new System.Windows.Forms.Button();
            this.BtnDrawMinRectangle = new System.Windows.Forms.Button();
            this.TxtContourCenter = new System.Windows.Forms.TextBox();
            this.TxtArcLength = new System.Windows.Forms.TextBox();
            this.TxtContourArea = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumericThickness = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnCustomColor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CbbRandomColor = new System.Windows.Forms.CheckBox();
            this.LblNumberContours = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumListContours)).BeginInit();
            this.PanelContourFeatures.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericThickness)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "轮廓查找方式：";
            // 
            // CbbRetrType
            // 
            this.CbbRetrType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.CbbRetrType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbRetrType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CbbRetrType.FormattingEnabled = true;
            this.CbbRetrType.Items.AddRange(new object[] {
            "External",
            "List",
            "Ccomp",
            "Tree"});
            this.CbbRetrType.Location = new System.Drawing.Point(150, 33);
            this.CbbRetrType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbbRetrType.Name = "CbbRetrType";
            this.CbbRetrType.Size = new System.Drawing.Size(90, 32);
            this.CbbRetrType.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "轮廓近似方法：";
            // 
            // CbbApproxMethod
            // 
            this.CbbApproxMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.CbbApproxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbApproxMethod.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CbbApproxMethod.FormattingEnabled = true;
            this.CbbApproxMethod.Items.AddRange(new object[] {
            "ChainCode",
            "ChainApproxNone",
            "ChainApproxSimple",
            "ChainApproxTc89L1",
            "ChainApproxTc89Kcos",
            "LinkRuns"});
            this.CbbApproxMethod.Location = new System.Drawing.Point(17, 112);
            this.CbbApproxMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbbApproxMethod.Name = "CbbApproxMethod";
            this.CbbApproxMethod.Size = new System.Drawing.Size(223, 32);
            this.CbbApproxMethod.TabIndex = 5;
            // 
            // BtnFindContours
            // 
            this.BtnFindContours.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnFindContours.Location = new System.Drawing.Point(17, 157);
            this.BtnFindContours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnFindContours.Name = "BtnFindContours";
            this.BtnFindContours.Size = new System.Drawing.Size(106, 40);
            this.BtnFindContours.TabIndex = 6;
            this.BtnFindContours.Text = "寻找轮廓";
            this.BtnFindContours.UseVisualStyleBackColor = true;
            this.BtnFindContours.Click += new System.EventHandler(this.BtnFindContours_Click);
            // 
            // BtnDrawAllContours
            // 
            this.BtnDrawAllContours.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDrawAllContours.Location = new System.Drawing.Point(17, 404);
            this.BtnDrawAllContours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDrawAllContours.Name = "BtnDrawAllContours";
            this.BtnDrawAllContours.Size = new System.Drawing.Size(222, 49);
            this.BtnDrawAllContours.TabIndex = 6;
            this.BtnDrawAllContours.Text = "绘制所有轮廓";
            this.BtnDrawAllContours.UseVisualStyleBackColor = true;
            this.BtnDrawAllContours.Click += new System.EventHandler(this.BtnDrawAllContours_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(19, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "选择轮廓：";
            // 
            // NumListContours
            // 
            this.NumListContours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.NumListContours.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NumListContours.Location = new System.Drawing.Point(115, 31);
            this.NumListContours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumListContours.Name = "NumListContours";
            this.NumListContours.Size = new System.Drawing.Size(90, 31);
            this.NumListContours.TabIndex = 9;
            this.NumListContours.ValueChanged += new System.EventHandler(this.NumListContours_ValueChanged);
            // 
            // PanelContourFeatures
            // 
            this.PanelContourFeatures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.PanelContourFeatures.Controls.Add(this.CbbCascadeDarwing);
            this.PanelContourFeatures.Controls.Add(this.NumListContours);
            this.PanelContourFeatures.Controls.Add(this.label4);
            this.PanelContourFeatures.Controls.Add(this.groupBox1);
            this.PanelContourFeatures.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelContourFeatures.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PanelContourFeatures.Location = new System.Drawing.Point(256, 0);
            this.PanelContourFeatures.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelContourFeatures.Name = "PanelContourFeatures";
            this.PanelContourFeatures.Size = new System.Drawing.Size(632, 517);
            this.PanelContourFeatures.TabIndex = 10;
            // 
            // CbbCascadeDarwing
            // 
            this.CbbCascadeDarwing.AutoSize = true;
            this.CbbCascadeDarwing.Location = new System.Drawing.Point(219, 34);
            this.CbbCascadeDarwing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbbCascadeDarwing.Name = "CbbCascadeDarwing";
            this.CbbCascadeDarwing.Size = new System.Drawing.Size(108, 28);
            this.CbbCascadeDarwing.TabIndex = 15;
            this.CbbCascadeDarwing.Text = "叠加绘制";
            this.CbbCascadeDarwing.UseVisualStyleBackColor = true;
            this.CbbCascadeDarwing.CheckedChanged += new System.EventHandler(this.CbbCascadeDarwing_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtHuMoments);
            this.groupBox1.Controls.Add(this.TxtMoments);
            this.groupBox1.Controls.Add(this.BtnDrawRectangle);
            this.groupBox1.Controls.Add(this.BtnDrawMinCircle);
            this.groupBox1.Controls.Add(this.BtnDrawMinRectangle);
            this.groupBox1.Controls.Add(this.TxtContourCenter);
            this.groupBox1.Controls.Add(this.TxtArcLength);
            this.groupBox1.Controls.Add(this.TxtContourArea);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(19, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(598, 374);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "轮廓特征";
            // 
            // TxtHuMoments
            // 
            this.TxtHuMoments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtHuMoments.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtHuMoments.Location = new System.Drawing.Point(385, 67);
            this.TxtHuMoments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtHuMoments.Multiline = true;
            this.TxtHuMoments.Name = "TxtHuMoments";
            this.TxtHuMoments.ReadOnly = true;
            this.TxtHuMoments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtHuMoments.Size = new System.Drawing.Size(199, 291);
            this.TxtHuMoments.TabIndex = 7;
            // 
            // TxtMoments
            // 
            this.TxtMoments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtMoments.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtMoments.Location = new System.Drawing.Point(193, 67);
            this.TxtMoments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtMoments.Multiline = true;
            this.TxtMoments.Name = "TxtMoments";
            this.TxtMoments.ReadOnly = true;
            this.TxtMoments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtMoments.Size = new System.Drawing.Size(188, 291);
            this.TxtMoments.TabIndex = 7;
            // 
            // BtnDrawRectangle
            // 
            this.BtnDrawRectangle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDrawRectangle.Location = new System.Drawing.Point(22, 224);
            this.BtnDrawRectangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDrawRectangle.Name = "BtnDrawRectangle";
            this.BtnDrawRectangle.Size = new System.Drawing.Size(158, 40);
            this.BtnDrawRectangle.TabIndex = 6;
            this.BtnDrawRectangle.Text = "绘制外接矩";
            this.BtnDrawRectangle.UseVisualStyleBackColor = true;
            this.BtnDrawRectangle.Click += new System.EventHandler(this.BtnDrawRectangle_Click);
            // 
            // BtnDrawMinCircle
            // 
            this.BtnDrawMinCircle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDrawMinCircle.Location = new System.Drawing.Point(22, 316);
            this.BtnDrawMinCircle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDrawMinCircle.Name = "BtnDrawMinCircle";
            this.BtnDrawMinCircle.Size = new System.Drawing.Size(158, 40);
            this.BtnDrawMinCircle.TabIndex = 6;
            this.BtnDrawMinCircle.Text = "绘制最小外接圆";
            this.BtnDrawMinCircle.UseVisualStyleBackColor = true;
            this.BtnDrawMinCircle.Click += new System.EventHandler(this.BtnDrawMinCircle_Click);
            // 
            // BtnDrawMinRectangle
            // 
            this.BtnDrawMinRectangle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDrawMinRectangle.Location = new System.Drawing.Point(22, 270);
            this.BtnDrawMinRectangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDrawMinRectangle.Name = "BtnDrawMinRectangle";
            this.BtnDrawMinRectangle.Size = new System.Drawing.Size(158, 40);
            this.BtnDrawMinRectangle.TabIndex = 6;
            this.BtnDrawMinRectangle.Text = "绘制最小外接矩";
            this.BtnDrawMinRectangle.UseVisualStyleBackColor = true;
            this.BtnDrawMinRectangle.Click += new System.EventHandler(this.BtnDrawMinRectangle_Click);
            // 
            // TxtContourCenter
            // 
            this.TxtContourCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtContourCenter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtContourCenter.Location = new System.Drawing.Point(89, 164);
            this.TxtContourCenter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtContourCenter.Name = "TxtContourCenter";
            this.TxtContourCenter.ReadOnly = true;
            this.TxtContourCenter.Size = new System.Drawing.Size(91, 31);
            this.TxtContourCenter.TabIndex = 7;
            // 
            // TxtArcLength
            // 
            this.TxtArcLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtArcLength.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtArcLength.Location = new System.Drawing.Point(89, 116);
            this.TxtArcLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtArcLength.Name = "TxtArcLength";
            this.TxtArcLength.ReadOnly = true;
            this.TxtArcLength.Size = new System.Drawing.Size(91, 31);
            this.TxtArcLength.TabIndex = 7;
            // 
            // TxtContourArea
            // 
            this.TxtContourArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtContourArea.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtContourArea.Location = new System.Drawing.Point(89, 67);
            this.TxtContourArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtContourArea.Name = "TxtContourArea";
            this.TxtContourArea.ReadOnly = true;
            this.TxtContourArea.Size = new System.Drawing.Size(91, 31);
            this.TxtContourArea.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(385, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 24);
            this.label11.TabIndex = 4;
            this.label11.Text = "Hu矩：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(193, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "轮廓矩：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(17, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "质心：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(17, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "周长：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(17, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "面积：";
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
            -2147483648});
            this.NumericThickness.Name = "NumericThickness";
            this.NumericThickness.ReadOnly = true;
            this.NumericThickness.Size = new System.Drawing.Size(106, 31);
            this.NumericThickness.TabIndex = 13;
            this.NumericThickness.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericThickness.ValueChanged += new System.EventHandler(this.NumericThickness_ValueChanged);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CbbRandomColor);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.NumericThickness);
            this.groupBox2.Controls.Add(this.BtnCustomColor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(17, 220);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(222, 169);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "绘制选项";
            // 
            // CbbRandomColor
            // 
            this.CbbRandomColor.AutoSize = true;
            this.CbbRandomColor.Location = new System.Drawing.Point(16, 130);
            this.CbbRandomColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbbRandomColor.Name = "CbbRandomColor";
            this.CbbRandomColor.Size = new System.Drawing.Size(108, 28);
            this.CbbRandomColor.TabIndex = 15;
            this.CbbRandomColor.Text = "随机颜色";
            this.CbbRandomColor.UseVisualStyleBackColor = true;
            this.CbbRandomColor.CheckedChanged += new System.EventHandler(this.CbbRandomColor_CheckedChanged);
            // 
            // LblNumberContours
            // 
            this.LblNumberContours.AutoSize = true;
            this.LblNumberContours.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblNumberContours.ForeColor = System.Drawing.Color.Red;
            this.LblNumberContours.Location = new System.Drawing.Point(128, 168);
            this.LblNumberContours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNumberContours.Name = "LblNumberContours";
            this.LblNumberContours.Size = new System.Drawing.Size(74, 24);
            this.LblNumberContours.TabIndex = 16;
            this.LblNumberContours.Text = "label12";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(133, 466);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(106, 44);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConfirm.Location = new System.Drawing.Point(17, 466);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(106, 44);
            this.BtnConfirm.TabIndex = 17;
            this.BtnConfirm.Text = "确定";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // FrmContours
            // 
            this.AcceptButton = this.BtnFindContours;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(888, 517);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.LblNumberContours);
            this.Controls.Add(this.BtnFindContours);
            this.Controls.Add(this.CbbApproxMethod);
            this.Controls.Add(this.BtnDrawAllContours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbbRetrType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PanelContourFeatures);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmContours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "轮廓特征";
            this.Load += new System.EventHandler(this.FrmContours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumListContours)).EndInit();
            this.PanelContourFeatures.ResumeLayout(false);
            this.PanelContourFeatures.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericThickness)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbbRetrType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbbApproxMethod;
        private System.Windows.Forms.Button BtnFindContours;
        private System.Windows.Forms.Button BtnDrawAllContours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumListContours;
        private System.Windows.Forms.Panel PanelContourFeatures;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtArcLength;
        private System.Windows.Forms.TextBox TxtContourArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtMoments;
        private System.Windows.Forms.TextBox TxtContourCenter;
        private System.Windows.Forms.Button BtnDrawRectangle;
        private System.Windows.Forms.Button BtnDrawMinRectangle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtHuMoments;
        private System.Windows.Forms.Button BtnDrawMinCircle;
        private System.Windows.Forms.NumericUpDown NumericThickness;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnCustomColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblNumberContours;
        private System.Windows.Forms.CheckBox CbbRandomColor;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.CheckBox CbbCascadeDarwing;
    }
}