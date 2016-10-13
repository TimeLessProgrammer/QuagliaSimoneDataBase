namespace QuagliaSimoneDataBase
{
  partial class frmCancelData
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
      this.DgvData = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
      this.SuspendLayout();
      // 
      // DgvData
      // 
      this.DgvData.AllowUserToAddRows = false;
      this.DgvData.AllowUserToDeleteRows = false;
      this.DgvData.AllowUserToResizeColumns = false;
      this.DgvData.AllowUserToResizeRows = false;
      this.DgvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DgvData.Location = new System.Drawing.Point(293, 12);
      this.DgvData.Name = "DgvData";
      this.DgvData.ReadOnly = true;
      this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DgvData.Size = new System.Drawing.Size(392, 426);
      this.DgvData.TabIndex = 0;
      // 
      // frmCancelData
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(697, 450);
      this.Controls.Add(this.DgvData);
      this.Name = "frmCancelData";
      this.Text = "Cancella Dati";
      this.Load += new System.EventHandler(this.frmCancelData_Load);
      ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView DgvData;
  }
}