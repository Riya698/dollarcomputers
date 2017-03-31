using System.Windows.Forms;

namespace DollarComputerStore
{
  public partial class OrderForm : Form
  {
    // Fields
    private products _product;

    /// <summary>
    /// Initializes a new instance of the <see cref="OrderForm"/> class.
    /// </summary>
    public OrderForm()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Sets the product.
    /// </summary>
    /// <param name="product">The product.</param>
    public void SetProduct(products product)
    {
      _product = product;
      productsBindingSource.DataSource = product;
    }

    /// <summary>
    /// Calculates the final price of the pc
    /// </summary>
    private void CalculateFinalPrice()
    {
      decimal pCost = (decimal)_product.cost;
      decimal tax = pCost * (13.0m / 100.0m);
      TaxLabel.Text = tax.ToString("C");
      TotalLabel.Text = (pCost + tax).ToString("C");
    }

    /// <summary>
    /// Show the about windows
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void AboutMenuItem_Click(object sender, System.EventArgs e)
    {
      AboutForm about = new AboutForm();
      about.ShowDialog();
    }

    /// <summary>
    /// Shows a printing messag
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void PrintMenuItem_Click(object sender, System.EventArgs e)
    {
      MessageBox.Show("Printing Order...", "Print", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    /// <summary>
    /// Hide the current form and show the product information
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void Back_Click(object sender, System.EventArgs e)
    {
      Program.ProductInformationForm.Show();
      Hide();
    }

    /// <summary>
    /// Handles the Click event of the CloseButton control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void CloseButton_Click(object sender, System.EventArgs e)
    {
      Application.Exit();
    }

    /// <summary>
    /// Finish the program
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void FinishButton_Click(object sender, System.EventArgs e)
    {
      MessageBox.Show("Thanks for your purchase\n\nYour Order will be processed in 7-10 business days.",
        "Order Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
      Application.Exit();
    }

    /// <summary>
    /// This event is fired when the form change its visibility.
    /// We need to calculate the cost again if the form return to previous screens
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void OrderForm_VisibleChanged(object sender, System.EventArgs e)
    {
      CalculateFinalPrice();
    }
  }
}
