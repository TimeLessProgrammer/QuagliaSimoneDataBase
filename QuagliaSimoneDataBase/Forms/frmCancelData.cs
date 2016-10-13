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

namespace QuagliaSimoneDataBase
{
  public partial class frmCancelData : Form
  {
    private List<AnagrafeDati> m_AnagrafeDati;

    void DgvRefresh()
    {
      DgvData.DataSource = m_AnagrafeDati.OrderBy(x => x.Nome).ToList();      
    } //caricamento dgv

    public frmCancelData()
    {
    }

    public frmCancelData(List<AnagrafeDati> m_AnagrafeDati)
    {
      this.m_AnagrafeDati = m_AnagrafeDati;
      InitializeComponent();
    } //lista passata da AdminForm

    private void frmCancelData_Load(object sender, EventArgs e)
    {
      DgvRefresh();
      btnDelete.Visible = false;
    } //nasconde il pulsante cancella e chiama il form per il load dati

    private void btnDelete_Click(object sender, EventArgs e)
    {
      AnagrafeDati itemDelete = DgvData.SelectedRows[0].DataBoundItem as AnagrafeDati;

      if (itemDelete != null)
      {
        m_AnagrafeDati.Remove(itemDelete);
        DgvRefresh();
      }
    } //cancella dati selezionati

    private void btnSave_Click(object sender, EventArgs e)
    {
      TextWriter sw = new StreamWriter("Anagrafica.txt", false);

      foreach (AnagrafeDati x in m_AnagrafeDati) 
        sw.WriteLine(x.Nome + "|" + x.Tipo + "|" + x.BornDate + "|" + Convert.ToString(x.Altezza) + "|" + x.Residenza + "\n");

      sw.Close();
    } //scrittura dei dati aggiornati

    private void btnCancel_Click(object sender, EventArgs e)
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
        MessageBox.Show("Il data base è vuoto", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      this.DialogResult = DialogResult.Cancel;
      sr.Close();
    } //chiusura form e aggiornamento lista

    private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      btnDelete.Visible = true;
    } //mostra pulsante cancella
  }
}
