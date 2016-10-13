using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuagliaSimoneDataBase;

namespace DataBase
{
  public partial class Form_Anagrafe : Form
  {
    private int i = 0;
    private List<AnagrafeDati> m_AnagrafeDati;

    public Form_Anagrafe()
    {
   
    }

    public Form_Anagrafe(List<AnagrafeDati> m_AnagrafeDati)
    {
      this.m_AnagrafeDati = m_AnagrafeDati;
      InitializeComponent();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      QuagliaSimoneDataBase.AnagrafeDati l = new QuagliaSimoneDataBase.AnagrafeDati();
      var success = false;

      while(!success)
      {
        try
        {
          l.Nome = txtNome.Text;
          if (rdbF.Checked)
            l.Tipo = "F";
          else if (rdbM.Checked)
            l.Tipo = "M";
          l.BornDate = TxtBornDate.Text;
          l.Altezza = Convert.ToInt32(txtAltezza.Text);
          l.Residenza = txtResidenza.Text;
          m_AnagrafeDati.Add(l);
          success = true;
        }
        catch (FormatException error)
        {
          MessageBox.Show(error.HResult.ToString() + ": " + error.Message, "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
          success = false;
        } //To Do: risolvere il loop del try catch
      }

      DialogResult result = MessageBox.Show("Vuole aggiungere un nuovo dato ?", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
      if (result == DialogResult.OK)
      {
        txtAltezza.Text = "";
        TxtBornDate.Text = "";
        txtNome.Text = "";
        txtResidenza.Text = "";
        rdbF.Checked = false;
        rdbM.Checked = false;
        i++;
      }
      else if (result == DialogResult.Cancel)
      {
        TextWriter sw = new StreamWriter("Anagrafica.txt", false);
        sw.WriteLine(m_AnagrafeDati.Count);
        int j = 0;

        foreach(QuagliaSimoneDataBase.AnagrafeDati x in m_AnagrafeDati)
        {
          sw.WriteLine(m_AnagrafeDati[j].Nome + "|" + m_AnagrafeDati[j].Tipo + "|" + m_AnagrafeDati[j].BornDate + "|" + Convert.ToString(m_AnagrafeDati[j].Altezza) + "|" + m_AnagrafeDati[j].Residenza + "\n");
          j++;
        };

        sw.Close();        
        this.Close();
      }
    } //caricamento lista, pulizia campi per nuovo imput, salvataggio sul file di testo

    private void bntAnnulla_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }
  }
}