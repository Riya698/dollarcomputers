namespace DollarComputerStore
{
  partial class SplashScreen
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
      this.BusinessNameLabel = new System.Windows.Forms.Label();
      this.BusinessQuoteLabel = new System.Windows.Forms.Label();
      this.LogoPictureBox = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // BusinessNameLabel
      // 
      this.BusinessNameLabel.Font = new System.Drawing.Font("Open Sans Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BusinessNameLabel.ForeColor = System.Drawing.Color.White;
      this.BusinessNameLabel.Location = new System.Drawing.Point(12, 143);
      this.BusinessNameLabel.Name = "BusinessNameLabel";
      this.BusinessNameLabel.Size = new System.Drawing.Size(473, 37);
      this.BusinessNameLabel.TabIndex = 1;
      this.BusinessNameLabel.Text = "Dollar Computers";
      this.BusinessNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // BusinessQuoteLabel
      // 
      this.BusinessQuoteLabel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BusinessQuoteLabel.ForeColor = System.Drawing.Color.White;
      this.BusinessQuoteLabel.Location = new System.Drawing.Point(12, 180);
      this.BusinessQuoteLabel.Name = "BusinessQuoteLabel";
      this.BusinessQuoteLabel.Size = new System.Drawing.Size(465, 28);
      this.BusinessQuoteLabel.TabIndex = 2;
      this.BusinessQuoteLabel.Text = "We Sell for Less!";
      this.BusinessQuoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // LogoPictureBox
      // 
      this.LogoPictureBox.Image = global::DollarComputerStore.Properties.Resources.mousedollar128;
      this.LogoPictureBox.Location = new System.Drawing.Point(183, 12);
      this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(0);
      this.LogoPictureBox.Name = "LogoPictureBox";
      this.LogoPictureBox.Size = new System.Drawing.Size(128, 128);
      this.LogoPictureBox.TabIndex = 0;
      this.LogoPictureBox.TabStop = false;
      // 
      // SplashScreen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
      this.ClientSize = new System.Drawing.Size(497, 235);
      this.ControlBox = false;
      this.Controls.Add(this.BusinessQuoteLabel);
      this.Controls.Add(this.BusinessNameLabel);
      this.Controls.Add(this.LogoPictureBox);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "SplashScreen";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SplashScreen";
      ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox LogoPictureBox;
    private System.Windows.Forms.Label BusinessNameLabel;
    private System.Windows.Forms.Label BusinessQuoteLabel;
  }
}