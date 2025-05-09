﻿namespace LearnOpenCVEdu.FrmFunctions
{
    partial class FrmCameras
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCameras));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnOpenCamera = new System.Windows.Forms.ToolStripButton();
            this.CbbCameraIndex = new System.Windows.Forms.ToolStripComboBox();
            this.CbbResolution = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnOpenLocalVideo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnCaptureImage = new System.Windows.Forms.ToolStripButton();
            this.BtnRecording = new System.Windows.Forms.ToolStripButton();
            this.BtnProperties = new System.Windows.Forms.ToolStripSplitButton();
            this.CheckProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.PanelProperties = new System.Windows.Forms.Panel();
            this.TxtFourCC = new System.Windows.Forms.TextBox();
            this.TxtFPS = new System.Windows.Forms.TextBox();
            this.TxtFrameCount = new System.Windows.Forms.TextBox();
            this.TxtHeight = new System.Windows.Forms.TextBox();
            this.TxtWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PicVideos = new Emgu.CV.UI.ImageBox();
            this.toolStrip1.SuspendLayout();
            this.PanelProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnOpenCamera,
            this.CbbCameraIndex,
            this.CbbResolution,
            this.toolStripSeparator2,
            this.BtnOpenLocalVideo,
            this.toolStripSeparator1,
            this.BtnCaptureImage,
            this.BtnRecording,
            this.BtnProperties,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(1035, 41);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnOpenCamera
            // 
            this.BtnOpenCamera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnOpenCamera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOpenCamera.Name = "BtnOpenCamera";
            this.BtnOpenCamera.Size = new System.Drawing.Size(104, 36);
            this.BtnOpenCamera.Text = "打开摄像头";
            this.BtnOpenCamera.Click += new System.EventHandler(this.BtnOpenCamera_Click);
            // 
            // CbbCameraIndex
            // 
            this.CbbCameraIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.CbbCameraIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbCameraIndex.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.CbbCameraIndex.Name = "CbbCameraIndex";
            this.CbbCameraIndex.Size = new System.Drawing.Size(75, 41);
            // 
            // CbbResolution
            // 
            this.CbbResolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.CbbResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbResolution.Items.AddRange(new object[] {
            "default",
            "1920 × 1080",
            "1280 × 720",
            "640 × 480",
            "640 × 360"});
            this.CbbResolution.Name = "CbbResolution";
            this.CbbResolution.Size = new System.Drawing.Size(75, 41);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // BtnOpenLocalVideo
            // 
            this.BtnOpenLocalVideo.Image = global::LearnOpenCVEdu.Properties.Resources.appbar_cabinet_files;
            this.BtnOpenLocalVideo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOpenLocalVideo.Name = "BtnOpenLocalVideo";
            this.BtnOpenLocalVideo.Size = new System.Drawing.Size(154, 36);
            this.BtnOpenLocalVideo.Text = "播放本地视频";
            this.BtnOpenLocalVideo.Click += new System.EventHandler(this.BtnOpenLocalVideo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // BtnCaptureImage
            // 
            this.BtnCaptureImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCaptureImage.Image = global::LearnOpenCVEdu.Properties.Resources.appbar_camera;
            this.BtnCaptureImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCaptureImage.Name = "BtnCaptureImage";
            this.BtnCaptureImage.Size = new System.Drawing.Size(36, 36);
            this.BtnCaptureImage.Text = "捕获照片";
            this.BtnCaptureImage.Click += new System.EventHandler(this.BtnCaptureImage_Click);
            // 
            // BtnRecording
            // 
            this.BtnRecording.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRecording.Image = global::LearnOpenCVEdu.Properties.Resources.appbar_video;
            this.BtnRecording.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRecording.Name = "BtnRecording";
            this.BtnRecording.Size = new System.Drawing.Size(36, 36);
            this.BtnRecording.Text = "开始录制";
            this.BtnRecording.Click += new System.EventHandler(this.BtnRecording_Click);
            // 
            // BtnProperties
            // 
            this.BtnProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnProperties.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckProperties});
            this.BtnProperties.Image = global::LearnOpenCVEdu.Properties.Resources.appbar_settings;
            this.BtnProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnProperties.Name = "BtnProperties";
            this.BtnProperties.Size = new System.Drawing.Size(53, 36);
            this.BtnProperties.Text = "查看视频属性";
            this.BtnProperties.ButtonClick += new System.EventHandler(this.BtnProperties_ButtonClick);
            // 
            // CheckProperties
            // 
            this.CheckProperties.CheckOnClick = true;
            this.CheckProperties.Name = "CheckProperties";
            this.CheckProperties.Size = new System.Drawing.Size(218, 34);
            this.CheckProperties.Text = "查看视频属性";
            this.CheckProperties.Click += new System.EventHandler(this.BtnProperties_ButtonClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 41);
            // 
            // PanelProperties
            // 
            this.PanelProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.PanelProperties.Controls.Add(this.TxtFourCC);
            this.PanelProperties.Controls.Add(this.TxtFPS);
            this.PanelProperties.Controls.Add(this.TxtFrameCount);
            this.PanelProperties.Controls.Add(this.TxtHeight);
            this.PanelProperties.Controls.Add(this.TxtWidth);
            this.PanelProperties.Controls.Add(this.label2);
            this.PanelProperties.Controls.Add(this.label5);
            this.PanelProperties.Controls.Add(this.label4);
            this.PanelProperties.Controls.Add(this.label6);
            this.PanelProperties.Controls.Add(this.label1);
            this.PanelProperties.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelProperties.Location = new System.Drawing.Point(0, 559);
            this.PanelProperties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelProperties.Name = "PanelProperties";
            this.PanelProperties.Size = new System.Drawing.Size(1035, 88);
            this.PanelProperties.TabIndex = 6;
            this.PanelProperties.Visible = false;
            // 
            // TxtFourCC
            // 
            this.TxtFourCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtFourCC.Location = new System.Drawing.Point(419, 48);
            this.TxtFourCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtFourCC.Name = "TxtFourCC";
            this.TxtFourCC.ReadOnly = true;
            this.TxtFourCC.Size = new System.Drawing.Size(180, 31);
            this.TxtFourCC.TabIndex = 4;
            // 
            // TxtFPS
            // 
            this.TxtFPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtFPS.Location = new System.Drawing.Point(105, 48);
            this.TxtFPS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtFPS.Name = "TxtFPS";
            this.TxtFPS.ReadOnly = true;
            this.TxtFPS.Size = new System.Drawing.Size(175, 31);
            this.TxtFPS.TabIndex = 4;
            // 
            // TxtFrameCount
            // 
            this.TxtFrameCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtFrameCount.Location = new System.Drawing.Point(419, 13);
            this.TxtFrameCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtFrameCount.Name = "TxtFrameCount";
            this.TxtFrameCount.ReadOnly = true;
            this.TxtFrameCount.Size = new System.Drawing.Size(180, 31);
            this.TxtFrameCount.TabIndex = 2;
            // 
            // TxtHeight
            // 
            this.TxtHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtHeight.Location = new System.Drawing.Point(219, 13);
            this.TxtHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtHeight.Name = "TxtHeight";
            this.TxtHeight.ReadOnly = true;
            this.TxtHeight.Size = new System.Drawing.Size(61, 31);
            this.TxtHeight.TabIndex = 2;
            // 
            // TxtWidth
            // 
            this.TxtWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.TxtWidth.Location = new System.Drawing.Point(105, 12);
            this.TxtWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtWidth.Name = "TxtWidth";
            this.TxtWidth.ReadOnly = true;
            this.TxtWidth.Size = new System.Drawing.Size(61, 31);
            this.TxtWidth.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "总帧数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "FourCC编码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "帧率：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "×";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "分辨率：";
            // 
            // PicVideos
            // 
            this.PicVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.PicVideos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicVideos.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.RightClickMenu;
            this.PicVideos.Location = new System.Drawing.Point(0, 41);
            this.PicVideos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PicVideos.Name = "PicVideos";
            this.PicVideos.Size = new System.Drawing.Size(1035, 518);
            this.PicVideos.TabIndex = 2;
            this.PicVideos.TabStop = false;
            // 
            // FrmCameras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1035, 647);
            this.Controls.Add(this.PicVideos);
            this.Controls.Add(this.PanelProperties);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCameras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "摄像头助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCameras_FormClosing);
            this.Load += new System.EventHandler(this.FrmCameras_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PanelProperties.ResumeLayout(false);
            this.PanelProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicVideos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Emgu.CV.UI.ImageBox PicVideos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox CbbCameraIndex;
        private System.Windows.Forms.ToolStripButton BtnOpenCamera;
        private System.Windows.Forms.ToolStripButton BtnCaptureImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnOpenLocalVideo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BtnRecording;
        private System.Windows.Forms.Panel PanelProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFPS;
        private System.Windows.Forms.TextBox TxtFrameCount;
        private System.Windows.Forms.TextBox TxtWidth;
        private System.Windows.Forms.TextBox TxtFourCC;
        private System.Windows.Forms.TextBox TxtHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripSplitButton BtnProperties;
        private System.Windows.Forms.ToolStripMenuItem CheckProperties;
        private System.Windows.Forms.ToolStripComboBox CbbResolution;
    }
}