﻿using System;
using System.Reflection;
using System.Windows.Forms;

namespace DollarComputerStore
{
  partial class AboutForm : Form
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public AboutForm()
    {
      InitializeComponent();
      Text = "About Dollar Computer";
      VersionLabel.Text = String.Format("{0}", AssemblyVersion);
    }

    // Code generated by Visual Studio
    #region Assembly Attribute Accessors

    public string AssemblyVersion
    {
      get
      {
        return Assembly.GetExecutingAssembly().GetName().Version.ToString();
      }
    }
    #endregion

    /// <summary>
    /// Close the dialog box
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void CloseButton_Click(object sender, EventArgs e)
    {
        Close();
    }
  }
}