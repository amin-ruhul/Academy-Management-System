using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
  public class Login
  {
      private string userId;
      private string password;
      private int status;


      public string UserId
      {
          get { return userId; }
          set { this.userId = value; }

      }

      public string Password
      {
          get { return password; }

          set {this. password = value; }
      }

      public int Status
      {
          get { return status; }
          set { this.status = value; }
      }

    }
}
