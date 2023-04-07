
namespace SimpleEdit
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TransformMenuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.RotateRightMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RotateLeftMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FlipHorizantalyMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FlipVerticallyMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ResizeMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ModesMenuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.GrayscaleMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.NegativeMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SepiaMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BinaryMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FloydSteinbergDitheringMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorShiftModeMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CorrectionMenuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.BrightnessContrastMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorBalanceMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AutocorrectionMenuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.AutotoneMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AutocontrastMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorCorrectionMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltersMenuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.SharpenMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.GaussianBlurMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EdgeDetectionMenuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.LaplacianMenuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.Laplacian3x3ColorMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Laplacian3x3BWMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Laplacian5x5ColorMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Laplacian5x5BWMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PrewittMenuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.PrewittColorMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PrewittBWMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SobelMenuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.SobelColorMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SobelBWMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LinearFiltrationMenuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.ArithmeticMeanFilterMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.GeometricMeanFilterMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.NonlinearFiltrationMenuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.MedianFilterMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BlackNoiseMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.WhiteNoiseMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ChebyshevFilterMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SortingMenuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalSortingMenuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalIncreasingSortingMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalDecreasingSortingMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalSortingMenuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalIncreasingSortingMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalDecreasingSortingMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.OriginalButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BackwardButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(245)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuGroup,
            this.TransformMenuGroup,
            this.ModesMenuGroup,
            this.CorrectionMenuGroup,
            this.FiltersMenuGroup,
            this.SortingMenuGroup});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1044, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // FileMenuGroup
            // 
            this.FileMenuGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuButton,
            this.SaveAsMenuButton});
            this.FileMenuGroup.Name = "FileMenuGroup";
            this.FileMenuGroup.Size = new System.Drawing.Size(54, 29);
            this.FileMenuGroup.Text = "File";
            // 
            // OpenMenuButton
            // 
            this.OpenMenuButton.Name = "OpenMenuButton";
            this.OpenMenuButton.Size = new System.Drawing.Size(188, 34);
            this.OpenMenuButton.Text = "Open";
            this.OpenMenuButton.Click += new System.EventHandler(this.OpenMenuButton_Click);
            // 
            // SaveAsMenuButton
            // 
            this.SaveAsMenuButton.Name = "SaveAsMenuButton";
            this.SaveAsMenuButton.Size = new System.Drawing.Size(188, 34);
            this.SaveAsMenuButton.Text = "Save As...";
            this.SaveAsMenuButton.Click += new System.EventHandler(this.SaveAsMenuButton_Click);
            // 
            // TransformMenuGroup
            // 
            this.TransformMenuGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RotateRightMenuButton,
            this.RotateLeftMenuButton,
            this.FlipHorizantalyMenuButton,
            this.FlipVerticallyMenuButton,
            this.ResizeMenuButton});
            this.TransformMenuGroup.Name = "TransformMenuGroup";
            this.TransformMenuGroup.Size = new System.Drawing.Size(107, 29);
            this.TransformMenuGroup.Text = "Transform";
            // 
            // RotateRightMenuButton
            // 
            this.RotateRightMenuButton.Name = "RotateRightMenuButton";
            this.RotateRightMenuButton.Size = new System.Drawing.Size(270, 34);
            this.RotateRightMenuButton.Text = "Rotate Right";
            this.RotateRightMenuButton.Click += new System.EventHandler(this.RotateRightMenuButton_Click);
            // 
            // RotateLeftMenuButton
            // 
            this.RotateLeftMenuButton.Name = "RotateLeftMenuButton";
            this.RotateLeftMenuButton.Size = new System.Drawing.Size(270, 34);
            this.RotateLeftMenuButton.Text = "Rotate Left";
            this.RotateLeftMenuButton.Click += new System.EventHandler(this.RotateLeftMenuButton_Click);
            // 
            // FlipHorizantalyMenuButton
            // 
            this.FlipHorizantalyMenuButton.Name = "FlipHorizantalyMenuButton";
            this.FlipHorizantalyMenuButton.Size = new System.Drawing.Size(270, 34);
            this.FlipHorizantalyMenuButton.Text = "Flip Horizantally";
            this.FlipHorizantalyMenuButton.Click += new System.EventHandler(this.FlipHorizantalMenuButton_Click);
            // 
            // FlipVerticallyMenuButton
            // 
            this.FlipVerticallyMenuButton.Name = "FlipVerticallyMenuButton";
            this.FlipVerticallyMenuButton.Size = new System.Drawing.Size(270, 34);
            this.FlipVerticallyMenuButton.Text = "Flip Vertically";
            this.FlipVerticallyMenuButton.Click += new System.EventHandler(this.FlipVerticalMenuButton_Click);
            // 
            // ResizeMenuButton
            // 
            this.ResizeMenuButton.Enabled = false;
            this.ResizeMenuButton.Name = "ResizeMenuButton";
            this.ResizeMenuButton.Size = new System.Drawing.Size(270, 34);
            this.ResizeMenuButton.Text = "Resize...";
            this.ResizeMenuButton.Click += new System.EventHandler(this.ResizeMenuButton_Click);
            // 
            // ModesMenuGroup
            // 
            this.ModesMenuGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GrayscaleMenuButton,
            this.NegativeMenuButton,
            this.SepiaMenuButton,
            this.BinaryMenuButton,
            this.ColorShiftModeMenuButton});
            this.ModesMenuGroup.Name = "ModesMenuGroup";
            this.ModesMenuGroup.Size = new System.Drawing.Size(83, 29);
            this.ModesMenuGroup.Text = "Modes";
            // 
            // GrayscaleMenuButton
            // 
            this.GrayscaleMenuButton.Name = "GrayscaleMenuButton";
            this.GrayscaleMenuButton.Size = new System.Drawing.Size(248, 34);
            this.GrayscaleMenuButton.Text = "Grayscale";
            this.GrayscaleMenuButton.Click += new System.EventHandler(this.GrayscaleMenuButton_Click);
            // 
            // NegativeMenuButton
            // 
            this.NegativeMenuButton.Name = "NegativeMenuButton";
            this.NegativeMenuButton.Size = new System.Drawing.Size(248, 34);
            this.NegativeMenuButton.Text = "Negative";
            this.NegativeMenuButton.Click += new System.EventHandler(this.NegativeMenuButton_Click);
            // 
            // SepiaMenuButton
            // 
            this.SepiaMenuButton.Name = "SepiaMenuButton";
            this.SepiaMenuButton.Size = new System.Drawing.Size(248, 34);
            this.SepiaMenuButton.Text = "Sepia";
            this.SepiaMenuButton.Click += new System.EventHandler(this.SepiaMenuButton_Click);
            // 
            // BinaryMenuButton
            // 
            this.BinaryMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.automaticToolStripMenuItem,
            this.FloydSteinbergDitheringMenuButton});
            this.BinaryMenuButton.Name = "BinaryMenuButton";
            this.BinaryMenuButton.Size = new System.Drawing.Size(248, 34);
            this.BinaryMenuButton.Text = "Binary mode";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(318, 34);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.BinaryModeManualMenuButton_Click);
            // 
            // automaticToolStripMenuItem
            // 
            this.automaticToolStripMenuItem.Name = "automaticToolStripMenuItem";
            this.automaticToolStripMenuItem.Size = new System.Drawing.Size(318, 34);
            this.automaticToolStripMenuItem.Text = "Automatic";
            this.automaticToolStripMenuItem.Click += new System.EventHandler(this.BinaryModeAutomaticMenuButton_Click);
            // 
            // FloydSteinbergDitheringMenuButton
            // 
            this.FloydSteinbergDitheringMenuButton.Name = "FloydSteinbergDitheringMenuButton";
            this.FloydSteinbergDitheringMenuButton.Size = new System.Drawing.Size(318, 34);
            this.FloydSteinbergDitheringMenuButton.Text = "Floyd–Steinberg dithering";
            this.FloydSteinbergDitheringMenuButton.Click += new System.EventHandler(this.FloydSteinbergDitheringMenuButton_Click);
            // 
            // ColorShiftModeMenuButton
            // 
            this.ColorShiftModeMenuButton.Name = "ColorShiftModeMenuButton";
            this.ColorShiftModeMenuButton.Size = new System.Drawing.Size(248, 34);
            this.ColorShiftModeMenuButton.Text = "Color shift mode";
            this.ColorShiftModeMenuButton.Click += new System.EventHandler(this.ColorShiftModeMenuButton_Click);
            // 
            // CorrectionMenuGroup
            // 
            this.CorrectionMenuGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BrightnessContrastMenuButton,
            this.ColorBalanceMenuButton,
            this.AutocorrectionMenuGroup});
            this.CorrectionMenuGroup.Name = "CorrectionMenuGroup";
            this.CorrectionMenuGroup.Size = new System.Drawing.Size(110, 29);
            this.CorrectionMenuGroup.Text = "Correction";
            // 
            // BrightnessContrastMenuButton
            // 
            this.BrightnessContrastMenuButton.Name = "BrightnessContrastMenuButton";
            this.BrightnessContrastMenuButton.Size = new System.Drawing.Size(270, 34);
            this.BrightnessContrastMenuButton.Text = "Brightness/Contrast";
            this.BrightnessContrastMenuButton.Click += new System.EventHandler(this.BrightnessContrastMenuButton_Click);
            // 
            // ColorBalanceMenuButton
            // 
            this.ColorBalanceMenuButton.Name = "ColorBalanceMenuButton";
            this.ColorBalanceMenuButton.Size = new System.Drawing.Size(270, 34);
            this.ColorBalanceMenuButton.Text = "Color balance";
            this.ColorBalanceMenuButton.Click += new System.EventHandler(this.ColorBalanceMenuButton_Click);
            // 
            // AutocorrectionMenuGroup
            // 
            this.AutocorrectionMenuGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutotoneMenuButton,
            this.AutocontrastMenuButton,
            this.ColorCorrectionMenuButton});
            this.AutocorrectionMenuGroup.Name = "AutocorrectionMenuGroup";
            this.AutocorrectionMenuGroup.Size = new System.Drawing.Size(270, 34);
            this.AutocorrectionMenuGroup.Text = "Autocorrection";
            // 
            // AutotoneMenuButton
            // 
            this.AutotoneMenuButton.Name = "AutotoneMenuButton";
            this.AutotoneMenuButton.Size = new System.Drawing.Size(241, 34);
            this.AutotoneMenuButton.Text = "Autotone";
            this.AutotoneMenuButton.Click += new System.EventHandler(this.AutotoneMenuButton_Click);
            // 
            // AutocontrastMenuButton
            // 
            this.AutocontrastMenuButton.Name = "AutocontrastMenuButton";
            this.AutocontrastMenuButton.Size = new System.Drawing.Size(241, 34);
            this.AutocontrastMenuButton.Text = "Autocontrast";
            this.AutocontrastMenuButton.Click += new System.EventHandler(this.AutocontrastMenuButton_Click);
            // 
            // ColorCorrectionMenuButton
            // 
            this.ColorCorrectionMenuButton.Name = "ColorCorrectionMenuButton";
            this.ColorCorrectionMenuButton.Size = new System.Drawing.Size(241, 34);
            this.ColorCorrectionMenuButton.Text = "Color correction";
            this.ColorCorrectionMenuButton.Click += new System.EventHandler(this.ColorCorrectionMenuButton_Click);
            // 
            // FiltersMenuGroup
            // 
            this.FiltersMenuGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SharpenMenuButton,
            this.GaussianBlurMenuButton,
            this.EdgeDetectionMenuGroup,
            this.LinearFiltrationMenuGroup,
            this.NonlinearFiltrationMenuGroup});
            this.FiltersMenuGroup.Name = "FiltersMenuGroup";
            this.FiltersMenuGroup.Size = new System.Drawing.Size(74, 29);
            this.FiltersMenuGroup.Text = "Filters";
            // 
            // SharpenMenuButton
            // 
            this.SharpenMenuButton.Name = "SharpenMenuButton";
            this.SharpenMenuButton.Size = new System.Drawing.Size(261, 34);
            this.SharpenMenuButton.Text = "Sharpen";
            this.SharpenMenuButton.Click += new System.EventHandler(this.SharpenMenuButton_Click);
            // 
            // GaussianBlurMenuButton
            // 
            this.GaussianBlurMenuButton.Name = "GaussianBlurMenuButton";
            this.GaussianBlurMenuButton.Size = new System.Drawing.Size(261, 34);
            this.GaussianBlurMenuButton.Text = "Gaussian blur";
            this.GaussianBlurMenuButton.Click += new System.EventHandler(this.GaussianBlurMenuButton_Click);
            // 
            // EdgeDetectionMenuGroup
            // 
            this.EdgeDetectionMenuGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LaplacianMenuGroup,
            this.PrewittMenuGroup,
            this.SobelMenuGroup});
            this.EdgeDetectionMenuGroup.Name = "EdgeDetectionMenuGroup";
            this.EdgeDetectionMenuGroup.Size = new System.Drawing.Size(261, 34);
            this.EdgeDetectionMenuGroup.Text = "Edge detection";
            // 
            // LaplacianMenuGroup
            // 
            this.LaplacianMenuGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Laplacian3x3ColorMenuButton,
            this.Laplacian3x3BWMenuButton,
            this.Laplacian5x5ColorMenuButton,
            this.Laplacian5x5BWMenuButton});
            this.LaplacianMenuGroup.Name = "LaplacianMenuGroup";
            this.LaplacianMenuGroup.Size = new System.Drawing.Size(186, 34);
            this.LaplacianMenuGroup.Text = "Laplacian";
            // 
            // Laplacian3x3ColorMenuButton
            // 
            this.Laplacian3x3ColorMenuButton.Name = "Laplacian3x3ColorMenuButton";
            this.Laplacian3x3ColorMenuButton.Size = new System.Drawing.Size(218, 34);
            this.Laplacian3x3ColorMenuButton.Text = "3х3, color";
            this.Laplacian3x3ColorMenuButton.Click += new System.EventHandler(this.Laplacian3x3ColorMenuButton_Click);
            // 
            // Laplacian3x3BWMenuButton
            // 
            this.Laplacian3x3BWMenuButton.Name = "Laplacian3x3BWMenuButton";
            this.Laplacian3x3BWMenuButton.Size = new System.Drawing.Size(218, 34);
            this.Laplacian3x3BWMenuButton.Text = "3х3, B and W";
            this.Laplacian3x3BWMenuButton.Click += new System.EventHandler(this.Laplacian3x3BWMenuButton_Click);
            // 
            // Laplacian5x5ColorMenuButton
            // 
            this.Laplacian5x5ColorMenuButton.Name = "Laplacian5x5ColorMenuButton";
            this.Laplacian5x5ColorMenuButton.Size = new System.Drawing.Size(218, 34);
            this.Laplacian5x5ColorMenuButton.Text = "5x5, color";
            this.Laplacian5x5ColorMenuButton.Click += new System.EventHandler(this.Laplacian5x5ColorMenuButton_Click);
            // 
            // Laplacian5x5BWMenuButton
            // 
            this.Laplacian5x5BWMenuButton.Name = "Laplacian5x5BWMenuButton";
            this.Laplacian5x5BWMenuButton.Size = new System.Drawing.Size(218, 34);
            this.Laplacian5x5BWMenuButton.Text = "5х5, B and W";
            this.Laplacian5x5BWMenuButton.Click += new System.EventHandler(this.Laplacian5x5BWMenuButton_Click);
            // 
            // PrewittMenuGroup
            // 
            this.PrewittMenuGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrewittColorMenuButton,
            this.PrewittBWMenuButton});
            this.PrewittMenuGroup.Name = "PrewittMenuGroup";
            this.PrewittMenuGroup.Size = new System.Drawing.Size(186, 34);
            this.PrewittMenuGroup.Text = "Prewitt";
            // 
            // PrewittColorMenuButton
            // 
            this.PrewittColorMenuButton.Name = "PrewittColorMenuButton";
            this.PrewittColorMenuButton.Size = new System.Drawing.Size(181, 34);
            this.PrewittColorMenuButton.Text = "Color";
            this.PrewittColorMenuButton.Click += new System.EventHandler(this.PrewittColorMenuButton_Click);
            // 
            // PrewittBWMenuButton
            // 
            this.PrewittBWMenuButton.Name = "PrewittBWMenuButton";
            this.PrewittBWMenuButton.Size = new System.Drawing.Size(181, 34);
            this.PrewittBWMenuButton.Text = "B and W";
            this.PrewittBWMenuButton.Click += new System.EventHandler(this.PrewittBWMenuButton_Click);
            // 
            // SobelMenuGroup
            // 
            this.SobelMenuGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SobelColorMenuButton,
            this.SobelBWMenuButton});
            this.SobelMenuGroup.Name = "SobelMenuGroup";
            this.SobelMenuGroup.Size = new System.Drawing.Size(186, 34);
            this.SobelMenuGroup.Text = "Sobel";
            // 
            // SobelColorMenuButton
            // 
            this.SobelColorMenuButton.Name = "SobelColorMenuButton";
            this.SobelColorMenuButton.Size = new System.Drawing.Size(181, 34);
            this.SobelColorMenuButton.Text = "Color";
            this.SobelColorMenuButton.Click += new System.EventHandler(this.SobelColorMenuButton_Click);
            // 
            // SobelBWMenuButton
            // 
            this.SobelBWMenuButton.Name = "SobelBWMenuButton";
            this.SobelBWMenuButton.Size = new System.Drawing.Size(181, 34);
            this.SobelBWMenuButton.Text = "B and W";
            this.SobelBWMenuButton.Click += new System.EventHandler(this.SobelBWMenuButton_Click);
            // 
            // LinearFiltrationMenuGroup
            // 
            this.LinearFiltrationMenuGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArithmeticMeanFilterMenuButton,
            this.GeometricMeanFilterMenuButton});
            this.LinearFiltrationMenuGroup.Name = "LinearFiltrationMenuGroup";
            this.LinearFiltrationMenuGroup.Size = new System.Drawing.Size(261, 34);
            this.LinearFiltrationMenuGroup.Text = "Linear filtration";
            // 
            // ArithmeticMeanFilterMenuButton
            // 
            this.ArithmeticMeanFilterMenuButton.Name = "ArithmeticMeanFilterMenuButton";
            this.ArithmeticMeanFilterMenuButton.Size = new System.Drawing.Size(284, 34);
            this.ArithmeticMeanFilterMenuButton.Text = "Arithmetic mean filter";
            this.ArithmeticMeanFilterMenuButton.Click += new System.EventHandler(this.ArithmeticMeanFilterMenuButton_Click);
            // 
            // GeometricMeanFilterMenuButton
            // 
            this.GeometricMeanFilterMenuButton.Name = "GeometricMeanFilterMenuButton";
            this.GeometricMeanFilterMenuButton.Size = new System.Drawing.Size(284, 34);
            this.GeometricMeanFilterMenuButton.Text = "Geometric mean filter";
            this.GeometricMeanFilterMenuButton.Click += new System.EventHandler(this.GeometricMeanFilterMenuButton_Click);
            // 
            // NonlinearFiltrationMenuGroup
            // 
            this.NonlinearFiltrationMenuGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MedianFilterMenuButton,
            this.BlackNoiseMenuButton,
            this.WhiteNoiseMenuButton,
            this.ChebyshevFilterMenuButton});
            this.NonlinearFiltrationMenuGroup.Name = "NonlinearFiltrationMenuGroup";
            this.NonlinearFiltrationMenuGroup.Size = new System.Drawing.Size(261, 34);
            this.NonlinearFiltrationMenuGroup.Text = "Nonlinear filtration";
            // 
            // MedianFilterMenuButton
            // 
            this.MedianFilterMenuButton.Name = "MedianFilterMenuButton";
            this.MedianFilterMenuButton.Size = new System.Drawing.Size(290, 34);
            this.MedianFilterMenuButton.Text = "Median filter";
            this.MedianFilterMenuButton.Click += new System.EventHandler(this.MedianFilterMenuButton_Click);
            // 
            // BlackNoiseMenuButton
            // 
            this.BlackNoiseMenuButton.Name = "BlackNoiseMenuButton";
            this.BlackNoiseMenuButton.Size = new System.Drawing.Size(290, 34);
            this.BlackNoiseMenuButton.Text = "Max filter (black noise)";
            this.BlackNoiseMenuButton.Click += new System.EventHandler(this.BlackNoiseMenuButton_Click);
            // 
            // WhiteNoiseMenuButton
            // 
            this.WhiteNoiseMenuButton.Name = "WhiteNoiseMenuButton";
            this.WhiteNoiseMenuButton.Size = new System.Drawing.Size(290, 34);
            this.WhiteNoiseMenuButton.Text = "Min filter (white noise)";
            this.WhiteNoiseMenuButton.Click += new System.EventHandler(this.WhiteNoiseMenuButton_Click);
            // 
            // ChebyshevFilterMenuButton
            // 
            this.ChebyshevFilterMenuButton.Name = "ChebyshevFilterMenuButton";
            this.ChebyshevFilterMenuButton.Size = new System.Drawing.Size(290, 34);
            this.ChebyshevFilterMenuButton.Text = "Chebyshev filter";
            this.ChebyshevFilterMenuButton.Click += new System.EventHandler(this.ChebyshevFilterMenuButton_Click);
            // 
            // SortingMenuGroup
            // 
            this.SortingMenuGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VerticalSortingMenuGroup,
            this.HorizontalSortingMenuGroup});
            this.SortingMenuGroup.Name = "SortingMenuGroup";
            this.SortingMenuGroup.Size = new System.Drawing.Size(86, 29);
            this.SortingMenuGroup.Text = "Sorting";
            // 
            // VerticalSortingMenuGroup
            // 
            this.VerticalSortingMenuGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VerticalIncreasingSortingMenuButton,
            this.VerticalDecreasingSortingMenuButton});
            this.VerticalSortingMenuGroup.Name = "VerticalSortingMenuGroup";
            this.VerticalSortingMenuGroup.Size = new System.Drawing.Size(196, 34);
            this.VerticalSortingMenuGroup.Text = "Vertical";
            // 
            // VerticalIncreasingSortingMenuButton
            // 
            this.VerticalIncreasingSortingMenuButton.Name = "VerticalIncreasingSortingMenuButton";
            this.VerticalIncreasingSortingMenuButton.Size = new System.Drawing.Size(249, 34);
            this.VerticalIncreasingSortingMenuButton.Text = "Increasing order";
            this.VerticalIncreasingSortingMenuButton.Click += new System.EventHandler(this.VerticalIncreasingSortingMenuButton_Click);
            // 
            // VerticalDecreasingSortingMenuButton
            // 
            this.VerticalDecreasingSortingMenuButton.Name = "VerticalDecreasingSortingMenuButton";
            this.VerticalDecreasingSortingMenuButton.Size = new System.Drawing.Size(249, 34);
            this.VerticalDecreasingSortingMenuButton.Text = "Decreasing order";
            this.VerticalDecreasingSortingMenuButton.Click += new System.EventHandler(this.VerticalDecreasingSortingMenuButton_Click);
            // 
            // HorizontalSortingMenuGroup
            // 
            this.HorizontalSortingMenuGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HorizontalIncreasingSortingMenuButton,
            this.HorizontalDecreasingSortingMenuButton});
            this.HorizontalSortingMenuGroup.Name = "HorizontalSortingMenuGroup";
            this.HorizontalSortingMenuGroup.Size = new System.Drawing.Size(196, 34);
            this.HorizontalSortingMenuGroup.Text = "Horizontal";
            // 
            // HorizontalIncreasingSortingMenuButton
            // 
            this.HorizontalIncreasingSortingMenuButton.Name = "HorizontalIncreasingSortingMenuButton";
            this.HorizontalIncreasingSortingMenuButton.Size = new System.Drawing.Size(249, 34);
            this.HorizontalIncreasingSortingMenuButton.Text = "Increasing order";
            this.HorizontalIncreasingSortingMenuButton.Click += new System.EventHandler(this.HorizontalIncreasingSortingMenuButton_Click);
            // 
            // HorizontalDecreasingSortingMenuButton
            // 
            this.HorizontalDecreasingSortingMenuButton.Name = "HorizontalDecreasingSortingMenuButton";
            this.HorizontalDecreasingSortingMenuButton.Size = new System.Drawing.Size(249, 34);
            this.HorizontalDecreasingSortingMenuButton.Text = "Decreasing order";
            this.HorizontalDecreasingSortingMenuButton.Click += new System.EventHandler(this.HorizontalDecreasingSortingMenuButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(36, 126);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(970, 554);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // OriginalButton
            // 
            this.OriginalButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OriginalButton.Location = new System.Drawing.Point(858, 62);
            this.OriginalButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OriginalButton.Name = "OriginalButton";
            this.OriginalButton.Size = new System.Drawing.Size(148, 52);
            this.OriginalButton.TabIndex = 2;
            this.OriginalButton.Text = "Show original";
            this.OriginalButton.UseVisualStyleBackColor = false;
            this.OriginalButton.Click += new System.EventHandler(this.OriginalButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResetButton.Location = new System.Drawing.Point(36, 62);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(106, 52);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BackwardButton
            // 
            this.BackwardButton.Location = new System.Drawing.Point(149, 62);
            this.BackwardButton.Name = "BackwardButton";
            this.BackwardButton.Size = new System.Drawing.Size(52, 52);
            this.BackwardButton.TabIndex = 4;
            this.BackwardButton.Text = "🠈";
            this.BackwardButton.UseVisualStyleBackColor = true;
            this.BackwardButton.Click += new System.EventHandler(this.BackwardButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Location = new System.Drawing.Point(207, 62);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(52, 52);
            this.ForwardButton.TabIndex = 5;
            this.ForwardButton.Text = "🠊";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1044, 695);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.BackwardButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.OriginalButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Edit";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuGroup;
        private System.Windows.Forms.ToolStripMenuItem ModesMenuGroup;
        private System.Windows.Forms.ToolStripMenuItem CorrectionMenuGroup;
        private System.Windows.Forms.ToolStripMenuItem FiltersMenuGroup;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button OriginalButton;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuButton;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenuButton;
        private System.Windows.Forms.ToolStripMenuItem GrayscaleMenuButton;
        private System.Windows.Forms.ToolStripMenuItem NegativeMenuButton;
        private System.Windows.Forms.ToolStripMenuItem SepiaMenuButton;
        private System.Windows.Forms.ToolStripMenuItem BinaryMenuButton;
        private System.Windows.Forms.ToolStripMenuItem BrightnessContrastMenuButton;
        private System.Windows.Forms.ToolStripMenuItem ColorBalanceMenuButton;
        private System.Windows.Forms.ToolStripMenuItem AutocorrectionMenuGroup;
        private System.Windows.Forms.ToolStripMenuItem AutotoneMenuButton;
        private System.Windows.Forms.ToolStripMenuItem AutocontrastMenuButton;
        private System.Windows.Forms.ToolStripMenuItem ColorCorrectionMenuButton;
        private System.Windows.Forms.ToolStripMenuItem SharpenMenuButton;
        private System.Windows.Forms.ToolStripMenuItem GaussianBlurMenuButton;
        private System.Windows.Forms.ToolStripMenuItem EdgeDetectionMenuGroup;
        private System.Windows.Forms.ToolStripMenuItem LaplacianMenuGroup;
        private System.Windows.Forms.ToolStripMenuItem Laplacian3x3ColorMenuButton;
        private System.Windows.Forms.ToolStripMenuItem Laplacian3x3BWMenuButton;
        private System.Windows.Forms.ToolStripMenuItem Laplacian5x5ColorMenuButton;
        private System.Windows.Forms.ToolStripMenuItem Laplacian5x5BWMenuButton;
        private System.Windows.Forms.ToolStripMenuItem PrewittMenuGroup;
        private System.Windows.Forms.ToolStripMenuItem PrewittColorMenuButton;
        private System.Windows.Forms.ToolStripMenuItem PrewittBWMenuButton;
        private System.Windows.Forms.ToolStripMenuItem SobelMenuGroup;
        private System.Windows.Forms.ToolStripMenuItem SobelColorMenuButton;
        private System.Windows.Forms.ToolStripMenuItem SobelBWMenuButton;
        private System.Windows.Forms.ToolStripMenuItem LinearFiltrationMenuGroup;
        private System.Windows.Forms.ToolStripMenuItem NonlinearFiltrationMenuGroup;
        private System.Windows.Forms.ToolStripMenuItem ArithmeticMeanFilterMenuButton;
        private System.Windows.Forms.ToolStripMenuItem GeometricMeanFilterMenuButton;
        private System.Windows.Forms.ToolStripMenuItem MedianFilterMenuButton;
        private System.Windows.Forms.ToolStripMenuItem ChebyshevFilterMenuButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automaticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortingMenuGroup;
        private System.Windows.Forms.ToolStripMenuItem VerticalSortingMenuGroup;
        private System.Windows.Forms.ToolStripMenuItem HorizontalSortingMenuGroup;
        private System.Windows.Forms.ToolStripMenuItem VerticalIncreasingSortingMenuButton;
        private System.Windows.Forms.ToolStripMenuItem VerticalDecreasingSortingMenuButton;
        private System.Windows.Forms.ToolStripMenuItem HorizontalIncreasingSortingMenuButton;
        private System.Windows.Forms.ToolStripMenuItem HorizontalDecreasingSortingMenuButton;
        private System.Windows.Forms.Button BackwardButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.ToolStripMenuItem ColorShiftModeMenuButton;
        private System.Windows.Forms.ToolStripMenuItem BlackNoiseMenuButton;
        private System.Windows.Forms.ToolStripMenuItem WhiteNoiseMenuButton;
        private System.Windows.Forms.ToolStripMenuItem FloydSteinbergDitheringMenuButton;
        private System.Windows.Forms.ToolStripMenuItem TransformMenuGroup;
        private System.Windows.Forms.ToolStripMenuItem RotateRightMenuButton;
        private System.Windows.Forms.ToolStripMenuItem RotateLeftMenuButton;
        private System.Windows.Forms.ToolStripMenuItem FlipHorizantalyMenuButton;
        private System.Windows.Forms.ToolStripMenuItem FlipVerticallyMenuButton;
        private System.Windows.Forms.ToolStripMenuItem ResizeMenuButton;
    }
}

