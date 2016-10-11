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
  public partial class AdminForm : Form
  {
    //public struct AnagrafeDati
    //{
    //  public string Nome { get; set; }
    //  public string Tipo { get; set; } //M F
    //  public string BornDate { get; set; }
    //  public int Altezza { get; set; }
    //  public string Residenza { get; set; }
    //}

    List<QuagliaSimoneDataBase.AnagrafeDati> m_AnagrafeDati = new List<QuagliaSimoneDataBase.AnagrafeDati>();

    public AdminForm()
    {
      InitializeComponent();
    }

    private void chb_filtroYON_CheckedChanged(object sender, EventArgs e)
    {
      if (chb_filtroYON.Checked)
      {
        txtY_input.Visible = true;
        rdbFiltro_both.Visible = true;
      }

      if (!chb_filtroYON.Checked)
      {
        txtY_input.Visible = false;
        rdbFiltro_both.Visible = false;
      }
    }

    private void btnAddData_Click(object sender, EventArgs e)
    {
      Form_Anagrafe frmAnagrafe = new Form_Anagrafe(m_AnagrafeDati);
      frmAnagrafe.ShowDialog();
    }

    private void btnShowDgv_Click(object sender, EventArgs e)
    {
      Form frm_dgv = new Form { Text = "Anagrafe", MdiParent = this, StartPosition = FormStartPosition.CenterScreen };
      frm_dgv.Load += (g, o) =>
      {
        var dgvDati = new DataGridView { Dock= DockStyle.Fill, AutoGenerateColumns=true };

        if (rdbFemale.Checked)
          dgvDati.DataSource = m_AnagrafeDati.Where(x => x.Tipo == "F").OrderBy(x => x.Nome).ToList();
        else if (rdbMale.Checked)
          dgvDati.DataSource = m_AnagrafeDati.Where(x => x.Tipo == "M").OrderBy(x => x.Nome).ToList();
        else
          dgvDati.DataSource = m_AnagrafeDati.OrderBy(x => x.Nome).ToList();
         
        frm_dgv.Controls.Add(dgvDati);
      };
      frm_dgv.Show();
       
    }

    private void AdminForm_Load(object sender, EventArgs e)
    {      
      StreamReader sr = new StreamReader("Anagrafica.txt");
      Int32 Fcount = Convert.ToInt32(sr.ReadLine());

      if (Fcount != 0)
      {
        while (sr.Peek() != -1)
        {
          QuagliaSimoneDataBase.AnagrafeDati line = new QuagliaSimoneDataBase.AnagrafeDati();
          var lineRead = sr.ReadLine();

          if (lineRead.Length > 1)
          {
            var splitter = lineRead.Split('|');
            line.Nome = splitter[0];
            line.Tipo = splitter[1];
            line.BornDate = splitter[2];
            line.Altezza = Convert.ToInt32(splitter[3]);
            line.Residenza = splitter[4];
            m_AnagrafeDati.Add(line);
          }
        }
      }
      else
        MessageBox.Show("Il data base è vuoto","ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }
}