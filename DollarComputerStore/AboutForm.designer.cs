namespace DollarComputerStore
{
  partial class AboutForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.PhoneLabel = new System.Windows.Forms.Label();
      this.ProgrammerLabel = new System.Windows.Forms.Label();
      this.VersionLabel = new System.Windows.Forms.Label();
      this.WebsiteLabel = new System.Windows.Forms.LinkLabel();
      this.CloseAboutBoxButton = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.BusinessNameLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::DollarComputerStore.Properties.Resources.mousedollar128;
      this.pictureBox1.Location = new System.Drawing.Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(128, 128);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // PhoneLabel
      // 
      this.PhoneLabel.AutoSize = true;
      this.PhoneLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.PhoneLabel.ForeColor = System.Drawing.Color.White;
      this.PhoneLabel.Location = new System.Drawing.Point(336, 121);
      this.PhoneLabel.Name = "PhoneLabel";
      this.PhoneLabel.Size = new System.Drawing.Size(94, 17);
      this.PhoneLabel.TabIndex = 8;
      this.PhoneLabel.Text = "1-416-555-0134";
      this.PhoneLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // ProgrammerLabel
      // 
      this.ProgrammerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ProgrammerLabel.ForeColor = System.Drawing.Color.White;
      this.ProgrammerLabel.Location = new System.Drawing.Point(326, 73);
      this.ProgrammerLabel.Name = "ProgrammerLabel";
      this.ProgrammerLabel.Size = new System.Drawing.Size(109, 17);
      this.ProgrammerLabel.TabIndex = 6;
      this.ProgrammerLabel.Text = "RIA123";
      this.ProgrammerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // VersionLabel
      // 
      this.VersionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.VersionLabel.ForeColor = System.Drawing.Color.White;
      this.VersionLabel.Location = new System.Drawing.Point(371, 49);
      this.VersionLabel.Name = "VersionLabel";
      this.VersionLabel.Size = new System.Drawing.Size(64, 17);
      this.VersionLabel.TabIndex = 5;
      this.VersionLabel.Text = "Version";
      this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // WebsiteLabel
      // 
      this.WebsiteLabel.AutoSize = true;
      this.WebsiteLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.WebsiteLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.WebsiteLabel.Location = new System.Drawing.Point(207, 97);
      this.WebsiteLabel.Name = "WebsiteLabel";
      this.WebsiteLabel.Size = new System.Drawing.Size(230, 17);
      this.WebsiteLabel.TabIndex = 9;
      this.WebsiteLabel.TabStop = true;
      this.WebsiteLabel.Text = "http://www.shop.dollarcomputers.com";
      this.WebsiteLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // CloseAboutBoxButton
      // 
      this.CloseAboutBoxButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CloseAboutBoxButton.Location = new System.Drawing.Point(382, 169);
      this.CloseAboutBoxButton.Name = "CloseAboutBoxButton";
      this.CloseAboutBoxButton.Size = new System.Drawing.Size(75, 28);
      this.CloseAboutBoxButton.TabIndex = 10;
      this.CloseAboutBoxButton.Text = "Close";
      this.CloseAboutBoxButton.UseVisualStyleBackColor = true;
      this.CloseAboutBoxButton.Click += new System.EventHandler(this.CloseButton_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
      this.panel1.Controls.Add(this.BusinessNameLabel);
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Controls.Add(this.PhoneLabel);
      this.panel1.Controls.Add(this.WebsiteLabel);
      this.panel1.Controls.Add(this.VersionLabel);
      this.panel1.Controls.Add(this.ProgrammerLabel);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(465, 163);
      this.panel1.TabIndex = 11;
      // 
      // BusinessNameLabel
      // 
      this.BusinessNameLabel.Font = new System.Drawing.Font("Open Sans Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BusinessNameLabel.ForeColor = System.Drawing.Color.White;
      this.BusinessNameLabel.Location = new System.Drawing.Point(235, 12);
      this.BusinessNameLabel.Name = "BusinessNameLabel";
      this.BusinessNameLabel.Size = new System.Drawing.Size(222, 37);
      this.BusinessNameLabel.TabIndex = 2;
      this.BusinessNameLabel.Text = "Dollar Computers";
      this.BusinessNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // AboutForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(465, 201);
      this.ControlBox = false;
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.CloseAboutBoxButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AboutForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "About";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label PhoneLabel;
    private System.Windows.Forms.Label ProgrammerLabel;
    private System.Windows.Forms.Label VersionLabel;
    private System.Windows.Forms.LinkLabel WebsiteLabel;
    private System.Windows.Forms.Button CloseAboutBoxButton;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label BusinessNameLabel;
  }
}
