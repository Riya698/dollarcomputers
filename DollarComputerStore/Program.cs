using System;
using System.Windows.Forms;

namespace DollarComputerStore
{
  static class Program
  {
    public static StartForm StartForm { get; set; }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      StartForm = new StartForm();
      Application.Run(StartForm);
    }
  }
}
