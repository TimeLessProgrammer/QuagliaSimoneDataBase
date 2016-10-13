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
      this.btnSave = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
      this.SuspendLayout();
      // 
      // DgvData
      // 
      this.DgvData.AllowUserToAddRows = false;
      this.DgvData.AllowUserToDeleteRows = false;
      this.DgvData.AllowUserToResizeColumns = false;
      this.DgvData.AllowUserToResizeRows = false;
      this.DgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DgvData.Location = new System.Drawing.Point(293, 12);
      this.DgvData.Name = "DgvData";
      this.DgvData.ReadOnly = true;
      this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DgvData.Size = new System.Drawing.Size(557, 339);
      this.DgvData.TabIndex = 0;
      this.DgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellClick);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(13, 12);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(123, 73);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "Salva";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(153, 12);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(123, 73);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Annulla";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(13, 91);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(123, 32);
      this.btnDelete.TabIndex = 3;
      this.btnDelete.Text = "Cancella";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // frmCancelData
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(862, 363);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.DgvData);
      this.Name = "frmCancelData";
      this.Text = "Cancella Dati";
      this.Load += new System.EventHandler(this.frmCancelData_Load);
      ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView DgvData;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnDelete;
  }
}