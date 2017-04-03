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
     /// Program: Dollar Computers
    /// Name: Riya Patel
   /// StudentID: 200335493
   /// App Creation Date: April 02, 2017
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
