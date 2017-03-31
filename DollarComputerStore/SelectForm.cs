using System;
using System.Data.Entity;
//using System.Collections.Generic;
using System.Windows.Forms;

namespace DollarComputerStore
{
  public partial class SelectForm : Form
  {
    // Properties
    public products SelectedProduct { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public SelectForm()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Load event handler for the select form
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void SelectForm_Load(object sender, EventArgs e)
    {
      StoreModel db = new StoreModel();
      // Load the products from database and keep it on memory
      db.products.Load();
      // Set the datasource of the binding attached to the datagrid view
      productsBinding.DataSource = db.products.Local.ToBindingList();
      db.Dispose();
    }

    /// <summary>
    /// Closes the application.
    /// </summary>
    private void CloseApplication()
    {
      Application.Exit();
    }

    /// <summary>
    /// Exits the application
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void CancelButton_Click(object sender, EventArgs e)
    {
      CloseApplication();
    }

    /// <summary>
    /// Hide the current form and load the product information form
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void NextButton_Click(object sender, EventArgs e)
    {
      Hide();
    }

    /// <summary>
    /// Set Current Product property to the selected product and update the selected product info
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void ProductsDataGrid_SelectionChanged(object sender, EventArgs e)
    {
      // Store temporal the product selected on the datagrid
      products tempProduct = ProductsDataGrid.CurrentRow.DataBoundItem as products;
      if (tempProduct == null)
      {
        // disable the next control if no product is selected
        NextButton.Enabled = false;
        ProductSelectedLabel.Text = string.Empty;
        return;
      }
      else
      {
        NextButton.Enabled = true;
        SelectedProduct = tempProduct;
        string productPrice = ((decimal)tempProduct.cost).ToString("C");
        ProductSelectedLabel.Text = $"{tempProduct.manufacturer} {tempProduct.model} - {productPrice}";
      }
    }
  }
}
