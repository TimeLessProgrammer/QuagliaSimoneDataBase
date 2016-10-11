﻿using System;
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
    //List<QuagliaSimoneDataBase.AnagrafeDati> Data = new List<QuagliaSimoneDataBase.AnagrafeDati>();
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
      l.Nome = txtNome.Text;
      if (rdbF.Checked)
        l.Tipo = "F";
      else if (rdbM.Checked)
        l.Tipo = "M";
      l.BornDate = TxtBornDate.Text;
      l.Altezza = Convert.ToInt32(txtAltezza.Text);
      l.Residenza = txtResidenza.Text;
      m_AnagrafeDati.Add(l);

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
        TextWriter sw = new StreamWriter("Anagrafica.txt", true);
        sw.WriteLine((i + 1).ToString());
        int j = 0;

        //for (int j = 0; j < Data.Count(); j++)
        //{
        //  sw.WriteLine(Data[j].Nome + "|" + Data[j].Tipo + "|" + Data[j].BornDate + "|" + Convert.ToString(Data[j].Altezza) + "|" + Data[j].Residenza);
        //}

        foreach(QuagliaSimoneDataBase.AnagrafeDati x in m_AnagrafeDati)
        {
          sw.WriteLine(m_AnagrafeDati[j].Nome + "|" + m_AnagrafeDati[j].Tipo + "|" + m_AnagrafeDati[j].BornDate + "|" + Convert.ToString(m_AnagrafeDati[j].Altezza) + "|" + m_AnagrafeDati[j].Residenza + "\n");
          j++;
        };

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