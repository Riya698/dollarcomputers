namespace DollarComputerStore
{
  partial class ProductInfoForm
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
      this.ProductInfoMenu = new System.Windows.Forms.MenuStrip();
      this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.OpenMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.SaveMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.CloseMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.AnotherProductMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.ProductIDLabel = new System.Windows.Forms.Label();
      this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.ConditionLabel = new System.Windows.Forms.Label();
      this.CostLabel = new System.Windows.Forms.Label();
      this.ProductInfoViewGroup = new System.Windows.Forms.GroupBox();
      this.ManufacturerTextLabel = new System.Windows.Forms.Label();
      this.ModelLabel = new System.Windows.Forms.Label();
      this.OSLabel = new System.Windows.Forms.Label();
      this.ManufacturerLabel = new System.Windows.Forms.Label();
      this.PlatformLabel = new System.Windows.Forms.Label();
      this.PlatformTextLabel = new System.Windows.Forms.Label();
      this.ProductIdTextLabel = new System.Windows.Forms.Label();
      this.ConditionTextLabel = new System.Windows.Forms.Label();
      this.CostTextLabel = new System.Windows.Forms.Label();
      this.TechSpecsViewGroup = new System.Windows.Forms.GroupBox();
      this.WebCamLabel = new System.Windows.Forms.Label();
      this.WebCamTextLabel = new System.Windows.Forms.Label();
      this.GPUType = new System.Windows.Forms.Label();
      this.GPUTypeTextLabel = new System.Windows.Forms.Label();
      this.HDDLabel = new System.Windows.Forms.Label();
      this.HDDTextLabel = new System.Windows.Forms.Label();
      this.CPUSpeedLabel = new System.Windows.Forms.Label();
      this.CPUSpeedTextLabel = new System.Windows.Forms.Label();
      this.CPUNumberLabel = new System.Windows.Forms.Label();
      this.CPUNumberTextLabel = new System.Windows.Forms.Label();
      this.LCDSizeLabel = new System.Windows.Forms.Label();
      this.LCDSizeTextLabel = new System.Windows.Forms.Label();
      this.CPUTypeLabel = new System.Windows.Forms.Label();
      this.CPUTypeTextLabel = new System.Windows.Forms.Label();
      this.CPUBrandLabel = new System.Windows.Forms.Label();
      this.CPUBrandTextLabel = new System.Windows.Forms.Label();
      this.MemoryLabel = new System.Windows.Forms.Label();
      this.MemoryTextLabel = new System.Windows.Forms.Label();
      this.ConfirmationLabel = new System.Windows.Forms.Label();
      this.SelectAnotherProductButton = new System.Windows.Forms.Button();
      this.ExitAppButton = new System.Windows.Forms.Button();
      this.NextButton = new System.Windows.Forms.Button();
      this.OSTextLabel = new System.Windows.Forms.Label();
      this.ModelTextLabel = new System.Windows.Forms.Label();
      this.ProductInfoMenu.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
      this.ProductInfoViewGroup.SuspendLayout();
      this.TechSpecsViewGroup.SuspendLayout();
      this.SuspendLayout();
      // 
      // ProductInfoMenu
      // 
      this.ProductInfoMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu});
      this.ProductInfoMenu.Location = new System.Drawing.Point(0, 0);
      this.ProductInfoMenu.Name = "ProductInfoMenu";
      this.ProductInfoMenu.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
      this.ProductInfoMenu.Size = new System.Drawing.Size(817, 25);
      this.ProductInfoMenu.TabIndex = 0;
      this.ProductInfoMenu.Text = "menuStrip1";
      // 
      // FileMenu
      // 
      this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenu,
            this.SaveMenu,
            this.CloseMenu});
      this.FileMenu.Name = "FileMenu";
      this.FileMenu.Size = new System.Drawing.Size(37, 19);
      this.FileMenu.Text = "&File";
      // 
      // OpenMenu
      // 
      this.OpenMenu.Name = "OpenMenu";
      this.OpenMenu.Size = new System.Drawing.Size(152, 22);
      this.OpenMenu.Text = "&Open";
      this.OpenMenu.Click += new System.EventHandler(this.OpenMenuItem_Click);
      // 
      // SaveMenu
      // 
      this.SaveMenu.Name = "SaveMenu";
      this.SaveMenu.Size = new System.Drawing.Size(152, 22);
      this.SaveMenu.Text = "&Save";
      this.SaveMenu.Click += new System.EventHandler(this.SaveMenuItem_Click);
      // 
      // CloseMenu
      // 
      this.CloseMenu.Name = "CloseMenu";
      this.CloseMenu.Size = new System.Drawing.Size(152, 22);
      this.CloseMenu.Text = "&Exit";
      this.CloseMenu.Click += new System.EventHandler(this.CloseButton_Click);
      // 
      // EditMenu
      // 
      this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnotherProductMenu});
      this.EditMenu.Name = "EditMenu";
      this.EditMenu.Size = new System.Drawing.Size(39, 19);
      this.EditMenu.Text = "&Edit";
      // 
      // AnotherProductMenu
      // 
      this.AnotherProductMenu.Name = "AnotherProductMenu";
      this.AnotherProductMenu.Size = new System.Drawing.Size(196, 22);
      this.AnotherProductMenu.Text = "Se&lect Another Product";
      this.AnotherProductMenu.Click += new System.EventHandler(this.AnotherProductButton_Click);
      // 
      // ProductIDLabel
      // 
      this.ProductIDLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.ProductIDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "productID", true));
      this.ProductIDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ProductIDLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.ProductIDLabel.Location = new System.Drawing.Point(119, 52);
      this.ProductIDLabel.Name = "ProductIDLabel";
      this.ProductIDLabel.Size = new System.Drawing.Size(171, 30);
      this.ProductIDLabel.TabIndex = 2;
      this.ProductIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // productsBindingSource
      // 
      this.productsBindingSource.DataSource = typeof(DollarComputerStore.products);
      // 
      // ConditionLabel
      // 
      this.ConditionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.ConditionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "condition", true));
      this.ConditionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ConditionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.ConditionLabel.Location = new System.Drawing.Point(435, 52);
      this.ConditionLabel.Name = "ConditionLabel";
      this.ConditionLabel.Size = new System.Drawing.Size(117, 30);
      this.ConditionLabel.TabIndex = 4;
      this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // CostLabel
      // 
      this.CostLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.CostLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "cost", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
      this.CostLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CostLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CostLabel.Location = new System.Drawing.Point(675, 52);
      this.CostLabel.Name = "CostLabel";
      this.CostLabel.Size = new System.Drawing.Size(117, 30);
      this.CostLabel.TabIndex = 6;
      this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // ProductInfoViewGroup
      // 
      this.ProductInfoViewGroup.Controls.Add(this.ModelTextLabel);
      this.ProductInfoViewGroup.Controls.Add(this.OSTextLabel);
      this.ProductInfoViewGroup.Controls.Add(this.ManufacturerTextLabel);
      this.ProductInfoViewGroup.Controls.Add(this.ModelLabel);
      this.ProductInfoViewGroup.Controls.Add(this.OSLabel);
      this.ProductInfoViewGroup.Controls.Add(this.ManufacturerLabel);
      this.ProductInfoViewGroup.Controls.Add(this.PlatformLabel);
      this.ProductInfoViewGroup.Controls.Add(this.PlatformTextLabel);
      this.ProductInfoViewGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
      this.ProductInfoViewGroup.Location = new System.Drawing.Point(17, 106);
      this.ProductInfoViewGroup.Name = "ProductInfoViewGroup";
      this.ProductInfoViewGroup.Size = new System.Drawing.Size(293, 266);
      this.ProductInfoViewGroup.TabIndex = 7;
      this.ProductInfoViewGroup.TabStop = false;
      this.ProductInfoViewGroup.Text = "Product Information";
      // 
      // ManufacturerTextLabel
      // 
      this.ManufacturerTextLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ManufacturerTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.ManufacturerTextLabel.Location = new System.Drawing.Point(0, 88);
      this.ManufacturerTextLabel.Name = "ManufacturerTextLabel";
      this.ManufacturerTextLabel.Size = new System.Drawing.Size(96, 17);
      this.ManufacturerTextLabel.TabIndex = 14;
      this.ManufacturerTextLabel.Text = "Manufacturer";
      this.ManufacturerTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // ModelLabel
      // 
      this.ModelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.ModelLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "model", true));
      this.ModelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ModelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.ModelLabel.Location = new System.Drawing.Point(102, 164);
      this.ModelLabel.Name = "ModelLabel";
      this.ModelLabel.Size = new System.Drawing.Size(171, 30);
      this.ModelLabel.TabIndex = 13;
      this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // OSLabel
      // 
      this.OSLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.OSLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "OS", true));
      this.OSLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.OSLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.OSLabel.Location = new System.Drawing.Point(102, 121);
      this.OSLabel.Name = "OSLabel";
      this.OSLabel.Size = new System.Drawing.Size(171, 30);
      this.OSLabel.TabIndex = 11;
      this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // ManufacturerLabel
      // 
      this.ManufacturerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.ManufacturerLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "manufacturer", true));
      this.ManufacturerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ManufacturerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.ManufacturerLabel.Location = new System.Drawing.Point(102, 81);
      this.ManufacturerLabel.Name = "ManufacturerLabel";
      this.ManufacturerLabel.Size = new System.Drawing.Size(171, 30);
      this.ManufacturerLabel.TabIndex = 9;
      this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // PlatformLabel
      // 
      this.PlatformLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.PlatformLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "platform", true));
      this.PlatformLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.PlatformLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.PlatformLabel.Location = new System.Drawing.Point(102, 38);
      this.PlatformLabel.Name = "PlatformLabel";
      this.PlatformLabel.Size = new System.Drawing.Size(171, 30);
      this.PlatformLabel.TabIndex = 4;
      this.PlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // PlatformTextLabel
      // 
      this.PlatformTextLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.PlatformTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.PlatformTextLabel.Location = new System.Drawing.Point(10, 45);
      this.PlatformTextLabel.Name = "PlatformTextLabel";
      this.PlatformTextLabel.Size = new System.Drawing.Size(86, 17);
      this.PlatformTextLabel.TabIndex = 3;
      this.PlatformTextLabel.Text = "Platform";
      this.PlatformTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // ProductIdTextLabel
      // 
      this.ProductIdTextLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ProductIdTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.ProductIdTextLabel.Location = new System.Drawing.Point(27, 59);
      this.ProductIdTextLabel.Name = "ProductIdTextLabel";
      this.ProductIdTextLabel.Size = new System.Drawing.Size(86, 17);
      this.ProductIdTextLabel.TabIndex = 8;
      this.ProductIdTextLabel.Text = "Product Id";
      this.ProductIdTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // ConditionTextLabel
      // 
      this.ConditionTextLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ConditionTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.ConditionTextLabel.Location = new System.Drawing.Point(343, 59);
      this.ConditionTextLabel.Name = "ConditionTextLabel";
      this.ConditionTextLabel.Size = new System.Drawing.Size(86, 17);
      this.ConditionTextLabel.TabIndex = 9;
      this.ConditionTextLabel.Text = "Condition";
      this.ConditionTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // CostTextLabel
      // 
      this.CostTextLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CostTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CostTextLabel.Location = new System.Drawing.Point(601, 59);
      this.CostTextLabel.Name = "CostTextLabel";
      this.CostTextLabel.Size = new System.Drawing.Size(66, 17);
      this.CostTextLabel.TabIndex = 10;
      this.CostTextLabel.Text = "Cost";
      this.CostTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // TechSpecsViewGroup
      // 
      this.TechSpecsViewGroup.Controls.Add(this.WebCamLabel);
      this.TechSpecsViewGroup.Controls.Add(this.WebCamTextLabel);
      this.TechSpecsViewGroup.Controls.Add(this.GPUType);
      this.TechSpecsViewGroup.Controls.Add(this.GPUTypeTextLabel);
      this.TechSpecsViewGroup.Controls.Add(this.HDDLabel);
      this.TechSpecsViewGroup.Controls.Add(this.HDDTextLabel);
      this.TechSpecsViewGroup.Controls.Add(this.CPUSpeedLabel);
      this.TechSpecsViewGroup.Controls.Add(this.CPUSpeedTextLabel);
      this.TechSpecsViewGroup.Controls.Add(this.CPUNumberLabel);
      this.TechSpecsViewGroup.Controls.Add(this.CPUNumberTextLabel);
      this.TechSpecsViewGroup.Controls.Add(this.LCDSizeLabel);
      this.TechSpecsViewGroup.Controls.Add(this.LCDSizeTextLabel);
      this.TechSpecsViewGroup.Controls.Add(this.CPUTypeLabel);
      this.TechSpecsViewGroup.Controls.Add(this.CPUTypeTextLabel);
      this.TechSpecsViewGroup.Controls.Add(this.CPUBrandLabel);
      this.TechSpecsViewGroup.Controls.Add(this.CPUBrandTextLabel);
      this.TechSpecsViewGroup.Controls.Add(this.MemoryLabel);
      this.TechSpecsViewGroup.Controls.Add(this.MemoryTextLabel);
      this.TechSpecsViewGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
      this.TechSpecsViewGroup.Location = new System.Drawing.Point(333, 106);
      this.TechSpecsViewGroup.Name = "TechSpecsViewGroup";
      this.TechSpecsViewGroup.Size = new System.Drawing.Size(494, 266);
      this.TechSpecsViewGroup.TabIndex = 11;
      this.TechSpecsViewGroup.TabStop = false;
      this.TechSpecsViewGroup.Text = "Technical Specifications";
      // 
      // WebCamLabel
      // 
      this.WebCamLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.WebCamLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "webcam", true));
      this.WebCamLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.WebCamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.WebCamLabel.Location = new System.Drawing.Point(342, 159);
      this.WebCamLabel.Name = "WebCamLabel";
      this.WebCamLabel.Size = new System.Drawing.Size(117, 30);
      this.WebCamLabel.TabIndex = 22;
      this.WebCamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // WebCamTextLabel
      // 
      this.WebCamTextLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.WebCamTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.WebCamTextLabel.Location = new System.Drawing.Point(250, 166);
      this.WebCamTextLabel.Name = "WebCamTextLabel";
      this.WebCamTextLabel.Size = new System.Drawing.Size(86, 17);
      this.WebCamTextLabel.TabIndex = 21;
      this.WebCamTextLabel.Text = "WebCam";
      this.WebCamTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // GPUType
      // 
      this.GPUType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.GPUType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "GPU_Type", true));
      this.GPUType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.GPUType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.GPUType.Location = new System.Drawing.Point(340, 32);
      this.GPUType.Name = "GPUType";
      this.GPUType.Size = new System.Drawing.Size(117, 30);
      this.GPUType.TabIndex = 20;
      this.GPUType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // GPUTypeTextLabel
      // 
      this.GPUTypeTextLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.GPUTypeTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.GPUTypeTextLabel.Location = new System.Drawing.Point(248, 39);
      this.GPUTypeTextLabel.Name = "GPUTypeTextLabel";
      this.GPUTypeTextLabel.Size = new System.Drawing.Size(86, 17);
      this.GPUTypeTextLabel.TabIndex = 19;
      this.GPUTypeTextLabel.Text = "GPU Type";
      this.GPUTypeTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // HDDLabel
      // 
      this.HDDLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.HDDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "HDD_size", true));
      this.HDDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.HDDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.HDDLabel.Location = new System.Drawing.Point(102, 202);
      this.HDDLabel.Name = "HDDLabel";
      this.HDDLabel.Size = new System.Drawing.Size(117, 30);
      this.HDDLabel.TabIndex = 18;
      this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // HDDTextLabel
      // 
      this.HDDTextLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.HDDTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.HDDTextLabel.Location = new System.Drawing.Point(10, 209);
      this.HDDTextLabel.Name = "HDDTextLabel";
      this.HDDTextLabel.Size = new System.Drawing.Size(86, 17);
      this.HDDTextLabel.TabIndex = 17;
      this.HDDTextLabel.Text = "HDD";
      this.HDDTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // CPUSpeedLabel
      // 
      this.CPUSpeedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.CPUSpeedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "CPU_speed", true));
      this.CPUSpeedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CPUSpeedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CPUSpeedLabel.Location = new System.Drawing.Point(342, 113);
      this.CPUSpeedLabel.Name = "CPUSpeedLabel";
      this.CPUSpeedLabel.Size = new System.Drawing.Size(117, 30);
      this.CPUSpeedLabel.TabIndex = 16;
      this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // CPUSpeedTextLabel
      // 
      this.CPUSpeedTextLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CPUSpeedTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CPUSpeedTextLabel.Location = new System.Drawing.Point(250, 120);
      this.CPUSpeedTextLabel.Name = "CPUSpeedTextLabel";
      this.CPUSpeedTextLabel.Size = new System.Drawing.Size(86, 17);
      this.CPUSpeedTextLabel.TabIndex = 15;
      this.CPUSpeedTextLabel.Text = "CPU Speed";
      this.CPUSpeedTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // CPUNumberLabel
      // 
      this.CPUNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.CPUNumberLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "CPU_number", true));
      this.CPUNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CPUNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CPUNumberLabel.Location = new System.Drawing.Point(342, 72);
      this.CPUNumberLabel.Name = "CPUNumberLabel";
      this.CPUNumberLabel.Size = new System.Drawing.Size(117, 30);
      this.CPUNumberLabel.TabIndex = 14;
      this.CPUNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // CPUNumberTextLabel
      // 
      this.CPUNumberTextLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CPUNumberTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CPUNumberTextLabel.Location = new System.Drawing.Point(244, 79);
      this.CPUNumberTextLabel.Name = "CPUNumberTextLabel";
      this.CPUNumberTextLabel.Size = new System.Drawing.Size(92, 17);
      this.CPUNumberTextLabel.TabIndex = 13;
      this.CPUNumberTextLabel.Text = "CPU Number";
      this.CPUNumberTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // LCDSizeLabel
      // 
      this.LCDSizeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.LCDSizeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "screensize", true));
      this.LCDSizeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LCDSizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.LCDSizeLabel.Location = new System.Drawing.Point(102, 159);
      this.LCDSizeLabel.Name = "LCDSizeLabel";
      this.LCDSizeLabel.Size = new System.Drawing.Size(117, 30);
      this.LCDSizeLabel.TabIndex = 12;
      this.LCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // LCDSizeTextLabel
      // 
      this.LCDSizeTextLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LCDSizeTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.LCDSizeTextLabel.Location = new System.Drawing.Point(10, 166);
      this.LCDSizeTextLabel.Name = "LCDSizeTextLabel";
      this.LCDSizeTextLabel.Size = new System.Drawing.Size(86, 17);
      this.LCDSizeTextLabel.TabIndex = 11;
      this.LCDSizeTextLabel.Text = "LCD Size";
      this.LCDSizeTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // CPUTypeLabel
      // 
      this.CPUTypeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.CPUTypeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "CPU_type", true));
      this.CPUTypeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CPUTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CPUTypeLabel.Location = new System.Drawing.Point(102, 115);
      this.CPUTypeLabel.Name = "CPUTypeLabel";
      this.CPUTypeLabel.Size = new System.Drawing.Size(117, 30);
      this.CPUTypeLabel.TabIndex = 10;
      this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // CPUTypeTextLabel
      // 
      this.CPUTypeTextLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CPUTypeTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CPUTypeTextLabel.Location = new System.Drawing.Point(10, 122);
      this.CPUTypeTextLabel.Name = "CPUTypeTextLabel";
      this.CPUTypeTextLabel.Size = new System.Drawing.Size(86, 17);
      this.CPUTypeTextLabel.TabIndex = 9;
      this.CPUTypeTextLabel.Text = "CPU Type";
      this.CPUTypeTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // CPUBrandLabel
      // 
      this.CPUBrandLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.CPUBrandLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "CPU_brand", true));
      this.CPUBrandLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CPUBrandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CPUBrandLabel.Location = new System.Drawing.Point(102, 74);
      this.CPUBrandLabel.Name = "CPUBrandLabel";
      this.CPUBrandLabel.Size = new System.Drawing.Size(117, 30);
      this.CPUBrandLabel.TabIndex = 8;
      this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // CPUBrandTextLabel
      // 
      this.CPUBrandTextLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CPUBrandTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.CPUBrandTextLabel.Location = new System.Drawing.Point(10, 81);
      this.CPUBrandTextLabel.Name = "CPUBrandTextLabel";
      this.CPUBrandTextLabel.Size = new System.Drawing.Size(86, 17);
      this.CPUBrandTextLabel.TabIndex = 7;
      this.CPUBrandTextLabel.Text = "CPU Brand";
      this.CPUBrandTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // MemoryLabel
      // 
      this.MemoryLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.MemoryLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "RAM_size", true));
      this.MemoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MemoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.MemoryLabel.Location = new System.Drawing.Point(102, 32);
      this.MemoryLabel.Name = "MemoryLabel";
      this.MemoryLabel.Size = new System.Drawing.Size(117, 30);
      this.MemoryLabel.TabIndex = 6;
      this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // MemoryTextLabel
      // 
      this.MemoryTextLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MemoryTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.MemoryTextLabel.Location = new System.Drawing.Point(10, 39);
      this.MemoryTextLabel.Name = "MemoryTextLabel";
      this.MemoryTextLabel.Size = new System.Drawing.Size(86, 17);
      this.MemoryTextLabel.TabIndex = 5;
      this.MemoryTextLabel.Text = "Memory";
      this.MemoryTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // ConfirmationLabel
      // 
      this.ConfirmationLabel.AutoSize = true;
      this.ConfirmationLabel.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ConfirmationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
      this.ConfirmationLabel.Location = new System.Drawing.Point(27, 392);
      this.ConfirmationLabel.Name = "ConfirmationLabel";
      this.ConfirmationLabel.Size = new System.Drawing.Size(235, 22);
      this.ConfirmationLabel.TabIndex = 12;
      this.ConfirmationLabel.Text = "Click Next to Confirm Your Selection";
      // 
      // SelectAnotherProductButton
      // 
      this.SelectAnotherProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.SelectAnotherProductButton.Location = new System.Drawing.Point(435, 385);
      this.SelectAnotherProductButton.Name = "SelectAnotherProductButton";
      this.SelectAnotherProductButton.Size = new System.Drawing.Size(154, 31);
      this.SelectAnotherProductButton.TabIndex = 13;
      this.SelectAnotherProductButton.Text = "Select Another Product";
      this.SelectAnotherProductButton.UseVisualStyleBackColor = true;
      this.SelectAnotherProductButton.Click += new System.EventHandler(this.AnotherProductButton_Click);
      // 
      // ExitAppButton
      // 
      this.ExitAppButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.ExitAppButton.Location = new System.Drawing.Point(625, 385);
      this.ExitAppButton.Name = "ExitAppButton";
      this.ExitAppButton.Size = new System.Drawing.Size(81, 31);
      this.ExitAppButton.TabIndex = 14;
      this.ExitAppButton.Text = "Cancel";
      this.ExitAppButton.UseVisualStyleBackColor = true;
      this.ExitAppButton.Click += new System.EventHandler(this.CloseButton_Click);
      // 
      // NextButton
      // 
      this.NextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.NextButton.Location = new System.Drawing.Point(721, 385);
      this.NextButton.Name = "NextButton";
      this.NextButton.Size = new System.Drawing.Size(81, 31);
      this.NextButton.TabIndex = 15;
      this.NextButton.Text = "Next";
      this.NextButton.UseVisualStyleBackColor = true;
      this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
      // 
      // OSTextLabel
      // 
      this.OSTextLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.OSTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.OSTextLabel.Location = new System.Drawing.Point(0, 128);
      this.OSTextLabel.Name = "OSTextLabel";
      this.OSTextLabel.Size = new System.Drawing.Size(96, 17);
      this.OSTextLabel.TabIndex = 15;
      this.OSTextLabel.Text = "OS";
      this.OSTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // ModelTextLabel
      // 
      this.ModelTextLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ModelTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.ModelTextLabel.Location = new System.Drawing.Point(0, 172);
      this.ModelTextLabel.Name = "ModelTextLabel";
      this.ModelTextLabel.Size = new System.Drawing.Size(96, 17);
      this.ModelTextLabel.TabIndex = 16;
      this.ModelTextLabel.Text = "Model";
      this.ModelTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // ProductInformationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.WhiteSmoke;
      this.ClientSize = new System.Drawing.Size(817, 427);
      this.ControlBox = false;
      this.Controls.Add(this.NextButton);
      this.Controls.Add(this.ExitAppButton);
      this.Controls.Add(this.SelectAnotherProductButton);
      this.Controls.Add(this.ConfirmationLabel);
      this.Controls.Add(this.TechSpecsViewGroup);
      this.Controls.Add(this.CostTextLabel);
      this.Controls.Add(this.ConditionTextLabel);
      this.Controls.Add(this.ProductIdTextLabel);
      this.Controls.Add(this.ProductInfoViewGroup);
      this.Controls.Add(this.CostLabel);
      this.Controls.Add(this.ConditionLabel);
      this.Controls.Add(this.ProductIDLabel);
      this.Controls.Add(this.ProductInfoMenu);
      this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.ProductInfoMenu;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.MaximizeBox = false;
      this.Name = "ProductInformationForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Product Information";
      this.ProductInfoMenu.ResumeLayout(false);
      this.ProductInfoMenu.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
      this.ProductInfoViewGroup.ResumeLayout(false);
      this.TechSpecsViewGroup.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip ProductInfoMenu;
    private System.Windows.Forms.ToolStripMenuItem FileMenu;
    private System.Windows.Forms.ToolStripMenuItem OpenMenu;
    private System.Windows.Forms.ToolStripMenuItem SaveMenu;
    private System.Windows.Forms.ToolStripMenuItem CloseMenu;
    private System.Windows.Forms.ToolStripMenuItem EditMenu;
    private System.Windows.Forms.ToolStripMenuItem AnotherProductMenu;
    private System.Windows.Forms.Label ProductIDLabel;
    private System.Windows.Forms.Label ConditionLabel;
    private System.Windows.Forms.Label CostLabel;
    private System.Windows.Forms.GroupBox ProductInfoViewGroup;
    private System.Windows.Forms.Label ManufacturerLabel;
    private System.Windows.Forms.Label PlatformLabel;
    private System.Windows.Forms.Label PlatformTextLabel;
    private System.Windows.Forms.Label ModelLabel;
    private System.Windows.Forms.Label OSLabel;
    private System.Windows.Forms.Label ManufacturerTextLabel;
    private System.Windows.Forms.Label ProductIdTextLabel;
    private System.Windows.Forms.Label ConditionTextLabel;
    private System.Windows.Forms.Label CostTextLabel;
    private System.Windows.Forms.GroupBox TechSpecsViewGroup;
    private System.Windows.Forms.Label CPUTypeLabel;
    private System.Windows.Forms.Label CPUTypeTextLabel;
    private System.Windows.Forms.Label CPUBrandLabel;
    private System.Windows.Forms.Label CPUBrandTextLabel;
    private System.Windows.Forms.Label MemoryLabel;
    private System.Windows.Forms.Label MemoryTextLabel;
    private System.Windows.Forms.Label WebCamLabel;
    private System.Windows.Forms.Label WebCamTextLabel;
    private System.Windows.Forms.Label GPUType;
    private System.Windows.Forms.Label GPUTypeTextLabel;
    private System.Windows.Forms.Label HDDLabel;
    private System.Windows.Forms.Label HDDTextLabel;
    private System.Windows.Forms.Label CPUSpeedLabel;
    private System.Windows.Forms.Label CPUSpeedTextLabel;
    private System.Windows.Forms.Label CPUNumberLabel;
    private System.Windows.Forms.Label CPUNumberTextLabel;
    private System.Windows.Forms.Label LCDSizeLabel;
    private System.Windows.Forms.Label LCDSizeTextLabel;
    private System.Windows.Forms.Label ConfirmationLabel;
    private System.Windows.Forms.Button SelectAnotherProductButton;
    private System.Windows.Forms.Button ExitAppButton;
    private System.Windows.Forms.Button NextButton;
    private System.Windows.Forms.BindingSource productsBindingSource;
    private System.Windows.Forms.Label ModelTextLabel;
    private System.Windows.Forms.Label OSTextLabel;
  }
}