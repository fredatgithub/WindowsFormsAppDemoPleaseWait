using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
      waitWindow.Show();
      Application.DoEvents();
      Thread.Sleep(5000);
      waitWindow.Close();
    }
  }
}
