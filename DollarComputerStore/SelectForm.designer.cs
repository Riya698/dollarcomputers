namespace DollarComputerStore
{
  partial class SelectForm
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
      this.productsBinding = new System.Windows.Forms.BindingSource(this.components);
      this.YourProductLabel = new System.Windows.Forms.Label();
      this.ProductSelectedLabel = new System.Windows.Forms.Label();
      this.CloseAppButton = new System.Windows.Forms.Button();
      this.NextButton = new System.Windows.Forms.Button();
      this.NewOrderTitleLabel = new System.Windows.Forms.Label();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.ProductsDataGrid = new System.Windows.Forms.DataGridView();
      this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rAMtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rAMsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.displaytypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.screensizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.resolutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cPUClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cPUbrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cPUtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cPUspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cPUnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.oSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.hDDsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.hDDspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gPUTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.opticaldriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.audiotypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.wIFIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.depthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.mousttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.webcamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.productsBinding)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // productsBinding
      // 
      this.productsBinding.DataSource = typeof(DollarComputerStore.products);
      // 
      // YourProductLabel
      // 
      this.YourProductLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.YourProductLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.YourProductLabel.Location = new System.Drawing.Point(5, 2);
      this.YourProductLabel.Name = "YourProductLabel";
      this.YourProductLabel.Size = new System.Drawing.Size(134, 37);
      this.YourProductLabel.TabIndex = 2;
      this.YourProductLabel.Text = "Your Product";
      this.YourProductLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // ProductSelectedLabel
      // 
      this.ProductSelectedLabel.BackColor = System.Drawing.Color.White;
      this.ProductSelectedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ProductSelectedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ProductSelectedLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ProductSelectedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
      this.ProductSelectedLabel.Location = new System.Drawing.Point(145, 2);
      this.ProductSelectedLabel.Name = "ProductSelectedLabel";
      this.ProductSelectedLabel.Size = new System.Drawing.Size(434, 37);
      this.ProductSelectedLabel.TabIndex = 3;
      this.ProductSelectedLabel.Text = "Description";
      this.ProductSelectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // CloseAppButton
      // 
      this.CloseAppButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CloseAppButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CloseAppButton.Location = new System.Drawing.Point(585, 5);
      this.CloseAppButton.Name = "CloseAppButton";
      this.CloseAppButton.Size = new System.Drawing.Size(54, 31);
      this.CloseAppButton.TabIndex = 4;
      this.CloseAppButton.Text = "Cancel";
      this.CloseAppButton.UseVisualStyleBackColor = true;
      this.CloseAppButton.Click += new System.EventHandler(this.CancelButton_Click);
      // 
      // NextButton
      // 
      this.NextButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.NextButton.Enabled = false;
      this.NextButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.NextButton.Location = new System.Drawing.Point(645, 5);
      this.NextButton.Name = "NextButton";
      this.NextButton.Size = new System.Drawing.Size(54, 31);
      this.NextButton.TabIndex = 5;
      this.NextButton.Text = "Next";
      this.NextButton.UseVisualStyleBackColor = true;
      this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
      // 
      // NewOrderTitleLabel
      // 
      this.NewOrderTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.NewOrderTitleLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.NewOrderTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
      this.NewOrderTitleLabel.Location = new System.Drawing.Point(0, 0);
      this.NewOrderTitleLabel.Name = "NewOrderTitleLabel";
      this.NewOrderTitleLabel.Size = new System.Drawing.Size(704, 41);
      this.NewOrderTitleLabel.TabIndex = 6;
      this.NewOrderTitleLabel.Text = "Dollar Computer Hardware List";
      this.NewOrderTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel1.Controls.Add(this.YourProductLabel, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.ProductSelectedLabel, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.NextButton, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.CloseAppButton, 2, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 400);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 41);
      this.tableLayoutPanel1.TabIndex = 7;
      // 
      // ProductsDataGrid
      // 
      this.ProductsDataGrid.AllowUserToAddRows = false;
      this.ProductsDataGrid.AutoGenerateColumns = false;
      this.ProductsDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
      this.ProductsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.ProductsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.ProductsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.ProductsDataGrid.ColumnHeadersHeight = 30;
      this.ProductsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.ProductsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.rAMtypeDataGridViewTextBoxColumn,
            this.rAMsizeDataGridViewTextBoxColumn,
            this.displaytypeDataGridViewTextBoxColumn,
            this.screensizeDataGridViewTextBoxColumn,
            this.resolutionDataGridViewTextBoxColumn,
            this.cPUClassDataGridViewTextBoxColumn,
            this.cPUbrandDataGridViewTextBoxColumn,
            this.cPUtypeDataGridViewTextBoxColumn,
            this.cPUspeedDataGridViewTextBoxColumn,
            this.cPUnumberDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.oSDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn,
            this.hDDsizeDataGridViewTextBoxColumn,
            this.hDDspeedDataGridViewTextBoxColumn,
            this.gPUTypeDataGridViewTextBoxColumn,
            this.opticaldriveDataGridViewTextBoxColumn,
            this.audiotypeDataGridViewTextBoxColumn,
            this.lANDataGridViewTextBoxColumn,
            this.wIFIDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.depthDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.mousttypeDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.webcamDataGridViewTextBoxColumn});
      this.ProductsDataGrid.DataSource = this.productsBinding;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.ProductsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
      this.ProductsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ProductsDataGrid.Location = new System.Drawing.Point(0, 41);
      this.ProductsDataGrid.Name = "ProductsDataGrid";
      this.ProductsDataGrid.ReadOnly = true;
      this.ProductsDataGrid.RowHeadersVisible = false;
      this.ProductsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.ProductsDataGrid.RowTemplate.Height = 28;
      this.ProductsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.ProductsDataGrid.Size = new System.Drawing.Size(704, 359);
      this.ProductsDataGrid.TabIndex = 8;
      this.ProductsDataGrid.SelectionChanged += new System.EventHandler(this.ProductsDataGrid_SelectionChanged);
      // 
      // productIDDataGridViewTextBoxColumn
      // 
      this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
      this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
      this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
      this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // costDataGridViewTextBoxColumn
      // 
      this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
      this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
      this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
      this.costDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // manufacturerDataGridViewTextBoxColumn
      // 
      this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
      this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
      this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
      this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // modelDataGridViewTextBoxColumn
      // 
      this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
      this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
      this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
      this.modelDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // rAMtypeDataGridViewTextBoxColumn
      // 
      this.rAMtypeDataGridViewTextBoxColumn.DataPropertyName = "RAM_type";
      this.rAMtypeDataGridViewTextBoxColumn.HeaderText = "RAM Type";
      this.rAMtypeDataGridViewTextBoxColumn.Name = "rAMtypeDataGridViewTextBoxColumn";
      this.rAMtypeDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // rAMsizeDataGridViewTextBoxColumn
      // 
      this.rAMsizeDataGridViewTextBoxColumn.DataPropertyName = "RAM_size";
      this.rAMsizeDataGridViewTextBoxColumn.HeaderText = "RAM Size";
      this.rAMsizeDataGridViewTextBoxColumn.Name = "rAMsizeDataGridViewTextBoxColumn";
      this.rAMsizeDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // displaytypeDataGridViewTextBoxColumn
      // 
      this.displaytypeDataGridViewTextBoxColumn.DataPropertyName = "displaytype";
      this.displaytypeDataGridViewTextBoxColumn.HeaderText = "Display Type";
      this.displaytypeDataGridViewTextBoxColumn.Name = "displaytypeDataGridViewTextBoxColumn";
      this.displaytypeDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // screensizeDataGridViewTextBoxColumn
      // 
      this.screensizeDataGridViewTextBoxColumn.DataPropertyName = "screensize";
      this.screensizeDataGridViewTextBoxColumn.HeaderText = "Screen Size";
      this.screensizeDataGridViewTextBoxColumn.Name = "screensizeDataGridViewTextBoxColumn";
      this.screensizeDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // resolutionDataGridViewTextBoxColumn
      // 
      this.resolutionDataGridViewTextBoxColumn.DataPropertyName = "resolution";
      this.resolutionDataGridViewTextBoxColumn.HeaderText = "Resolution";
      this.resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
      this.resolutionDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // cPUClassDataGridViewTextBoxColumn
      // 
      this.cPUClassDataGridViewTextBoxColumn.DataPropertyName = "CPU_Class";
      this.cPUClassDataGridViewTextBoxColumn.HeaderText = "CPU Class";
      this.cPUClassDataGridViewTextBoxColumn.Name = "cPUClassDataGridViewTextBoxColumn";
      this.cPUClassDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // cPUbrandDataGridViewTextBoxColumn
      // 
      this.cPUbrandDataGridViewTextBoxColumn.DataPropertyName = "CPU_brand";
      this.cPUbrandDataGridViewTextBoxColumn.HeaderText = "CPU Brand";
      this.cPUbrandDataGridViewTextBoxColumn.Name = "cPUbrandDataGridViewTextBoxColumn";
      this.cPUbrandDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // cPUtypeDataGridViewTextBoxColumn
      // 
      this.cPUtypeDataGridViewTextBoxColumn.DataPropertyName = "CPU_type";
      this.cPUtypeDataGridViewTextBoxColumn.HeaderText = "CPU Type";
      this.cPUtypeDataGridViewTextBoxColumn.Name = "cPUtypeDataGridViewTextBoxColumn";
      this.cPUtypeDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // cPUspeedDataGridViewTextBoxColumn
      // 
      this.cPUspeedDataGridViewTextBoxColumn.DataPropertyName = "CPU_speed";
      this.cPUspeedDataGridViewTextBoxColumn.HeaderText = "CPU Speed";
      this.cPUspeedDataGridViewTextBoxColumn.Name = "cPUspeedDataGridViewTextBoxColumn";
      this.cPUspeedDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // cPUnumberDataGridViewTextBoxColumn
      // 
      this.cPUnumberDataGridViewTextBoxColumn.DataPropertyName = "CPU_number";
      this.cPUnumberDataGridViewTextBoxColumn.HeaderText = "CPU Number";
      this.cPUnumberDataGridViewTextBoxColumn.Name = "cPUnumberDataGridViewTextBoxColumn";
      this.cPUnumberDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // conditionDataGridViewTextBoxColumn
      // 
      this.conditionDataGridViewTextBoxColumn.DataPropertyName = "condition";
      this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
      this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
      this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // oSDataGridViewTextBoxColumn
      // 
      this.oSDataGridViewTextBoxColumn.DataPropertyName = "OS";
      this.oSDataGridViewTextBoxColumn.HeaderText = "OS";
      this.oSDataGridViewTextBoxColumn.Name = "oSDataGridViewTextBoxColumn";
      this.oSDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // platformDataGridViewTextBoxColumn
      // 
      this.platformDataGridViewTextBoxColumn.DataPropertyName = "platform";
      this.platformDataGridViewTextBoxColumn.HeaderText = "Platform";
      this.platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
      this.platformDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // hDDsizeDataGridViewTextBoxColumn
      // 
      this.hDDsizeDataGridViewTextBoxColumn.DataPropertyName = "HDD_size";
      this.hDDsizeDataGridViewTextBoxColumn.HeaderText = "HDD Size";
      this.hDDsizeDataGridViewTextBoxColumn.Name = "hDDsizeDataGridViewTextBoxColumn";
      this.hDDsizeDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // hDDspeedDataGridViewTextBoxColumn
      // 
      this.hDDspeedDataGridViewTextBoxColumn.DataPropertyName = "HDD_speed";
      this.hDDspeedDataGridViewTextBoxColumn.HeaderText = "HDD Speed";
      this.hDDspeedDataGridViewTextBoxColumn.Name = "hDDspeedDataGridViewTextBoxColumn";
      this.hDDspeedDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // gPUTypeDataGridViewTextBoxColumn
      // 
      this.gPUTypeDataGridViewTextBoxColumn.DataPropertyName = "GPU_Type";
      this.gPUTypeDataGridViewTextBoxColumn.HeaderText = "GPU Type";
      this.gPUTypeDataGridViewTextBoxColumn.Name = "gPUTypeDataGridViewTextBoxColumn";
      this.gPUTypeDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // opticaldriveDataGridViewTextBoxColumn
      // 
      this.opticaldriveDataGridViewTextBoxColumn.DataPropertyName = "optical_drive";
      this.opticaldriveDataGridViewTextBoxColumn.HeaderText = "Optical Drive";
      this.opticaldriveDataGridViewTextBoxColumn.Name = "opticaldriveDataGridViewTextBoxColumn";
      this.opticaldriveDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // audiotypeDataGridViewTextBoxColumn
      // 
      this.audiotypeDataGridViewTextBoxColumn.DataPropertyName = "Audio_type";
      this.audiotypeDataGridViewTextBoxColumn.HeaderText = "Audio Type";
      this.audiotypeDataGridViewTextBoxColumn.Name = "audiotypeDataGridViewTextBoxColumn";
      this.audiotypeDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // lANDataGridViewTextBoxColumn
      // 
      this.lANDataGridViewTextBoxColumn.DataPropertyName = "LAN";
      this.lANDataGridViewTextBoxColumn.HeaderText = "LAN";
      this.lANDataGridViewTextBoxColumn.Name = "lANDataGridViewTextBoxColumn";
      this.lANDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // wIFIDataGridViewTextBoxColumn
      // 
      this.wIFIDataGridViewTextBoxColumn.DataPropertyName = "WIFI";
      this.wIFIDataGridViewTextBoxColumn.HeaderText = "WIFI";
      this.wIFIDataGridViewTextBoxColumn.Name = "wIFIDataGridViewTextBoxColumn";
      this.wIFIDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // widthDataGridViewTextBoxColumn
      // 
      this.widthDataGridViewTextBoxColumn.DataPropertyName = "width";
      this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
      this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
      this.widthDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // heightDataGridViewTextBoxColumn
      // 
      this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
      this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
      this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
      this.heightDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // depthDataGridViewTextBoxColumn
      // 
      this.depthDataGridViewTextBoxColumn.DataPropertyName = "depth";
      this.depthDataGridViewTextBoxColumn.HeaderText = "Depth";
      this.depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
      this.depthDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // weightDataGridViewTextBoxColumn
      // 
      this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
      this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
      this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
      this.weightDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // mousttypeDataGridViewTextBoxColumn
      // 
      this.mousttypeDataGridViewTextBoxColumn.DataPropertyName = "moust_type";
      this.mousttypeDataGridViewTextBoxColumn.HeaderText = "Mouse Type";
      this.mousttypeDataGridViewTextBoxColumn.Name = "mousttypeDataGridViewTextBoxColumn";
      this.mousttypeDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // powerDataGridViewTextBoxColumn
      // 
      this.powerDataGridViewTextBoxColumn.DataPropertyName = "power";
      this.powerDataGridViewTextBoxColumn.HeaderText = "Power";
      this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
      this.powerDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // webcamDataGridViewTextBoxColumn
      // 
      this.webcamDataGridViewTextBoxColumn.DataPropertyName = "webcam";
      this.webcamDataGridViewTextBoxColumn.HeaderText = "Webcam";
      this.webcamDataGridViewTextBoxColumn.Name = "webcamDataGridViewTextBoxColumn";
      this.webcamDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // SelectForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(704, 441);
      this.ControlBox = false;
      this.Controls.Add(this.ProductsDataGrid);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.NewOrderTitleLabel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "SelectForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Please Select Your Equipment";
      this.Load += new System.EventHandler(this.SelectForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.productsBinding)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Label YourProductLabel;
    private System.Windows.Forms.Label ProductSelectedLabel;
    private System.Windows.Forms.Button CloseAppButton;
    private System.Windows.Forms.Button NextButton;
    private System.Windows.Forms.BindingSource productsBinding;
    private System.Windows.Forms.Label NewOrderTitleLabel;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.DataGridView ProductsDataGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn rAMtypeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn rAMsizeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn displaytypeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn screensizeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cPUClassDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cPUbrandDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cPUtypeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cPUspeedDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cPUnumberDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn oSDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn hDDsizeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn hDDspeedDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn gPUTypeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn opticaldriveDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn audiotypeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lANDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn wIFIDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn mousttypeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn webcamDataGridViewTextBoxColumn;
  }
}