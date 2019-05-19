using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Ap_usuario
{
   public class BDComun
    {
       public static SqlConnection ObtnerCOnexion()
       {
           SqlConnection Conn = new SqlConnection("Data source=VICTOR-PC; Initial Catalog=Usuario; User Id=admin; Password=admin");
           Conn.Open();

           return Conn;

       }


    }
}
