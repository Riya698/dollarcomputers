namespace DollarComputerStore
{
  partial class StartForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
      this.TitleLabel = new System.Windows.Forms.Label();
      this.NewOrderButton = new System.Windows.Forms.Button();
      this.ExitAppButton = new System.Windows.Forms.Button();
      this.ExistingOrderButton = new System.Windows.Forms.Button();
      this.LogoImage = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
      this.SuspendLayout();
      // 
      // TitleLabel
      // 
      this.TitleLabel.AutoSize = true;
      this.TitleLabel.Font = new System.Drawing.Font("Open Sans Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
      this.TitleLabel.Location = new System.Drawing.Point(72, 9);
      this.TitleLabel.Name = "TitleLabel";
      this.TitleLabel.Size = new System.Drawing.Size(238, 28);
      this.TitleLabel.TabIndex = 0;
      this.TitleLabel.Text = "Order Your Computer Today";
      // 
      // NewOrderButton
      // 
      this.NewOrderButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.NewOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.NewOrderButton.Location = new System.Drawing.Point(182, 62);
      this.NewOrderButton.Name = "NewOrderButton";
      this.NewOrderButton.Size = new System.Drawing.Size(192, 38);
      this.NewOrderButton.TabIndex = 2;
      this.NewOrderButton.Text = "Start a New Order";
      this.NewOrderButton.UseVisualStyleBackColor = true;
      // 
      // ExitAppButton
      // 
      this.ExitAppButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ExitAppButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.ExitAppButton.Location = new System.Drawing.Point(182, 152);
      this.ExitAppButton.Name = "ExitAppButton";
      this.ExitAppButton.Size = new System.Drawing.Size(192, 38);
      this.ExitAppButton.TabIndex = 4;
      this.ExitAppButton.Text = "Exit";
      this.ExitAppButton.UseVisualStyleBackColor = true;
      // 
      // ExistingOrderButton
      // 
      this.ExistingOrderButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ExistingOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.ExistingOrderButton.Location = new System.Drawing.Point(182, 106);
      this.ExistingOrderButton.Name = "ExistingOrderButton";
      this.ExistingOrderButton.Size = new System.Drawing.Size(192, 38);
      this.ExistingOrderButton.TabIndex = 5;
      this.ExistingOrderButton.Text = "Open a Saved Order";
      this.ExistingOrderButton.UseVisualStyleBackColor = true;
      // 
      // LogoImage
      // 
      this.LogoImage.Image = global::DollarComputerStore.Properties.Resources.mousedollar128;
      this.LogoImage.Location = new System.Drawing.Point(12, 62);
      this.LogoImage.Name = "LogoImage";
      this.LogoImage.Size = new System.Drawing.Size(128, 128);
      this.LogoImage.TabIndex = 1;
      this.LogoImage.TabStop = false;
      // 
      // StartForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.WhiteSmoke;
      this.ClientSize = new System.Drawing.Size(409, 207);
      this.ControlBox = false;
      this.Controls.Add(this.ExistingOrderButton);
      this.Controls.Add(this.ExitAppButton);
      this.Controls.Add(this.NewOrderButton);
      this.Controls.Add(this.LogoImage);
      this.Controls.Add(this.TitleLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "StartForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Welcome to dollar computer";
      ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label TitleLabel;
    private System.Windows.Forms.PictureBox LogoImage;
    private System.Windows.Forms.Button NewOrderButton;
    private System.Windows.Forms.Button ExitAppButton;
    private System.Windows.Forms.Button ExistingOrderButton;
  }
}

