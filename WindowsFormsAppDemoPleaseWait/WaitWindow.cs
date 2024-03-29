using System.Windows.Forms;

namespace WindowsFormsAppDemoPleaseWait
{
  public partial class WaitWindow : Form
  {
    public int PositionX { get; set; } = 200;
    public int PositionY { get; set; } = 200;

    public WaitWindow(int positionX = 200, int positionY = 200, string newLabel = "Please wait. This window will close automatically at the end of the process.")
    {
      InitializeComponent();
      PositionX = positionX;
      PositionY = positionY;
      labelWait.Text = newLabel;
    }

    private void WaitWindow_Load(object sender, System.EventArgs e)
    {
      Location = new System.Drawing.Point(PositionX, PositionY);
    }
  }
}
