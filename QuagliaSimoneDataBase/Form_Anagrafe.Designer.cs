namespace DataBase
{
    partial class Form_Anagrafe
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
      this.bntAnnulla = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.txtResidenza = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtAltezza = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.rdbF = new System.Windows.Forms.RadioButton();
      this.rdbM = new System.Windows.Forms.RadioButton();
      this.label1 = new System.Windows.Forms.Label();
      this.TxtBornDate = new System.Windows.Forms.TextBox();
      this.txtNome = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // bntAnnulla
      // 
      this.bntAnnulla.Location = new System.Drawing.Point(111, 134);
      this.bntAnnulla.Name = "bntAnnulla";
      this.bntAnnulla.Size = new System.Drawing.Size(85, 39);
      this.bntAnnulla.TabIndex = 26;
      this.bntAnnulla.Text = "Annulla";
      this.bntAnnulla.UseVisualStyleBackColor = true;
      this.bntAnnulla.Click += new System.EventHandler(this.bntAnnulla_Click);
      // 
      // btnOK
      // 
      this.btnOK.Location = new System.Drawing.Point(11, 133);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(85, 39);
      this.btnOK.TabIndex = 25;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(11, 110);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(57, 13);
      this.label5.TabIndex = 24;
      this.label5.Text = "Residenza";
      // 
      // txtResidenza
      // 
      this.txtResidenza.Location = new System.Drawing.Point(96, 107);
      this.txtResidenza.Name = "txtResidenza";
      this.txtResidenza.Size = new System.Drawing.Size(100, 20);
      this.txtResidenza.TabIndex = 23;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(11, 84);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(41, 13);
      this.label4.TabIndex = 22;
      this.label4.Text = "Altezza";
      // 
      // txtAltezza
      // 
      this.txtAltezza.Location = new System.Drawing.Point(96, 81);
      this.txtAltezza.Name = "txtAltezza";
      this.txtAltezza.Size = new System.Drawing.Size(100, 20);
      this.txtAltezza.TabIndex = 21;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(11, 58);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(78, 13);
      this.label3.TabIndex = 20;
      this.label3.Text = "Data di nascita";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(11, 34);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(36, 13);
      this.label2.TabIndex = 19;
      this.label2.Text = "Sesso";
      // 
      // rdbF
      // 
      this.rdbF.AutoSize = true;
      this.rdbF.Location = new System.Drawing.Point(136, 32);
      this.rdbF.Name = "rdbF";
      this.rdbF.Size = new System.Drawing.Size(31, 17);
      this.rdbF.TabIndex = 18;
      this.rdbF.TabStop = true;
      this.rdbF.Text = "F";
      this.rdbF.UseVisualStyleBackColor = true;
      // 
      // rdbM
      // 
      this.rdbM.AutoSize = true;
      this.rdbM.BackColor = System.Drawing.SystemColors.Control;
      this.rdbM.Location = new System.Drawing.Point(96, 32);
      this.rdbM.Name = "rdbM";
      this.rdbM.Size = new System.Drawing.Size(34, 17);
      this.rdbM.TabIndex = 17;
      this.rdbM.TabStop = true;
      this.rdbM.Text = "M";
      this.rdbM.UseVisualStyleBackColor = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 16;
      this.label1.Text = "Nome";
      // 
      // TxtBornDate
      // 
      this.TxtBornDate.Location = new System.Drawing.Point(96, 55);
      this.TxtBornDate.Name = "TxtBornDate";
      this.TxtBornDate.Size = new System.Drawing.Size(100, 20);
      this.TxtBornDate.TabIndex = 15;
      // 
      // txtNome
      // 
      this.txtNome.Location = new System.Drawing.Point(96, 6);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(100, 20);
      this.txtNome.TabIndex = 14;
      // 
      // Form_Anagrafe
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(208, 187);
      this.Controls.Add(this.bntAnnulla);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtResidenza);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtAltezza);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.rdbF);
      this.Controls.Add(this.rdbM);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TxtBornDate);
      this.Controls.Add(this.txtNome);
      this.Name = "Form_Anagrafe";
      this.Text = "Form_Anagrafe";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntAnnulla;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResidenza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBornDate;
        private System.Windows.Forms.TextBox txtNome;
    }
}