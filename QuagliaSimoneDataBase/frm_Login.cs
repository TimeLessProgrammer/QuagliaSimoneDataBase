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
  public partial class frm_Login : Form
  {
    public Boolean IsAdmin = false;

    private struct Login
    {
      public string User { get; set; }
      public string Pwd { get; set; }
      public string IsSU { get; set; }
    }

    public frm_Login()
    {
      InitializeComponent();
    }

    private Boolean Controllo()
    {
      bool retVal = false;
      if (txt_ID.Text == "" || txt_pwd.Text == "")
      {
        MessageBox.Show("Uno dei seguenti campi non è stato riemnpito", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        retVal = false;
      }
      else
      {
        StreamReader sr = new StreamReader("UserLogin.txt");
        Login[] User = new Login[5];
        string Line = "";
        string[] comodo = new string[3];
        int i = 0;

        while (sr.Peek() != -1)
        {
          Line = sr.ReadLine();
          comodo = Line.Split('|');
          User[i].User = comodo[0];
          User[i].Pwd = comodo[1];
          User[i].IsSU = comodo[2];
          i++;
        }

        int j = 0;
        do
        {
          if (txt_ID.Text == User[j].User && txt_pwd.Text == User[j].Pwd)
          {
            retVal = true;
          }
          IsAdmin = Convert.ToBoolean(User[j].IsSU);
          j++;
        } while (!retVal && j < i);
      }
      return retVal;
    }

    private void btn_log_Click_Click(object sender, EventArgs e)
    {
      this.DialogResult = (Controllo()) ? DialogResult.OK : DialogResult.Cancel;
      this.Close();
    }
  }
}
