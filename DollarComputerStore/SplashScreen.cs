using System;
using System.Windows.Forms;

namespace DollarComputerStore
{
  public partial class SplashScreen : Form
  {
    // Private Members
    private Timer _closeTimer;


    /// <summary>
    /// Initializes the form.
    /// </summary>
    public SplashScreen()
    {
      InitializeComponent();
      _closeTimer = new Timer();
      _closeTimer.Interval = 3000;
      _closeTimer.Tick += TickAction;
      _closeTimer.Start();
    }

    /// <summary>
    /// This method is executed when the tick event is fired by the timer control
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void TickAction(object sender, EventArgs e)
    {
      // Stop the timer
      _closeTimer.Stop();
      // Close the splash screen
      Close();
    }
  }
}
