using System;
using System.Windows.Forms;

namespace DollarComputerStore
{
  static class Program
  {
    // Forms as properties
    public static StartForm StartForm { get; set; }
    public static SelectForm SelectForm { get; set; }
    public static ProductInfoForm ProductInformationForm { get; set; }
    public static OrderForm OrderForm { get; set; }

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
