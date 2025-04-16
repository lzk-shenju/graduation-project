namespace LearnOpenCVEdu
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReadImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenSamples = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuOpenCamera = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRestoreOrigin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaveCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.预处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSplitChannels = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGeometric = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGeometricResize = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGeometricRotate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGeometricShift = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGeometricFlip = new System.Windows.Forms.ToolStripMenuItem();
            this.仿射变换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.透视变换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDrawingFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuCvtColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuThreshold = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBlur = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCannyEdge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuMorphology = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuErodeDilate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenCloseMorphology = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOtherMorphology = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuContoursFeatures = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHoughTransform = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHoughLine = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHoughLineP = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHoughCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.直方图均衡化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.直方图规定化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuShowProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuShowPicHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuShowFolderList = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHistogram = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVerticalLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHorizontalLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCascadeLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRestoreOriginMain = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ListPicHistory = new System.Windows.Forms.ListView();
            this.MenuPicHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuShowAlone = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBeMain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSaveHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.ImgListHistory = new System.Windows.Forms.ImageList(this.components);
            this.PanelFolderImages = new System.Windows.Forms.Panel();
            this.ListPicFolder = new System.Windows.Forms.ListView();
            this.MenuFolderPics = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuFolderPicShowAlone = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFolderPicBeMain = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LinkFolderPath = new System.Windows.Forms.LinkLabel();
            this.BtnListViewView = new System.Windows.Forms.Button();
            this.BtnRefreshFolder = new System.Windows.Forms.Button();
            this.图像锐化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.MenuPicHistory.SuspendLayout();
            this.PanelFolderImages.SuspendLayout();
            this.MenuFolderPics.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.预处理ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.窗口ToolStripMenuItem,
            this.MenuRestoreOriginMain,
            this.帮助ToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(1214, 32);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuReadImage,
            this.MenuOpenSamples,
            this.MenuOpenFolder,
            this.toolStripMenuItem4,
            this.MenuOpenCamera,
            this.MenuRestoreOrigin,
            this.MenuSaveCurrent});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // MenuReadImage
            // 
            this.MenuReadImage.Name = "MenuReadImage";
            this.MenuReadImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuReadImage.Size = new System.Drawing.Size(270, 34);
            this.MenuReadImage.Text = "打开图片…";
            this.MenuReadImage.Click += new System.EventHandler(this.MenuReadImage_Click);
            // 
            // MenuOpenSamples
            // 
            this.MenuOpenSamples.Name = "MenuOpenSamples";
            this.MenuOpenSamples.Size = new System.Drawing.Size(270, 34);
            this.MenuOpenSamples.Text = "打开示例图库";
            this.MenuOpenSamples.Click += new System.EventHandler(this.MenuOpenSamples_Click);
            // 
            // MenuOpenFolder
            // 
            this.MenuOpenFolder.Name = "MenuOpenFolder";
            this.MenuOpenFolder.Size = new System.Drawing.Size(270, 34);
            this.MenuOpenFolder.Text = "打开文件夹…";
            this.MenuOpenFolder.Click += new System.EventHandler(this.MenuOpenFolder_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(267, 6);
            // 
            // MenuOpenCamera
            // 
            this.MenuOpenCamera.Name = "MenuOpenCamera";
            this.MenuOpenCamera.Size = new System.Drawing.Size(270, 34);
            this.MenuOpenCamera.Text = "摄像头助手";
            this.MenuOpenCamera.Click += new System.EventHandler(this.MenuOpenCamera_Click);
            // 
            // MenuRestoreOrigin
            // 
            this.MenuRestoreOrigin.Name = "MenuRestoreOrigin";
            this.MenuRestoreOrigin.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.MenuRestoreOrigin.Size = new System.Drawing.Size(270, 34);
            this.MenuRestoreOrigin.Tag = "";
            this.MenuRestoreOrigin.Text = "恢复原图";
            this.MenuRestoreOrigin.Click += new System.EventHandler(this.MenuRestoreOrigin_Click);
            // 
            // MenuSaveCurrent
            // 
            this.MenuSaveCurrent.Name = "MenuSaveCurrent";
            this.MenuSaveCurrent.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSaveCurrent.Size = new System.Drawing.Size(270, 34);
            this.MenuSaveCurrent.Text = "另存图片…";
            this.MenuSaveCurrent.Click += new System.EventHandler(this.MenuSaveCurrent_Click);
            // 
            // 预处理ToolStripMenuItem
            // 
            this.预处理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSplitChannels,
            this.MenuGeometric,
            this.MenuDrawingFunction,
            this.toolStripMenuItem3,
            this.MenuCvtColor,
            this.MenuThreshold,
            this.MenuBlur,
            this.MenuCannyEdge,
            this.toolStripMenuItem5,
            this.MenuMorphology,
            this.MenuContoursFeatures,
            this.MenuHoughTransform,
            this.直方图均衡化ToolStripMenuItem,
            this.直方图规定化ToolStripMenuItem,
            this.图像锐化ToolStripMenuItem});
            this.预处理ToolStripMenuItem.Name = "预处理ToolStripMenuItem";
            this.预处理ToolStripMenuItem.Size = new System.Drawing.Size(120, 28);
            this.预处理ToolStripMenuItem.Text = "图像处理(&E)";
            // 
            // MenuSplitChannels
            // 
            this.MenuSplitChannels.Name = "MenuSplitChannels";
            this.MenuSplitChannels.Size = new System.Drawing.Size(273, 34);
            this.MenuSplitChannels.Text = "通道分离(&S)";
            this.MenuSplitChannels.Click += new System.EventHandler(this.MenuSplitChannels_Click);
            // 
            // MenuGeometric
            // 
            this.MenuGeometric.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuGeometricResize,
            this.MenuGeometricRotate,
            this.MenuGeometricShift,
            this.MenuGeometricFlip,
            this.仿射变换ToolStripMenuItem,
            this.透视变换ToolStripMenuItem});
            this.MenuGeometric.Name = "MenuGeometric";
            this.MenuGeometric.Size = new System.Drawing.Size(273, 34);
            this.MenuGeometric.Text = "几何变换(&G)";
            // 
            // MenuGeometricResize
            // 
            this.MenuGeometricResize.Name = "MenuGeometricResize";
            this.MenuGeometricResize.Size = new System.Drawing.Size(197, 34);
            this.MenuGeometricResize.Text = "缩放…";
            this.MenuGeometricResize.Click += new System.EventHandler(this.MenuGeometricResize_Click);
            // 
            // MenuGeometricRotate
            // 
            this.MenuGeometricRotate.Name = "MenuGeometricRotate";
            this.MenuGeometricRotate.Size = new System.Drawing.Size(197, 34);
            this.MenuGeometricRotate.Text = "旋转…";
            this.MenuGeometricRotate.Click += new System.EventHandler(this.MenuGeometricRotate_Click);
            // 
            // MenuGeometricShift
            // 
            this.MenuGeometricShift.Name = "MenuGeometricShift";
            this.MenuGeometricShift.Size = new System.Drawing.Size(197, 34);
            this.MenuGeometricShift.Text = "平移…";
            this.MenuGeometricShift.Click += new System.EventHandler(this.MenuGeometricShift_Click);
            // 
            // MenuGeometricFlip
            // 
            this.MenuGeometricFlip.Name = "MenuGeometricFlip";
            this.MenuGeometricFlip.Size = new System.Drawing.Size(197, 34);
            this.MenuGeometricFlip.Text = "镜像翻转…";
            this.MenuGeometricFlip.Click += new System.EventHandler(this.MenuGeometricFlip_Click);
            // 
            // 仿射变换ToolStripMenuItem
            // 
            this.仿射变换ToolStripMenuItem.Enabled = false;
            this.仿射变换ToolStripMenuItem.Name = "仿射变换ToolStripMenuItem";
            this.仿射变换ToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.仿射变换ToolStripMenuItem.Text = "仿射变换";
            // 
            // 透视变换ToolStripMenuItem
            // 
            this.透视变换ToolStripMenuItem.Enabled = false;
            this.透视变换ToolStripMenuItem.Name = "透视变换ToolStripMenuItem";
            this.透视变换ToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.透视变换ToolStripMenuItem.Text = "透视变换";
            // 
            // MenuDrawingFunction
            // 
            this.MenuDrawingFunction.Name = "MenuDrawingFunction";
            this.MenuDrawingFunction.Size = new System.Drawing.Size(273, 34);
            this.MenuDrawingFunction.Text = "绘图板(&D)";
            this.MenuDrawingFunction.Click += new System.EventHandler(this.MenuDrawingFunction_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(270, 6);
            // 
            // MenuCvtColor
            // 
            this.MenuCvtColor.Name = "MenuCvtColor";
            this.MenuCvtColor.Size = new System.Drawing.Size(273, 34);
            this.MenuCvtColor.Text = "颜色空间转换(&C)…";
            this.MenuCvtColor.Click += new System.EventHandler(this.MenuCvtColor_Click);
            // 
            // MenuThreshold
            // 
            this.MenuThreshold.Name = "MenuThreshold";
            this.MenuThreshold.Size = new System.Drawing.Size(273, 34);
            this.MenuThreshold.Text = "阈值分割(&T)…";
            this.MenuThreshold.Click += new System.EventHandler(this.MenuThreshold_Click);
            // 
            // MenuBlur
            // 
            this.MenuBlur.Name = "MenuBlur";
            this.MenuBlur.Size = new System.Drawing.Size(273, 34);
            this.MenuBlur.Text = "平滑/模糊(&F)…";
            this.MenuBlur.Click += new System.EventHandler(this.MenuBlur_Click);
            // 
            // MenuCannyEdge
            // 
            this.MenuCannyEdge.Name = "MenuCannyEdge";
            this.MenuCannyEdge.Size = new System.Drawing.Size(273, 34);
            this.MenuCannyEdge.Text = "Canny边缘检测(&E)…";
            this.MenuCannyEdge.Click += new System.EventHandler(this.MenuCannyEdge_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(270, 6);
            // 
            // MenuMorphology
            // 
            this.MenuMorphology.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuErodeDilate,
            this.MenuOpenCloseMorphology,
            this.MenuOtherMorphology});
            this.MenuMorphology.Name = "MenuMorphology";
            this.MenuMorphology.Size = new System.Drawing.Size(273, 34);
            this.MenuMorphology.Text = "形态学操作(&M)";
            // 
            // MenuErodeDilate
            // 
            this.MenuErodeDilate.Name = "MenuErodeDilate";
            this.MenuErodeDilate.Size = new System.Drawing.Size(251, 34);
            this.MenuErodeDilate.Text = "腐蚀与膨胀…";
            this.MenuErodeDilate.Click += new System.EventHandler(this.MenuErodeDilate_Click);
            // 
            // MenuOpenCloseMorphology
            // 
            this.MenuOpenCloseMorphology.Name = "MenuOpenCloseMorphology";
            this.MenuOpenCloseMorphology.Size = new System.Drawing.Size(251, 34);
            this.MenuOpenCloseMorphology.Text = "开运算和闭运算…";
            this.MenuOpenCloseMorphology.Click += new System.EventHandler(this.MenuOpenCloseMorphology_Click);
            // 
            // MenuOtherMorphology
            // 
            this.MenuOtherMorphology.Name = "MenuOtherMorphology";
            this.MenuOtherMorphology.Size = new System.Drawing.Size(251, 34);
            this.MenuOtherMorphology.Text = "其他形态学操作…";
            this.MenuOtherMorphology.Click += new System.EventHandler(this.MenuOtherMorphology_Click);
            // 
            // MenuContoursFeatures
            // 
            this.MenuContoursFeatures.Name = "MenuContoursFeatures";
            this.MenuContoursFeatures.Size = new System.Drawing.Size(273, 34);
            this.MenuContoursFeatures.Text = "轮廓特征(&F)…";
            this.MenuContoursFeatures.Click += new System.EventHandler(this.MenuContoursFeatures_Click);
            // 
            // MenuHoughTransform
            // 
            this.MenuHoughTransform.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHoughLine,
            this.MenuHoughLineP,
            this.MenuHoughCircle});
            this.MenuHoughTransform.Name = "MenuHoughTransform";
            this.MenuHoughTransform.Size = new System.Drawing.Size(273, 34);
            this.MenuHoughTransform.Text = "霍夫变换(&H)";
            // 
            // MenuHoughLine
            // 
            this.MenuHoughLine.Name = "MenuHoughLine";
            this.MenuHoughLine.Size = new System.Drawing.Size(305, 34);
            this.MenuHoughLine.Text = "霍夫直线变换…";
            this.MenuHoughLine.Click += new System.EventHandler(this.MenuHoughLine_Click);
            // 
            // MenuHoughLineP
            // 
            this.MenuHoughLineP.Name = "MenuHoughLineP";
            this.MenuHoughLineP.Size = new System.Drawing.Size(305, 34);
            this.MenuHoughLineP.Text = "统计概率霍夫直线变换…";
            this.MenuHoughLineP.Click += new System.EventHandler(this.MenuHoughLineP_Click);
            // 
            // MenuHoughCircle
            // 
            this.MenuHoughCircle.Name = "MenuHoughCircle";
            this.MenuHoughCircle.Size = new System.Drawing.Size(305, 34);
            this.MenuHoughCircle.Text = "霍夫圆变换…";
            this.MenuHoughCircle.Click += new System.EventHandler(this.MenuHoughCircle_Click);
            // 
            // 直方图均衡化ToolStripMenuItem
            // 
            this.直方图均衡化ToolStripMenuItem.Name = "直方图均衡化ToolStripMenuItem";
            this.直方图均衡化ToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.直方图均衡化ToolStripMenuItem.Text = "直方图均衡化";
            this.直方图均衡化ToolStripMenuItem.Click += new System.EventHandler(this.直方图均衡化ToolStripMenuItem_Click);
            // 
            // 直方图规定化ToolStripMenuItem
            // 
            this.直方图规定化ToolStripMenuItem.Name = "直方图规定化ToolStripMenuItem";
            this.直方图规定化ToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.直方图规定化ToolStripMenuItem.Text = "直方图规定化";
            this.直方图规定化ToolStripMenuItem.Click += new System.EventHandler(this.直方图规定化ToolStripMenuItem_Click);
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuShowProperties,
            this.MenuShowPicHistory,
            this.MenuShowFolderList,
            this.MenuHistogram});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(86, 28);
            this.视图ToolStripMenuItem.Text = "视图(&V)";
            // 
            // MenuShowProperties
            // 
            this.MenuShowProperties.Name = "MenuShowProperties";
            this.MenuShowProperties.Size = new System.Drawing.Size(270, 34);
            this.MenuShowProperties.Text = "显示属性窗口(&P)";
            this.MenuShowProperties.Click += new System.EventHandler(this.MenuShowProperties_Click);
            // 
            // MenuShowPicHistory
            // 
            this.MenuShowPicHistory.Name = "MenuShowPicHistory";
            this.MenuShowPicHistory.Size = new System.Drawing.Size(270, 34);
            this.MenuShowPicHistory.Text = "隐藏历史记录(&H)";
            this.MenuShowPicHistory.Click += new System.EventHandler(this.MenuShowPicHistory_Click);
            // 
            // MenuShowFolderList
            // 
            this.MenuShowFolderList.Name = "MenuShowFolderList";
            this.MenuShowFolderList.Size = new System.Drawing.Size(270, 34);
            this.MenuShowFolderList.Text = "隐藏文件夹列表(&F)";
            this.MenuShowFolderList.Click += new System.EventHandler(this.MenuShowFolderList_Click);
            // 
            // MenuHistogram
            // 
            this.MenuHistogram.Name = "MenuHistogram";
            this.MenuHistogram.Size = new System.Drawing.Size(270, 34);
            this.MenuHistogram.Text = "显示直方图(&H)";
            this.MenuHistogram.Click += new System.EventHandler(this.MenuHistogram_Click);
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuVerticalLayout,
            this.MenuHorizontalLayout,
            this.MenuCascadeLayout});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(92, 28);
            this.窗口ToolStripMenuItem.Text = "窗口(&W)";
            // 
            // MenuVerticalLayout
            // 
            this.MenuVerticalLayout.Name = "MenuVerticalLayout";
            this.MenuVerticalLayout.Size = new System.Drawing.Size(172, 34);
            this.MenuVerticalLayout.Text = "垂直(&V)";
            this.MenuVerticalLayout.Click += new System.EventHandler(this.MenuVerticalLayout_Click);
            // 
            // MenuHorizontalLayout
            // 
            this.MenuHorizontalLayout.Name = "MenuHorizontalLayout";
            this.MenuHorizontalLayout.Size = new System.Drawing.Size(172, 34);
            this.MenuHorizontalLayout.Text = "水平(&H)";
            this.MenuHorizontalLayout.Click += new System.EventHandler(this.MenuHorizontalLayout_Click);
            // 
            // MenuCascadeLayout
            // 
            this.MenuCascadeLayout.Name = "MenuCascadeLayout";
            this.MenuCascadeLayout.Size = new System.Drawing.Size(172, 34);
            this.MenuCascadeLayout.Text = "层叠(&C)";
            this.MenuCascadeLayout.Click += new System.EventHandler(this.MenuCascadeLayout_Click);
            // 
            // MenuRestoreOriginMain
            // 
            this.MenuRestoreOriginMain.Name = "MenuRestoreOriginMain";
            this.MenuRestoreOriginMain.Size = new System.Drawing.Size(142, 28);
            this.MenuRestoreOriginMain.Text = "恢复原图(&F12)";
            this.MenuRestoreOriginMain.Click += new System.EventHandler(this.MenuRestoreOrigin_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAbout});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(88, 28);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(171, 34);
            this.MenuAbout.Text = "关于(&A)";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // ListPicHistory
            // 
            this.ListPicHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.ListPicHistory.ContextMenuStrip = this.MenuPicHistory;
            this.ListPicHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListPicHistory.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListPicHistory.HideSelection = false;
            this.ListPicHistory.LargeImageList = this.ImgListHistory;
            this.ListPicHistory.Location = new System.Drawing.Point(0, 557);
            this.ListPicHistory.MultiSelect = false;
            this.ListPicHistory.Name = "ListPicHistory";
            this.ListPicHistory.Size = new System.Drawing.Size(1214, 92);
            this.ListPicHistory.TabIndex = 2;
            this.ListPicHistory.UseCompatibleStateImageBehavior = false;
            this.ListPicHistory.Visible = false;
            this.ListPicHistory.SelectedIndexChanged += new System.EventHandler(this.ListPicHistory_SelectedIndexChanged);
            this.ListPicHistory.DoubleClick += new System.EventHandler(this.ListPicHistory_DoubleClick);
            // 
            // MenuPicHistory
            // 
            this.MenuPicHistory.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MenuPicHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuShowAlone,
            this.MenuBeMain,
            this.toolStripMenuItem1,
            this.MenuRemove,
            this.MenuRemoveAll,
            this.toolStripMenuItem2,
            this.MenuSaveHistory});
            this.MenuPicHistory.Name = "MenuPicHistory";
            this.MenuPicHistory.Size = new System.Drawing.Size(189, 166);
            // 
            // MenuShowAlone
            // 
            this.MenuShowAlone.Name = "MenuShowAlone";
            this.MenuShowAlone.Size = new System.Drawing.Size(188, 30);
            this.MenuShowAlone.Text = "独立显示";
            this.MenuShowAlone.Click += new System.EventHandler(this.MenuShowAlone_Click);
            // 
            // MenuBeMain
            // 
            this.MenuBeMain.Name = "MenuBeMain";
            this.MenuBeMain.Size = new System.Drawing.Size(188, 30);
            this.MenuBeMain.Text = "应用到主窗口";
            this.MenuBeMain.Click += new System.EventHandler(this.MenuBeMain_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 6);
            // 
            // MenuRemove
            // 
            this.MenuRemove.Name = "MenuRemove";
            this.MenuRemove.Size = new System.Drawing.Size(188, 30);
            this.MenuRemove.Text = "清除";
            this.MenuRemove.Click += new System.EventHandler(this.MenuRemove_Click);
            // 
            // MenuRemoveAll
            // 
            this.MenuRemoveAll.Name = "MenuRemoveAll";
            this.MenuRemoveAll.Size = new System.Drawing.Size(188, 30);
            this.MenuRemoveAll.Text = "清除所有";
            this.MenuRemoveAll.Click += new System.EventHandler(this.MenuRemoveAll_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 6);
            // 
            // MenuSaveHistory
            // 
            this.MenuSaveHistory.Name = "MenuSaveHistory";
            this.MenuSaveHistory.Size = new System.Drawing.Size(188, 30);
            this.MenuSaveHistory.Text = "保存图片";
            this.MenuSaveHistory.Click += new System.EventHandler(this.MenuSaveHistory_Click);
            // 
            // ImgListHistory
            // 
            this.ImgListHistory.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgListHistory.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgListHistory.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PanelFolderImages
            // 
            this.PanelFolderImages.Controls.Add(this.ListPicFolder);
            this.PanelFolderImages.Controls.Add(this.panel2);
            this.PanelFolderImages.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelFolderImages.Location = new System.Drawing.Point(912, 32);
            this.PanelFolderImages.Name = "PanelFolderImages";
            this.PanelFolderImages.Size = new System.Drawing.Size(302, 525);
            this.PanelFolderImages.TabIndex = 7;
            // 
            // ListPicFolder
            // 
            this.ListPicFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.ListPicFolder.ContextMenuStrip = this.MenuFolderPics;
            this.ListPicFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPicFolder.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListPicFolder.HideSelection = false;
            this.ListPicFolder.Location = new System.Drawing.Point(0, 0);
            this.ListPicFolder.Margin = new System.Windows.Forms.Padding(4);
            this.ListPicFolder.MultiSelect = false;
            this.ListPicFolder.Name = "ListPicFolder";
            this.ListPicFolder.Size = new System.Drawing.Size(302, 438);
            this.ListPicFolder.TabIndex = 2;
            this.ListPicFolder.UseCompatibleStateImageBehavior = false;
            this.ListPicFolder.SelectedIndexChanged += new System.EventHandler(this.ListPicFolder_SelectedIndexChanged);
            this.ListPicFolder.DoubleClick += new System.EventHandler(this.ListPicFolder_DoubleClick);
            // 
            // MenuFolderPics
            // 
            this.MenuFolderPics.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MenuFolderPics.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFolderPicShowAlone,
            this.MenuFolderPicBeMain});
            this.MenuFolderPics.Name = "MenuFolderPics";
            this.MenuFolderPics.Size = new System.Drawing.Size(189, 64);
            // 
            // MenuFolderPicShowAlone
            // 
            this.MenuFolderPicShowAlone.Name = "MenuFolderPicShowAlone";
            this.MenuFolderPicShowAlone.Size = new System.Drawing.Size(188, 30);
            this.MenuFolderPicShowAlone.Text = "独立显示";
            this.MenuFolderPicShowAlone.Click += new System.EventHandler(this.MenuFolderPicShowAlone_Click);
            // 
            // MenuFolderPicBeMain
            // 
            this.MenuFolderPicBeMain.Name = "MenuFolderPicBeMain";
            this.MenuFolderPicBeMain.Size = new System.Drawing.Size(188, 30);
            this.MenuFolderPicBeMain.Text = "应用到主窗口";
            this.MenuFolderPicBeMain.Click += new System.EventHandler(this.MenuFolderPicBeMain_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LinkFolderPath);
            this.panel2.Controls.Add(this.BtnListViewView);
            this.panel2.Controls.Add(this.BtnRefreshFolder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 87);
            this.panel2.TabIndex = 1;
            // 
            // LinkFolderPath
            // 
            this.LinkFolderPath.AutoSize = true;
            this.LinkFolderPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LinkFolderPath.Location = new System.Drawing.Point(12, 60);
            this.LinkFolderPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LinkFolderPath.Name = "LinkFolderPath";
            this.LinkFolderPath.Size = new System.Drawing.Size(96, 24);
            this.LinkFolderPath.TabIndex = 2;
            this.LinkFolderPath.TabStop = true;
            this.LinkFolderPath.Text = "linkFolder";
            this.LinkFolderPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkFolderPath_LinkClicked);
            // 
            // BtnListViewView
            // 
            this.BtnListViewView.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnListViewView.Location = new System.Drawing.Point(125, 9);
            this.BtnListViewView.Name = "BtnListViewView";
            this.BtnListViewView.Size = new System.Drawing.Size(103, 48);
            this.BtnListViewView.TabIndex = 0;
            this.BtnListViewView.Text = "切换视图";
            this.BtnListViewView.UseVisualStyleBackColor = true;
            this.BtnListViewView.Click += new System.EventHandler(this.BtnListViewView_Click);
            // 
            // BtnRefreshFolder
            // 
            this.BtnRefreshFolder.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRefreshFolder.Location = new System.Drawing.Point(16, 9);
            this.BtnRefreshFolder.Name = "BtnRefreshFolder";
            this.BtnRefreshFolder.Size = new System.Drawing.Size(103, 48);
            this.BtnRefreshFolder.TabIndex = 0;
            this.BtnRefreshFolder.Text = "刷新";
            this.BtnRefreshFolder.UseVisualStyleBackColor = true;
            this.BtnRefreshFolder.Click += new System.EventHandler(this.BtnRefreshFolder_Click);
            // 
            // 图像锐化ToolStripMenuItem
            // 
            this.图像锐化ToolStripMenuItem.Name = "图像锐化ToolStripMenuItem";
            this.图像锐化ToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.图像锐化ToolStripMenuItem.Text = "图像锐化";
            this.图像锐化ToolStripMenuItem.Click += new System.EventHandler(this.图像锐化ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1214, 649);
            this.Controls.Add(this.PanelFolderImages);
            this.Controls.Add(this.ListPicHistory);
            this.Controls.Add(this.MainMenu);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MenuPicHistory.ResumeLayout(false);
            this.PanelFolderImages.ResumeLayout(false);
            this.MenuFolderPics.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuReadImage;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenFolder;
        private System.Windows.Forms.ToolStripMenuItem 预处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuThreshold;
        private System.Windows.Forms.ToolStripMenuItem MenuCvtColor;
        private System.Windows.Forms.ListView ListPicHistory;
        private System.Windows.Forms.ImageList ImgListHistory;
        private System.Windows.Forms.ContextMenuStrip MenuPicHistory;
        private System.Windows.Forms.ToolStripMenuItem MenuShowAlone;
        private System.Windows.Forms.ToolStripMenuItem MenuRemove;
        private System.Windows.Forms.ToolStripMenuItem MenuRemoveAll;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuBeMain;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Panel PanelFolderImages;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnRefreshFolder;
        private System.Windows.Forms.ListView ListPicFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveHistory;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenCamera;
        private System.Windows.Forms.ToolStripMenuItem MenuRestoreOriginMain;
        private System.Windows.Forms.ToolStripMenuItem MenuCascadeLayout;
        private System.Windows.Forms.ToolStripMenuItem MenuHorizontalLayout;
        private System.Windows.Forms.ToolStripMenuItem MenuVerticalLayout;
        private System.Windows.Forms.ToolStripMenuItem MenuGeometric;
        private System.Windows.Forms.ToolStripMenuItem MenuGeometricResize;
        private System.Windows.Forms.ToolStripMenuItem MenuGeometricRotate;
        private System.Windows.Forms.ToolStripMenuItem MenuGeometricShift;
        private System.Windows.Forms.ToolStripMenuItem MenuGeometricFlip;
        private System.Windows.Forms.ToolStripMenuItem 仿射变换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 透视变换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuDrawingFunction;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenSamples;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuShowProperties;
        private System.Windows.Forms.ToolStripMenuItem MenuBlur;
        private System.Windows.Forms.ToolStripMenuItem MenuShowPicHistory;
        private System.Windows.Forms.ToolStripMenuItem MenuCannyEdge;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem MenuRestoreOrigin;
        private System.Windows.Forms.ToolStripMenuItem MenuMorphology;
        private System.Windows.Forms.ToolStripMenuItem MenuErodeDilate;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenCloseMorphology;
        private System.Windows.Forms.ToolStripMenuItem MenuOtherMorphology;
        private System.Windows.Forms.ToolStripMenuItem MenuContoursFeatures;
        private System.Windows.Forms.ToolStripMenuItem MenuHoughTransform;
        private System.Windows.Forms.ToolStripMenuItem MenuHoughLine;
        private System.Windows.Forms.ToolStripMenuItem MenuHoughLineP;
        private System.Windows.Forms.ToolStripMenuItem MenuHoughCircle;
        private System.Windows.Forms.ToolStripMenuItem MenuHistogram;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveCurrent;
        private System.Windows.Forms.ContextMenuStrip MenuFolderPics;
        private System.Windows.Forms.ToolStripMenuItem MenuFolderPicShowAlone;
        private System.Windows.Forms.ToolStripMenuItem MenuFolderPicBeMain;
        private System.Windows.Forms.LinkLabel LinkFolderPath;
        private System.Windows.Forms.Button BtnListViewView;
        private System.Windows.Forms.ToolStripMenuItem MenuShowFolderList;
        private System.Windows.Forms.ToolStripMenuItem MenuSplitChannels;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.ToolStripMenuItem 直方图均衡化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 直方图规定化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像锐化ToolStripMenuItem;
    }
}

