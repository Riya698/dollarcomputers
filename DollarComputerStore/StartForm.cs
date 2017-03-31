using System.Windows.Forms;

namespace DollarComputerStore
{
  public partial class StartForm : Form
  {
    public StartForm()
    {
      InitializeComponent();
      SplashScreen splash = new SplashScreen();
      splash.ShowDialog();
    }
  }
}
