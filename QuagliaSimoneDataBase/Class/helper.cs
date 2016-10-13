using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuagliaSimoneDataBase.Class
{
  public static class helper
  {

    public class Login
    {
      public string User { get; set; }
      public string Pwd { get; set; }
      public string IsSU { get; set; }
    }

    public static List<Login> Authenticator = new List<Login>();
  }
}
