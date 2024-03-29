namespace WindowsFormsAppDemoPleaseWait
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.buttonStart = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // buttonStart
      // 
      this.buttonStart.Location = new System.Drawing.Point(118, 136);
      this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonStart.Name = "buttonStart";
      this.buttonStart.Size = new System.Drawing.Size(218, 36);
      this.buttonStart.TabIndex = 0;
      this.buttonStart.Text = "Start a long process";
      this.buttonStart.UseVisualStyleBackColor = true;
      this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1200, 703);
      this.Controls.Add(this.buttonStart);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "FormMain";
      this.Text = "WinForm application demo for please wait window";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonStart;
  }
}

