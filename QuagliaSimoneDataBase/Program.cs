using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
  static class Program
  {
    /// <summary>
    /// Punto di ingresso principale dell'applicazione.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      //Application.Run(new frm_Login());

      frm_Login f = new frm_Login();
      f.ShowDialog();
      if (f.DialogResult == DialogResult.OK)
      {
        if (f.IsAdmin)
        {
          AdminForm frmSU = new AdminForm();
          frmSU.ShowDialog();
        }
        else
        {
          //To Do: Form per gli user, passare le variabili da AdminForm, nascondere gli oggetti per admin
        }
      }
      else if (f.DialogResult == DialogResult.Cancel)
      {
        MessageBox.Show("Il nome utente o la password non corrispondono", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }
  }
}
