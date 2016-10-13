namespace DataBase
{
    partial class AdminForm
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
      this.rdbMale = new System.Windows.Forms.RadioButton();
      this.rdbFemale = new System.Windows.Forms.RadioButton();
      this.rdbFiltro_both = new System.Windows.Forms.RadioButton();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.chb_filtroYON = new System.Windows.Forms.CheckBox();
      this.txtY_input = new System.Windows.Forms.TextBox();
      this.btnAddData = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnShowDgv = new System.Windows.Forms.Button();
      this.btnAddUser = new System.Windows.Forms.Button();
      this.btnDelUser = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // rdbMale
      // 
      this.rdbMale.AutoSize = true;
      this.rdbMale.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.rdbMale.Location = new System.Drawing.Point(53, 7);
      this.rdbMale.Name = "rdbMale";
      this.rdbMale.Size = new System.Drawing.Size(34, 17);
      this.rdbMale.TabIndex = 0;
      this.rdbMale.TabStop = true;
      this.rdbMale.Text = "M";
      this.rdbMale.UseVisualStyleBackColor = false;
      // 
      // rdbFemale
      // 
      this.rdbFemale.AutoSize = true;
      this.rdbFemale.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.rdbFemale.Location = new System.Drawing.Point(93, 7);
      this.rdbFemale.Name = "rdbFemale";
      this.rdbFemale.Size = new System.Drawing.Size(31, 17);
      this.rdbFemale.TabIndex = 1;
      this.rdbFemale.TabStop = true;
      this.rdbFemale.Text = "F";
      this.rdbFemale.UseVisualStyleBackColor = false;
      // 
      // rdbFiltro_both
      // 
      this.rdbFiltro_both.AutoSize = true;
      this.rdbFiltro_both.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.rdbFiltro_both.Location = new System.Drawing.Point(130, 7);
      this.rdbFiltro_both.Name = "rdbFiltro_both";
      this.rdbFiltro_both.Size = new System.Drawing.Size(66, 17);
      this.rdbFiltro_both.TabIndex = 2;
      this.rdbFiltro_both.TabStop = true;
      this.rdbFiltro_both.Text = "Entrambi";
      this.rdbFiltro_both.UseVisualStyleBackColor = false;
      this.rdbFiltro_both.Visible = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(36, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Sesso";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.label2.Location = new System.Drawing.Point(13, 33);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Anno";
      // 
      // chb_filtroYON
      // 
      this.chb_filtroYON.AutoSize = true;
      this.chb_filtroYON.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.chb_filtroYON.Location = new System.Drawing.Point(53, 33);
      this.chb_filtroYON.Name = "chb_filtroYON";
      this.chb_filtroYON.Size = new System.Drawing.Size(53, 17);
      this.chb_filtroYON.TabIndex = 5;
      this.chb_filtroYON.Text = "Attivo";
      this.chb_filtroYON.UseVisualStyleBackColor = false;
      this.chb_filtroYON.CheckedChanged += new System.EventHandler(this.chb_filtroYON_CheckedChanged);
      // 
      // txtY_input
      // 
      this.txtY_input.Location = new System.Drawing.Point(112, 31);
      this.txtY_input.Name = "txtY_input";
      this.txtY_input.Size = new System.Drawing.Size(84, 20);
      this.txtY_input.TabIndex = 6;
      this.txtY_input.Visible = false;
      // 
      // btnAddData
      // 
      this.btnAddData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnAddData.Location = new System.Drawing.Point(12, 284);
      this.btnAddData.Name = "btnAddData";
      this.btnAddData.Size = new System.Drawing.Size(141, 53);
      this.btnAddData.TabIndex = 7;
      this.btnAddData.Text = "Aggiungi Dati";
      this.btnAddData.UseVisualStyleBackColor = true;
      this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnCancel.Location = new System.Drawing.Point(159, 284);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(144, 53);
      this.btnCancel.TabIndex = 8;
      this.btnCancel.Text = "Cancella Dati";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnShowDgv
      // 
      this.btnShowDgv.Location = new System.Drawing.Point(12, 56);
      this.btnShowDgv.Name = "btnShowDgv";
      this.btnShowDgv.Size = new System.Drawing.Size(94, 37);
      this.btnShowDgv.TabIndex = 9;
      this.btnShowDgv.Text = "Visualizza";
      this.btnShowDgv.UseVisualStyleBackColor = true;
      this.btnShowDgv.Click += new System.EventHandler(this.btnShowDgv_Click);
      // 
      // btnAddUser
      // 
      this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnAddUser.Location = new System.Drawing.Point(12, 255);
      this.btnAddUser.Name = "btnAddUser";
      this.btnAddUser.Size = new System.Drawing.Size(141, 23);
      this.btnAddUser.TabIndex = 11;
      this.btnAddUser.Text = "Aggiungi User";
      this.btnAddUser.UseVisualStyleBackColor = true;
      this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
      // 
      // btnDelUser
      // 
      this.btnDelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnDelUser.Location = new System.Drawing.Point(159, 255);
      this.btnDelUser.Name = "btnDelUser";
      this.btnDelUser.Size = new System.Drawing.Size(144, 23);
      this.btnDelUser.TabIndex = 12;
      this.btnDelUser.Text = "Cancella User";
      this.btnDelUser.UseVisualStyleBackColor = true;
      // 
      // AdminForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(752, 349);
      this.Controls.Add(this.btnDelUser);
      this.Controls.Add(this.btnAddUser);
      this.Controls.Add(this.btnShowDgv);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnAddData);
      this.Controls.Add(this.txtY_input);
      this.Controls.Add(this.chb_filtroYON);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.rdbFiltro_both);
      this.Controls.Add(this.rdbFemale);
      this.Controls.Add(this.rdbMale);
      this.IsMdiContainer = true;
      this.Name = "AdminForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "AdminForm";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.AdminForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbFiltro_both;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chb_filtroYON;
        private System.Windows.Forms.TextBox txtY_input;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnShowDgv;
    private System.Windows.Forms.Button btnAddUser;
    private System.Windows.Forms.Button btnDelUser;
  }
}