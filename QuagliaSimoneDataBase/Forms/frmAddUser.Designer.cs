namespace QuagliaSimoneDataBase
{
  partial class frmAddUser
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
      this.dgvShowUser = new System.Windows.Forms.DataGridView();
      this.txtUser = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtPwd = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.rdbTrue = new System.Windows.Forms.RadioButton();
      this.rdbFalse = new System.Windows.Forms.RadioButton();
      this.btnCanc = new System.Windows.Forms.Button();
      this.btnSalva = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvShowUser)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvShowUser
      // 
      this.dgvShowUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.dgvShowUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvShowUser.Location = new System.Drawing.Point(12, 12);
      this.dgvShowUser.Name = "dgvShowUser";
      this.dgvShowUser.Size = new System.Drawing.Size(474, 500);
      this.dgvShowUser.TabIndex = 0;
      // 
      // txtUser
      // 
      this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtUser.Location = new System.Drawing.Point(568, 12);
      this.txtUser.Name = "txtUser";
      this.txtUser.Size = new System.Drawing.Size(165, 20);
      this.txtUser.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(492, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Nome Utente";
      // 
      // txtPwd
      // 
      this.txtPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPwd.Location = new System.Drawing.Point(568, 38);
      this.txtPwd.Name = "txtPwd";
      this.txtPwd.Size = new System.Drawing.Size(165, 20);
      this.txtPwd.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(492, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Password";
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(492, 66);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(36, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Admin";
      // 
      // rdbTrue
      // 
      this.rdbTrue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.rdbTrue.AutoSize = true;
      this.rdbTrue.Location = new System.Drawing.Point(568, 64);
      this.rdbTrue.Name = "rdbTrue";
      this.rdbTrue.Size = new System.Drawing.Size(35, 17);
      this.rdbTrue.TabIndex = 6;
      this.rdbTrue.TabStop = true;
      this.rdbTrue.Text = "SI";
      this.rdbTrue.UseVisualStyleBackColor = true;
      // 
      // rdbFalse
      // 
      this.rdbFalse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.rdbFalse.AutoSize = true;
      this.rdbFalse.Location = new System.Drawing.Point(609, 64);
      this.rdbFalse.Name = "rdbFalse";
      this.rdbFalse.Size = new System.Drawing.Size(41, 17);
      this.rdbFalse.TabIndex = 7;
      this.rdbFalse.TabStop = true;
      this.rdbFalse.Text = "NO";
      this.rdbFalse.UseVisualStyleBackColor = true;
      // 
      // btnCanc
      // 
      this.btnCanc.Location = new System.Drawing.Point(618, 489);
      this.btnCanc.Name = "btnCanc";
      this.btnCanc.Size = new System.Drawing.Size(115, 23);
      this.btnCanc.TabIndex = 8;
      this.btnCanc.Text = "Annulla";
      this.btnCanc.UseVisualStyleBackColor = true;
      // 
      // btnSalva
      // 
      this.btnSalva.Location = new System.Drawing.Point(495, 489);
      this.btnSalva.Name = "btnSalva";
      this.btnSalva.Size = new System.Drawing.Size(115, 23);
      this.btnSalva.TabIndex = 9;
      this.btnSalva.Text = "Salva";
      this.btnSalva.UseVisualStyleBackColor = true;
      // 
      // frmAddUser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(745, 524);
      this.Controls.Add(this.btnSalva);
      this.Controls.Add(this.btnCanc);
      this.Controls.Add(this.rdbFalse);
      this.Controls.Add(this.rdbTrue);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtPwd);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtUser);
      this.Controls.Add(this.dgvShowUser);
      this.Name = "frmAddUser";
      this.Text = "frmAddUser";
      this.Load += new System.EventHandler(this.frmAddUser_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvShowUser)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvShowUser;
    private System.Windows.Forms.TextBox txtUser;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtPwd;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.RadioButton rdbTrue;
    private System.Windows.Forms.RadioButton rdbFalse;
    private System.Windows.Forms.Button btnCanc;
    private System.Windows.Forms.Button btnSalva;
  }
}