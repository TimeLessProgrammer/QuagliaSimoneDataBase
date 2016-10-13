using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuagliaSimoneDataBase
{
  public partial class frmAddUser : Form
  {
    public frmAddUser()
    {
      InitializeComponent();
    }

    private void frmAddUser_Load(object sender, EventArgs e)
    {
      dgvShowUser.DataSource = Class.helper.Authenticator;
    }
  }
}
