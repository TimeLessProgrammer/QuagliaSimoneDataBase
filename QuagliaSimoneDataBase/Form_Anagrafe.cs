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

namespace DataBase
{
  public partial class Form_Anagrafe : Form
  {
    AdminForm.AnagrafeDati[] Data = new AdminForm.AnagrafeDati[100];
    private int i = 0;

    public Form_Anagrafe()
    {
      InitializeComponent();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      Data[i].Nome = txtNome.Text;
      if (rdbF.Checked)
        Data[i].Tipo = "F";
      else if (rdbM.Checked)
        Data[i].Tipo = "M";
      Data[i].BornDate = TxtBornDate.Text;
      Data[i].Altezza = Convert.ToInt32(txtAltezza.Text);
      Data[i].Residenza = txtResidenza.Text;

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
        sw.WriteLine((i + 1).ToString());
        int j = 0;

        //for (int j = 0; j < Data.Count(); j++)
        //{
        //  sw.WriteLine(Data[j].Nome + "|" + Data[j].Tipo + "|" + Data[j].BornDate + "|" + Convert.ToString(Data[j].Altezza) + "|" + Data[j].Residenza);
        //}

        do
        {
          sw.WriteLine(Data[j].Nome + "|" + Data[j].Tipo + "|" + Data[j].BornDate + "|" + Convert.ToString(Data[j].Altezza) + "|" + Data[j].Residenza + "\n");
          j++;
          
        } while (Data[j].Nome != "" && Data[j].Tipo != "" && Data[j].BornDate != "" && Data[j].Altezza != 0 && Data[j].Residenza != "");

        sw.Close();        
        this.Close();
      }
    }

    private void bntAnnulla_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }
  }
}