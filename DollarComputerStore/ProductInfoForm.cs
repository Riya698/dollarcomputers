using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace DollarComputerStore
{
  public partial class ProductInfoForm : Form
  {
    // Fields
    private products _product;

    /// <summary>
    /// Constructor
    /// </summary>
    public ProductInfoForm()
    {
      InitializeComponent();
      _product = new products();
    }

    /// <summary>
    /// Each file's line represent a property. We convert this file to the product object using reflection
    /// </summary>
    /// <param name="productText">The product text.</param>
    /// <returns></returns>
    private products ParseFile(string[] productText)
    {
      products tempProduct = new products();
      PropertyInfo[] props = _product.GetType().GetProperties().OrderBy(p => p.Name).ToArray();
      for (int i = 0; i < props.Length; ++i)
      {
        Type propertyType = props[i].PropertyType;
        object val = ChangeType(productText[i], propertyType);
        props[i].SetValue(tempProduct, val);
      }
      return tempProduct;
    }

    /// <summary>
    /// Sets the product.
    /// </summary>
    /// <param name="product">The product.</param>
    public void SetProduct(products product)
    {
      _product = product;
      productsBindingSource.DataSource = _product;
    }

    /// <summary>
    /// Changes the type. This method is used because there's a limitation converting nullable types
    /// and the database allow null values on several fields
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="conversion">The conversion.</param>
    /// <returns></returns>
    public static object ChangeType(object value, Type conversion)
    {
      var valueType = conversion;
      if (valueType.IsGenericType && valueType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
      {
        if (value == null) return null;
        valueType = Nullable.GetUnderlyingType(valueType);
      }
      return Convert.ChangeType(value, valueType);
    }

    /// <summary>
    /// Saves the product file.
    /// </summary>
    private void SaveProductFile(string fname)
    {
      if (_product == null) return;
      PropertyInfo[] props = _product.GetType().GetProperties().OrderBy(p => p.Name).ToArray();
      StreamWriter sw = new StreamWriter(fname, false);
      foreach (var prop in props) sw.WriteLine($"{prop.GetValue(_product)}");
      sw.Close();
    }

    /// <summary>
    /// Opens the product file.
    /// </summary>
    public void OpenProductFile()
    {
      var openDlg = new OpenFileDialog();
      openDlg = new OpenFileDialog();
      openDlg.Filter = "Text File (*.txt)|*.txt";
      if (openDlg.ShowDialog() != DialogResult.OK) return;
      string[] lines = File.ReadAllLines(openDlg.FileName);
      SetProduct(ParseFile(lines));
    }

    /// <summary>
    /// Handles the Click event of the CloseButton control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void CloseButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    /// <summary>
    /// Handles the Click event of the AnotherProductButton control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void AnotherProductButton_Click(object sender, EventArgs e)
    {
      Program.SelectForm = Program.SelectForm ?? new SelectForm();
      Program.SelectForm.Show();
      Hide();
    }

    /// <summary>
    /// Shows a save dialog box to save the current product to a text file
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void SaveMenuItem_Click(object sender, EventArgs e)
    {
      var saveDlg = new SaveFileDialog();
      saveDlg = new SaveFileDialog();
      saveDlg.Filter = "Text File (*.txt)|*.txt";
      saveDlg.FileName = "Product.txt";
      if (saveDlg.ShowDialog() != DialogResult.OK) return;
      SaveProductFile(saveDlg.FileName);
      MessageBox.Show("Product Saved", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Open a product stored
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void OpenMenuItem_Click(object sender, EventArgs e)
    {
      OpenProductFile();
    }

    /// <summary>
    /// Handles the Click event of the NextButton control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void NextButton_Click(object sender, EventArgs e)
    {
      Program.OrderForm = Program.OrderForm ?? new OrderForm();
      Program.OrderForm.SetProduct(_product);
      Program.OrderForm.Show();
      Hide();
    }
  }
}
