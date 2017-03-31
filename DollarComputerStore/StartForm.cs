using System.Windows.Forms;

namespace DollarComputerStore
{
  public partial class StartForm : Form
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public StartForm()
    {
      InitializeComponent();
      SplashScreen splash = new SplashScreen();
      splash.ShowDialog();
    }

    /// <summary>
    /// Hides the current window and show the new order form
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void NewOrderButton_Click(object sender, System.EventArgs e)
    {
      Program.SelectForm = Program.SelectForm ?? new SelectForm();
      Program.SelectForm.Show();
      Hide();
    }

    /// <summary>
    /// Hide the current window and load the product information form
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void ExistingOrderButton_Click(object sender, System.EventArgs e)
    {
      Program.ProductInformationForm = Program.ProductInformationForm ?? new ProductInfoForm();
      Program.ProductInformationForm.Show();
      Program.ProductInformationForm.OpenProductFile();
      Hide();
    }

    /// <summary>
    /// Closes the program
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void ExitAppButton_Click(object sender, System.EventArgs e)
    {
      Close();
    }
  }
}
