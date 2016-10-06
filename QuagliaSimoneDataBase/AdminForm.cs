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
    public struct AnagrafeDati
    {
      public string Nome { get; set; }
      public string Tipo { get; set; } //M F
      public string BornDate { get; set; }
      public int Altezza { get; set; }
      public string Residenza { get; set; }
    }

    List<AnagrafeDati> m_AnagrafeDati = new List<AnagrafeDati>();

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
      Form_Anagrafe frmAnagrafe = new Form_Anagrafe();
      frmAnagrafe.ShowDialog();
    }

    private void btnShowDgv_Click(object sender, EventArgs e)
    {
      Form frm_dgv = new Form { Text = "Anagrafe", MdiParent = this };
      frm_dgv.Load += (g, o) =>
      {
        var dgvDati = new DataGridView { Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top) };

        if (rdbFemale.Checked)
          dgvDati.DataSource = m_AnagrafeDati.Select(x => x.Tipo.Equals("F")).ToList();
        else if (rdbMale.Checked)
          dgvDati.DataSource = m_AnagrafeDati.Select(x => x.Tipo.Equals("M")).ToList();
        else
          dgvDati.DataSource = m_AnagrafeDati.OrderBy(x => x.Nome).ToList();

        this.Controls.Add(dgvDati);
      };
      frm_dgv.Show();
    }
  }
}