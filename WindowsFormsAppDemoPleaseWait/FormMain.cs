using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsAppDemoPleaseWait
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void ButtonStart_Click(object sender, EventArgs e)
    {
      int backupPositionX = Location.X;
      int backupPositionY = Location.Y + Size.Height / 2;
      var waitWindow = new WaitWindow(backupPositionX, backupPositionY);
#if !DEBUG
      waitWindow.Show();
#endif
      Application.DoEvents();
      Thread.Sleep(5000);
      waitWindow.Close();
    }
  }
}
