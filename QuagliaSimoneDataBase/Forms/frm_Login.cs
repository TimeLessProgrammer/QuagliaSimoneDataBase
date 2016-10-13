using QuagliaSimoneDataBase.Class;
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
    //List<QuagliaSimoneDataBase.Login> Authenticator = new List<QuagliaSimoneDataBase.Login>();

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
        string Line = "";
        string[] comodo = new string[3];
        int i = 0;
        

        while (sr.Peek() != -1)
        {
          //QuagliaSimoneDataBase.Login line = new QuagliaSimoneDataBase.Login();          
          Line = sr.ReadLine();
          comodo = Line.Split('|');
          //line.User = comodo[0];
          //line.Pwd = comodo[1];
          //line.IsSU = comodo[2];
          //Authenticator.Add(line);
          helper.Login element = new helper.Login()
          {
            User = comodo[0],
            Pwd = comodo[1],
            IsSU = comodo[2]
          };
          helper.Authenticator.Add(element);
         i++;
        }

        foreach(var x in helper.Authenticator)
        {
          if (txt_ID.Text == x.User && txt_pwd.Text == x.Pwd)
          {
            retVal = true;
            IsAdmin = Convert.ToBoolean(x.IsSU);
          }
        }
      }
      return retVal;
    }

    private void btn_log_Click_Click(object sender, EventArgs e)
    {
      this.DialogResult = (Controllo()) ? DialogResult.OK : DialogResult.Cancel;
      this.Close();
    }

    private void frm_Login_Load(object sender, EventArgs e)
    {
#if DEBUG
      txt_ID.Text = "Super User";
      txt_pwd.Text = "admin";
# endif 
    }
  }
}
