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
        txtY_input.Text = "";
        rdbFiltro_both.Visible = false;
        rdbFiltro_both.Checked = false;
      }
    } //filtri maschio femmina e anno

    private void btnAddData_Click(object sender, EventArgs e)
    {
      Form_Anagrafe frmAnagrafe = new Form_Anagrafe(m_AnagrafeDati);
      frmAnagrafe.ShowDialog();
    } //richiama la form per aggiungere dati

    private void btnShowDgv_Click(object sender, EventArgs e)
    {
      Form frm_dgv = new Form { Text = "Anagrafe", MdiParent = this, StartPosition = FormStartPosition.CenterScreen };
      frm_dgv.Load += (g, o) =>
      {
        var dgvDati = new DataGridView { Dock= DockStyle.Fill, AutoGenerateColumns=true };
        

        if (rdbFemale.Checked)
          dgvDati.DataSource = m_AnagrafeDati.Where(x => x.Tipo == "F").Where(x => x.BornDate.Contains(txtY_input.Text)).OrderBy(x => x.Nome).ToList();
        else if (rdbMale.Checked)
          dgvDati.DataSource = m_AnagrafeDati.Where(x => x.Tipo == "M").Where(x => x.BornDate.Contains(txtY_input.Text)).OrderBy(x => x.Nome).ToList();
        else
          dgvDati.DataSource = m_AnagrafeDati.OrderBy(x => x.Nome).Where(x => x.BornDate.Contains(txtY_input.Text)).ToList();
         
        frm_dgv.Controls.Add(dgvDati);
        frm_dgv.Size = new Size(dgvDati.Width, dgvDati.Height);
      };      
      frm_dgv.Show();
       
    } //mostra una form mdi contenente la dgv visualizza, viene istanziato un eventhandler per l'ordinamento

    private void AdminForm_Load(object sender, EventArgs e)
    {
      StreamReader sr = new StreamReader("Anagrafica.txt");
      frm_Login frmLogin = new frm_Login();
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
        MessageBox.Show("Il data base è vuoto", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      sr.Close();
    } //caricamento dati già presenti nel file di testo

    private void btnCancel_Click(object sender, EventArgs e)
    {
      QuagliaSimoneDataBase.frmCancelData frmCancella = new QuagliaSimoneDataBase.frmCancelData(m_AnagrafeDati);
      frmCancella.ShowDialog();
    } //richiama form per cancellare

    private void btnAddUser_Click(object sender, EventArgs e)
    {
      var frmAddUser = new QuagliaSimoneDataBase.frmAddUser();
      frmAddUser.ShowDialog();
    }
  }
}