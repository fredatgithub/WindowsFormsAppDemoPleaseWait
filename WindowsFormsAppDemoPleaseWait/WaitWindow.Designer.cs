namespace WindowsFormsAppDemoPleaseWait
{
  partial class WaitWindow
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelWait = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelWait
      // 
      this.labelWait.AutoSize = true;
      this.labelWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelWait.Location = new System.Drawing.Point(55, 52);
      this.labelWait.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelWait.Name = "labelWait";
      this.labelWait.Size = new System.Drawing.Size(980, 31);
      this.labelWait.TabIndex = 0;
      this.labelWait.Text = "Please wait. This window will close automatically at the end of the process";
      // 
      // WaitWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1067, 150);
      this.Controls.Add(this.labelWait);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "WaitWindow";
      this.Text = "WaitWindow";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelWait;
  }
}