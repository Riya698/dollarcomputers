namespace DollarComputerStore
{
  partial class OrderForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
      this.OrderFormMenu = new System.Windows.Forms.MenuStrip();
      this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.PrintMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.BackMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.ModelLabel = new System.Windows.Forms.Label();
      this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.PlatformLabel = new System.Windows.Forms.Label();
      this.ModelViewLabel = new System.Windows.Forms.Label();
      this.PlatformViewLabel = new System.Windows.Forms.Label();
      this.ManufacturerLabel = new System.Windows.Forms.Label();
      this.ConditionLabel = new System.Windows.Forms.Label();
      this.ManufacturerViewLabel = new System.Windows.Forms.Label();
      this.ConditionViewLabel = new System.Windows.Forms.Label();
      this.OSLabel = new System.Windows.Forms.Label();
      this.WebCamLabel = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.HDDSizeLabel = new System.Windows.Forms.Label();
      this.CPUSpeedLabel = new System.Windows.Forms.Label();
      this.CPUNumberLabel = new System.Windows.Forms.Label();
      this.CPUTypeLabel = new System.Windows.Forms.Label();
      this.CPUBrandLabel = new System.Windows.Forms.Label();
      this.MemoryLabel = new System.Windows.Forms.Label();
      this.LCDSizeLabel = new System.Windows.Forms.Label();
      this.OSViewLabel = new System.Windows.Forms.Label();
      this.WebCamViewLabel = new System.Windows.Forms.Label();
      this.GPUViewLabel = new System.Windows.Forms.Label();
      this.HDDViewLabel = new System.Windows.Forms.Label();
      this.CPUSpeedViewLabel = new System.Windows.Forms.Label();
      this.CPUNumberViewLabel = new System.Windows.Forms.Label();
      this.CPUTypeViewLabel = new System.Windows.Forms.Label();
      this.CPUBrandViewLabel = new System.Windows.Forms.Label();
      this.MemoryViewLabel = new System.Windows.Forms.Label();
      this.LCDSizeViewLabel = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.TotalLabel = new System.Windows.Forms.Label();
      this.TotalViewLabel = new System.Windows.Forms.Label();
      this.label33 = new System.Windows.Forms.Label();
      this.TaxLabel = new System.Windows.Forms.Label();
      this.SalesTaxViewLabel = new System.Windows.Forms.Label();
      this.PriceLabel = new System.Windows.Forms.Label();
      this.LabelViewPrice = new System.Windows.Forms.Label();
      this.FinishButton = new System.Windows.Forms.Button();
      this.CloseButton = new System.Windows.Forms.Button();
      this.BackButton = new System.Windows.Forms.Button();
      this.ProductPicture = new System.Windows.Forms.PictureBox();
      this.SepMenu = new System.Windows.Forms.ToolStripSeparator();
      this.label1 = new System.Windows.Forms.Label();
      this.OrderFormMenu.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ProductPicture)).BeginInit();
      this.SuspendLayout();
      // 
      // OrderFormMenu
      // 
      this.OrderFormMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.OrderFormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu,
            this.HelpMenu});
      this.OrderFormMenu.Location = new System.Drawing.Point(0, 0);
      this.OrderFormMenu.Name = "OrderFormMenu";
      this.OrderFormMenu.Size = new System.Drawing.Size(843, 25);
      this.OrderFormMenu.TabIndex = 0;
      this.OrderFormMenu.Text = "menuStrip1";
      // 
      // FileMenu
      // 
      this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintMenu,
            this.SepMenu,
            this.ExitMenu});
      this.FileMenu.Name = "FileMenu";
      this.FileMenu.Size = new System.Drawing.Size(39, 21);
      this.FileMenu.Text = "&File";
      // 
      // PrintMenu
      // 
      this.PrintMenu.Name = "PrintMenu";
      this.PrintMenu.Size = new System.Drawing.Size(152, 22);
      this.PrintMenu.Text = "&Print";
      this.PrintMenu.Click += new System.EventHandler(this.PrintMenuItem_Click);
      // 
      // ExitMenu
      // 
      this.ExitMenu.Name = "ExitMenu";
      this.ExitMenu.Size = new System.Drawing.Size(152, 22);
      this.ExitMenu.Text = "E&xit";
      this.ExitMenu.Click += new System.EventHandler(this.CloseButton_Click);
      // 
      // EditMenu
      // 
      this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackMenu});
      this.EditMenu.Name = "EditMenu";
      this.EditMenu.Size = new System.Drawing.Size(42, 21);
      this.EditMenu.Text = "&Edit";
      // 
      // BackMenu
      // 
      this.BackMenu.Name = "BackMenu";
      this.BackMenu.Size = new System.Drawing.Size(152, 22);
      this.BackMenu.Text = "&Back";
      this.BackMenu.Click += new System.EventHandler(this.Back_Click);
      // 
      // HelpMenu
      // 
      this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenu});
      this.HelpMenu.Name = "HelpMenu";
      this.HelpMenu.Size = new System.Drawing.Size(47, 21);
      this.HelpMenu.Text = "&Help";
      // 
      // AboutMenu
      // 
      this.AboutMenu.Name = "AboutMenu";
      this.AboutMenu.Size = new System.Drawing.Size(152, 22);
      this.AboutMenu.Text = "&About";
      this.AboutMenu.Click += new System.EventHandler(this.AboutMenuItem_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.panel1);
      this.groupBox1.Controls.Add(this.OSLabel);
      this.groupBox1.Controls.Add(this.WebCamLabel);
      this.groupBox1.Controls.Add(this.label18);
      this.groupBox1.Controls.Add(this.HDDSizeLabel);
      this.groupBox1.Controls.Add(this.CPUSpeedLabel);
      this.groupBox1.Controls.Add(this.CPUNumberLabel);
      this.groupBox1.Controls.Add(this.CPUTypeLabel);
      this.groupBox1.Controls.Add(this.CPUBrandLabel);
      this.groupBox1.Controls.Add(this.MemoryLabel);
      this.groupBox1.Controls.Add(this.LCDSizeLabel);
      this.groupBox1.Controls.Add(this.OSViewLabel);
      this.groupBox1.Controls.Add(this.WebCamViewLabel);
      this.groupBox1.Controls.Add(this.GPUViewLabel);
      this.groupBox1.Controls.Add(this.HDDViewLabel);
      this.groupBox1.Controls.Add(this.CPUSpeedViewLabel);
      this.groupBox1.Controls.Add(this.CPUNumberViewLabel);
      this.groupBox1.Controls.Add(this.CPUTypeViewLabel);
      this.groupBox1.Controls.Add(this.CPUBrandViewLabel);
      this.groupBox1.Controls.Add(this.MemoryViewLabel);
      this.groupBox1.Controls.Add(this.LCDSizeViewLabel);
      this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
      this.groupBox1.Location = new System.Drawing.Point(12, 49);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(527, 509);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "System Components";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.panel1.Controls.Add(this.ModelLabel);
      this.panel1.Controls.Add(this.PlatformLabel);
      this.panel1.Controls.Add(this.ModelViewLabel);
      this.panel1.Controls.Add(this.PlatformViewLabel);
      this.panel1.Controls.Add(this.ManufacturerLabel);
      this.panel1.Controls.Add(this.ConditionLabel);
      this.panel1.Controls.Add(this.ManufacturerViewLabel);
      this.panel1.Controls.Add(this.ConditionViewLabel);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(3, 21);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(521, 100);
      this.panel1.TabIndex = 28;
      // 
      // ModelLabel
      // 
      this.ModelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
      this.ModelLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "model", true));
      this.ModelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ModelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.ModelLabel.Location = new System.Drawing.Point(399, 55);
      this.ModelLabel.Name = "ModelLabel";
      this.ModelLabel.Size = new System.Drawing.Size(111, 23);
      this.ModelLabel.TabIndex = 35;
      // 
      // productsBindingSource
      // 
      this.productsBindingSource.DataSource = typeof(DollarComputerStore.products);
      // 
      // PlatformLabel
      // 
      this.PlatformLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
      this.PlatformLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "platform", true));
      this.PlatformLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.PlatformLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.PlatformLabel.Location = new System.Drawing.Point(399, 23);
      this.PlatformLabel.Name = "PlatformLabel";
      this.PlatformLabel.Size = new System.Drawing.Size(111, 23);
      this.PlatformLabel.TabIndex = 34;
      // 
      // ModelViewLabel
      // 
      this.ModelViewLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ModelViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.ModelViewLabel.Location = new System.Drawing.Point(264, 55);
      this.ModelViewLabel.Name = "ModelViewLabel";
      this.ModelViewLabel.Size = new System.Drawing.Size(111, 23);
      this.ModelViewLabel.TabIndex = 33;
      this.ModelViewLabel.Text = "Model";
      this.ModelViewLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // PlatformViewLabel
      // 
      this.PlatformViewLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.PlatformViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.PlatformViewLabel.Location = new System.Drawing.Point(264, 23);
      this.PlatformViewLabel.Name = "PlatformViewLabel";
      this.PlatformViewLabel.Size = new System.Drawing.Size(111, 23);
      this.PlatformViewLabel.TabIndex = 32;
      this.PlatformViewLabel.Text = "Platform";
      this.PlatformViewLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // ManufacturerLabel
      // 
      this.ManufacturerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
      this.ManufacturerLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "manufacturer", true));
      this.ManufacturerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ManufacturerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.ManufacturerLabel.Location = new System.Drawing.Point(138, 55);
      this.ManufacturerLabel.Name = "ManufacturerLabel";
      this.ManufacturerLabel.Size = new System.Drawing.Size(111, 23);
      this.ManufacturerLabel.TabIndex = 31;
      // 
      // ConditionLabel
      // 
      this.ConditionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
      this.ConditionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "condition", true));
      this.ConditionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ConditionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.ConditionLabel.Location = new System.Drawing.Point(138, 23);
      this.ConditionLabel.Name = "ConditionLabel";
      this.ConditionLabel.Size = new System.Drawing.Size(111, 23);
      this.ConditionLabel.TabIndex = 30;
      // 
      // ManufacturerViewLabel
      // 
      this.ManufacturerViewLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ManufacturerViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.ManufacturerViewLabel.Location = new System.Drawing.Point(3, 55);
      this.ManufacturerViewLabel.Name = "ManufacturerViewLabel";
      this.ManufacturerViewLabel.Size = new System.Drawing.Size(111, 23);
      this.ManufacturerViewLabel.TabIndex = 29;
      this.ManufacturerViewLabel.Text = "Manufacturer";
      this.ManufacturerViewLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // ConditionViewLabel
      // 
      this.ConditionViewLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ConditionViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.ConditionViewLabel.Location = new System.Drawing.Point(3, 23);
      this.ConditionViewLabel.Name = "ConditionViewLabel";
      this.ConditionViewLabel.Size = new System.Drawing.Size(111, 23);
      this.ConditionViewLabel.TabIndex = 28;
      this.ConditionViewLabel.Text = "Condition";
      this.ConditionViewLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // OSLabel
      // 
      this.OSLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.OSLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "OS", true));
      this.OSLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.OSLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.OSLabel.Location = new System.Drawing.Point(141, 446);
      this.OSLabel.Name = "OSLabel";
      this.OSLabel.Size = new System.Drawing.Size(372, 34);
      this.OSLabel.TabIndex = 19;
      // 
      // WebCamLabel
      // 
      this.WebCamLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.WebCamLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "webcam", true));
      this.WebCamLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.WebCamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.WebCamLabel.Location = new System.Drawing.Point(141, 412);
      this.WebCamLabel.Name = "WebCamLabel";
      this.WebCamLabel.Size = new System.Drawing.Size(372, 34);
      this.WebCamLabel.TabIndex = 18;
      // 
      // label18
      // 
      this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.label18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "GPU_Type", true));
      this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.label18.Location = new System.Drawing.Point(141, 378);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(372, 34);
      this.label18.TabIndex = 17;
      // 
      // HDDSizeLabel
      // 
      this.HDDSizeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.HDDSizeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "HDD_size", true));
      this.HDDSizeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.HDDSizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.HDDSizeLabel.Location = new System.Drawing.Point(141, 344);
      this.HDDSizeLabel.Name = "HDDSizeLabel";
      this.HDDSizeLabel.Size = new System.Drawing.Size(372, 34);
      this.HDDSizeLabel.TabIndex = 16;
      // 
      // CPUSpeedLabel
      // 
      this.CPUSpeedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.CPUSpeedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "CPU_speed", true));
      this.CPUSpeedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CPUSpeedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CPUSpeedLabel.Location = new System.Drawing.Point(141, 310);
      this.CPUSpeedLabel.Name = "CPUSpeedLabel";
      this.CPUSpeedLabel.Size = new System.Drawing.Size(372, 34);
      this.CPUSpeedLabel.TabIndex = 15;
      // 
      // CPUNumberLabel
      // 
      this.CPUNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.CPUNumberLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "CPU_number", true));
      this.CPUNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CPUNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CPUNumberLabel.Location = new System.Drawing.Point(141, 276);
      this.CPUNumberLabel.Name = "CPUNumberLabel";
      this.CPUNumberLabel.Size = new System.Drawing.Size(372, 34);
      this.CPUNumberLabel.TabIndex = 14;
      // 
      // CPUTypeLabel
      // 
      this.CPUTypeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.CPUTypeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "CPU_type", true));
      this.CPUTypeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CPUTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CPUTypeLabel.Location = new System.Drawing.Point(141, 242);
      this.CPUTypeLabel.Name = "CPUTypeLabel";
      this.CPUTypeLabel.Size = new System.Drawing.Size(372, 34);
      this.CPUTypeLabel.TabIndex = 13;
      // 
      // CPUBrandLabel
      // 
      this.CPUBrandLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.CPUBrandLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "CPU_brand", true));
      this.CPUBrandLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CPUBrandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CPUBrandLabel.Location = new System.Drawing.Point(141, 208);
      this.CPUBrandLabel.Name = "CPUBrandLabel";
      this.CPUBrandLabel.Size = new System.Drawing.Size(372, 34);
      this.CPUBrandLabel.TabIndex = 12;
      // 
      // MemoryLabel
      // 
      this.MemoryLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.MemoryLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "RAM_size", true));
      this.MemoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MemoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.MemoryLabel.Location = new System.Drawing.Point(141, 174);
      this.MemoryLabel.Name = "MemoryLabel";
      this.MemoryLabel.Size = new System.Drawing.Size(372, 34);
      this.MemoryLabel.TabIndex = 11;
      // 
      // LCDSizeLabel
      // 
      this.LCDSizeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.LCDSizeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "screensize", true));
      this.LCDSizeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LCDSizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.LCDSizeLabel.Location = new System.Drawing.Point(141, 140);
      this.LCDSizeLabel.Name = "LCDSizeLabel";
      this.LCDSizeLabel.Size = new System.Drawing.Size(372, 34);
      this.LCDSizeLabel.TabIndex = 10;
      // 
      // OSViewLabel
      // 
      this.OSViewLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.OSViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.OSViewLabel.Location = new System.Drawing.Point(23, 446);
      this.OSViewLabel.Name = "OSViewLabel";
      this.OSViewLabel.Size = new System.Drawing.Size(94, 23);
      this.OSViewLabel.TabIndex = 9;
      this.OSViewLabel.Text = "OS";
      // 
      // WebCamViewLabel
      // 
      this.WebCamViewLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.WebCamViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.WebCamViewLabel.Location = new System.Drawing.Point(23, 412);
      this.WebCamViewLabel.Name = "WebCamViewLabel";
      this.WebCamViewLabel.Size = new System.Drawing.Size(94, 23);
      this.WebCamViewLabel.TabIndex = 8;
      this.WebCamViewLabel.Text = "WebCam";
      // 
      // GPUViewLabel
      // 
      this.GPUViewLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.GPUViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.GPUViewLabel.Location = new System.Drawing.Point(23, 378);
      this.GPUViewLabel.Name = "GPUViewLabel";
      this.GPUViewLabel.Size = new System.Drawing.Size(94, 23);
      this.GPUViewLabel.TabIndex = 7;
      this.GPUViewLabel.Text = "GPU Type";
      // 
      // HDDViewLabel
      // 
      this.HDDViewLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.HDDViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.HDDViewLabel.Location = new System.Drawing.Point(23, 344);
      this.HDDViewLabel.Name = "HDDViewLabel";
      this.HDDViewLabel.Size = new System.Drawing.Size(94, 23);
      this.HDDViewLabel.TabIndex = 6;
      this.HDDViewLabel.Text = "HDD";
      // 
      // CPUSpeedViewLabel
      // 
      this.CPUSpeedViewLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CPUSpeedViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CPUSpeedViewLabel.Location = new System.Drawing.Point(23, 310);
      this.CPUSpeedViewLabel.Name = "CPUSpeedViewLabel";
      this.CPUSpeedViewLabel.Size = new System.Drawing.Size(94, 23);
      this.CPUSpeedViewLabel.TabIndex = 5;
      this.CPUSpeedViewLabel.Text = "CPU Speed";
      // 
      // CPUNumberViewLabel
      // 
      this.CPUNumberViewLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CPUNumberViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CPUNumberViewLabel.Location = new System.Drawing.Point(23, 276);
      this.CPUNumberViewLabel.Name = "CPUNumberViewLabel";
      this.CPUNumberViewLabel.Size = new System.Drawing.Size(94, 23);
      this.CPUNumberViewLabel.TabIndex = 4;
      this.CPUNumberViewLabel.Text = "CPU Number";
      // 
      // CPUTypeViewLabel
      // 
      this.CPUTypeViewLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CPUTypeViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CPUTypeViewLabel.Location = new System.Drawing.Point(23, 242);
      this.CPUTypeViewLabel.Name = "CPUTypeViewLabel";
      this.CPUTypeViewLabel.Size = new System.Drawing.Size(94, 23);
      this.CPUTypeViewLabel.TabIndex = 3;
      this.CPUTypeViewLabel.Text = "CPU Type";
      // 
      // CPUBrandViewLabel
      // 
      this.CPUBrandViewLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CPUBrandViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CPUBrandViewLabel.Location = new System.Drawing.Point(23, 208);
      this.CPUBrandViewLabel.Name = "CPUBrandViewLabel";
      this.CPUBrandViewLabel.Size = new System.Drawing.Size(94, 23);
      this.CPUBrandViewLabel.TabIndex = 2;
      this.CPUBrandViewLabel.Text = "CPU Brand";
      // 
      // MemoryViewLabel
      // 
      this.MemoryViewLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MemoryViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.MemoryViewLabel.Location = new System.Drawing.Point(23, 174);
      this.MemoryViewLabel.Name = "MemoryViewLabel";
      this.MemoryViewLabel.Size = new System.Drawing.Size(94, 23);
      this.MemoryViewLabel.TabIndex = 1;
      this.MemoryViewLabel.Text = "Memory";
      // 
      // LCDSizeViewLabel
      // 
      this.LCDSizeViewLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LCDSizeViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.LCDSizeViewLabel.Location = new System.Drawing.Point(23, 140);
      this.LCDSizeViewLabel.Name = "LCDSizeViewLabel";
      this.LCDSizeViewLabel.Size = new System.Drawing.Size(94, 23);
      this.LCDSizeViewLabel.TabIndex = 0;
      this.LCDSizeViewLabel.Text = "LCD Size";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.TotalLabel);
      this.groupBox2.Controls.Add(this.TotalViewLabel);
      this.groupBox2.Controls.Add(this.label33);
      this.groupBox2.Controls.Add(this.TaxLabel);
      this.groupBox2.Controls.Add(this.SalesTaxViewLabel);
      this.groupBox2.Controls.Add(this.PriceLabel);
      this.groupBox2.Controls.Add(this.LabelViewPrice);
      this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
      this.groupBox2.Location = new System.Drawing.Point(545, 300);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(286, 195);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      // 
      // TotalLabel
      // 
      this.TotalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
      this.TotalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TotalLabel.ForeColor = System.Drawing.Color.White;
      this.TotalLabel.Location = new System.Drawing.Point(169, 138);
      this.TotalLabel.Name = "TotalLabel";
      this.TotalLabel.Size = new System.Drawing.Size(111, 23);
      this.TotalLabel.TabIndex = 33;
      this.TotalLabel.Text = "$0.00";
      // 
      // TotalViewLabel
      // 
      this.TotalViewLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TotalViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.TotalViewLabel.Location = new System.Drawing.Point(6, 138);
      this.TotalViewLabel.Name = "TotalViewLabel";
      this.TotalViewLabel.Size = new System.Drawing.Size(111, 23);
      this.TotalViewLabel.TabIndex = 32;
      this.TotalViewLabel.Text = "Total";
      // 
      // label33
      // 
      this.label33.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.label33.Location = new System.Drawing.Point(8, 103);
      this.label33.Name = "label33";
      this.label33.Size = new System.Drawing.Size(268, 2);
      this.label33.TabIndex = 31;
      this.label33.Text = "label33";
      // 
      // TaxLabel
      // 
      this.TaxLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
      this.TaxLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TaxLabel.ForeColor = System.Drawing.Color.White;
      this.TaxLabel.Location = new System.Drawing.Point(169, 63);
      this.TaxLabel.Name = "TaxLabel";
      this.TaxLabel.Size = new System.Drawing.Size(111, 23);
      this.TaxLabel.TabIndex = 30;
      this.TaxLabel.Text = "$0.00";
      // 
      // SalesTaxViewLabel
      // 
      this.SalesTaxViewLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SalesTaxViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.SalesTaxViewLabel.Location = new System.Drawing.Point(6, 63);
      this.SalesTaxViewLabel.Name = "SalesTaxViewLabel";
      this.SalesTaxViewLabel.Size = new System.Drawing.Size(111, 23);
      this.SalesTaxViewLabel.TabIndex = 29;
      this.SalesTaxViewLabel.Text = "Sales Tax (13%)";
      // 
      // PriceLabel
      // 
      this.PriceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
      this.PriceLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "cost", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
      this.PriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.PriceLabel.ForeColor = System.Drawing.Color.White;
      this.PriceLabel.Location = new System.Drawing.Point(169, 29);
      this.PriceLabel.Name = "PriceLabel";
      this.PriceLabel.Size = new System.Drawing.Size(111, 23);
      this.PriceLabel.TabIndex = 28;
      this.PriceLabel.Text = "$0.00";
      // 
      // LabelViewPrice
      // 
      this.LabelViewPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LabelViewPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.LabelViewPrice.Location = new System.Drawing.Point(6, 29);
      this.LabelViewPrice.Name = "LabelViewPrice";
      this.LabelViewPrice.Size = new System.Drawing.Size(111, 23);
      this.LabelViewPrice.TabIndex = 27;
      this.LabelViewPrice.Text = "Price";
      // 
      // FinishButton
      // 
      this.FinishButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FinishButton.Location = new System.Drawing.Point(736, 529);
      this.FinishButton.Name = "FinishButton";
      this.FinishButton.Size = new System.Drawing.Size(89, 29);
      this.FinishButton.TabIndex = 3;
      this.FinishButton.Text = "Finish";
      this.FinishButton.UseVisualStyleBackColor = true;
      this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
      // 
      // CloseButton
      // 
      this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CloseButton.Location = new System.Drawing.Point(642, 529);
      this.CloseButton.Name = "CloseButton";
      this.CloseButton.Size = new System.Drawing.Size(89, 29);
      this.CloseButton.TabIndex = 4;
      this.CloseButton.Text = "Cancel";
      this.CloseButton.UseVisualStyleBackColor = true;
      this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
      // 
      // BackButton
      // 
      this.BackButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BackButton.Location = new System.Drawing.Point(548, 529);
      this.BackButton.Name = "BackButton";
      this.BackButton.Size = new System.Drawing.Size(89, 29);
      this.BackButton.TabIndex = 5;
      this.BackButton.Text = "Back";
      this.BackButton.UseVisualStyleBackColor = true;
      this.BackButton.Click += new System.EventHandler(this.Back_Click);
      // 
      // ProductPicture
      // 
      this.ProductPicture.Image = global::DollarComputerStore.Properties.Resources.compaq_notebook_core_;
      this.ProductPicture.Location = new System.Drawing.Point(594, 55);
      this.ProductPicture.Name = "ProductPicture";
      this.ProductPicture.Size = new System.Drawing.Size(196, 196);
      this.ProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.ProductPicture.TabIndex = 6;
      this.ProductPicture.TabStop = false;
      // 
      // SepMenu
      // 
      this.SepMenu.Name = "SepMenu";
      this.SepMenu.Size = new System.Drawing.Size(149, 6);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Open Sans Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
      this.label1.Location = new System.Drawing.Point(645, 271);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(86, 26);
      this.label1.TabIndex = 7;
      this.label1.Text = "Your Price";
      // 
      // OrderForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.WhiteSmoke;
      this.ClientSize = new System.Drawing.Size(843, 570);
      this.ControlBox = false;
      this.Controls.Add(this.label1);
      this.Controls.Add(this.ProductPicture);
      this.Controls.Add(this.BackButton);
      this.Controls.Add(this.CloseButton);
      this.Controls.Add(this.FinishButton);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.OrderFormMenu);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.OrderFormMenu;
      this.Name = "OrderForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Complete Your Order";
      this.VisibleChanged += new System.EventHandler(this.OrderForm_VisibleChanged);
      this.OrderFormMenu.ResumeLayout(false);
      this.OrderFormMenu.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ProductPicture)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip OrderFormMenu;
    private System.Windows.Forms.ToolStripMenuItem FileMenu;
    private System.Windows.Forms.ToolStripMenuItem EditMenu;
    private System.Windows.Forms.ToolStripMenuItem HelpMenu;
    private System.Windows.Forms.ToolStripMenuItem PrintMenu;
    private System.Windows.Forms.ToolStripMenuItem ExitMenu;
    private System.Windows.Forms.ToolStripMenuItem BackMenu;
    private System.Windows.Forms.ToolStripMenuItem AboutMenu;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label CPUNumberViewLabel;
    private System.Windows.Forms.Label CPUTypeViewLabel;
    private System.Windows.Forms.Label CPUBrandViewLabel;
    private System.Windows.Forms.Label MemoryViewLabel;
    private System.Windows.Forms.Label LCDSizeViewLabel;
    private System.Windows.Forms.Label OSViewLabel;
    private System.Windows.Forms.Label WebCamViewLabel;
    private System.Windows.Forms.Label GPUViewLabel;
    private System.Windows.Forms.Label HDDViewLabel;
    private System.Windows.Forms.Label CPUSpeedViewLabel;
    private System.Windows.Forms.Label OSLabel;
    private System.Windows.Forms.Label WebCamLabel;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label HDDSizeLabel;
    private System.Windows.Forms.Label CPUSpeedLabel;
    private System.Windows.Forms.Label CPUNumberLabel;
    private System.Windows.Forms.Label CPUTypeLabel;
    private System.Windows.Forms.Label CPUBrandLabel;
    private System.Windows.Forms.Label MemoryLabel;
    private System.Windows.Forms.Label LCDSizeLabel;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label TotalLabel;
    private System.Windows.Forms.Label TotalViewLabel;
    private System.Windows.Forms.Label label33;
    private System.Windows.Forms.Label TaxLabel;
    private System.Windows.Forms.Label SalesTaxViewLabel;
    private System.Windows.Forms.Label PriceLabel;
    private System.Windows.Forms.Label LabelViewPrice;
    private System.Windows.Forms.Button FinishButton;
    private System.Windows.Forms.Button CloseButton;
    private System.Windows.Forms.Button BackButton;
    private System.Windows.Forms.PictureBox ProductPicture;
    private System.Windows.Forms.BindingSource productsBindingSource;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label ModelLabel;
    private System.Windows.Forms.Label PlatformLabel;
    private System.Windows.Forms.Label ModelViewLabel;
    private System.Windows.Forms.Label PlatformViewLabel;
    private System.Windows.Forms.Label ManufacturerLabel;
    private System.Windows.Forms.Label ConditionLabel;
    private System.Windows.Forms.Label ManufacturerViewLabel;
    private System.Windows.Forms.Label ConditionViewLabel;
    private System.Windows.Forms.ToolStripSeparator SepMenu;
    private System.Windows.Forms.Label label1;
  }
}