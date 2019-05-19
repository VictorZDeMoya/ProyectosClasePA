using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Ap_usuario
{
    class UsuarioDAL
    {

       public static int Agregar(Usuario pUsuario)
       {
           int retorno = 0;
           using (SqlConnection Conn = BDComun.ObtnerCOnexion())
           { 
           SqlCommand Comando=new SqlCommand(string.Format("Insert Into Usuarios (Nombre, Nivel Usuario, Email, Fecha_ingreso) values ('{0}', '{1}','{2}','{3}')",
               pUsuario.Nombre, pUsuario.NivelUsuario, pUsuario.Email, pUsuario.Fecha_Ing),Conn);

           retorno = Comando.ExecuteNonQuery();
           Conn.Close();
           
           }
           return retorno;       
       }


       public static List<Usuario> BuscarUsuarios(String pNombre, String pApellido)
       {

           List<Usuario> Lista = new List<Usuario>();
           using (SqlConnection conexion = BDComun.ObtnerCOnexion())
           {
               SqlCommand comando = new SqlCommand(string.Format(
                   "Select Id, Nombre,  NivelUsuario, Email, Fecha_Ing from Usuarios where Nombre like '%{0}%' or Apellido like '%{1}%'", pNombre), conexion);

               SqlDataReader reader = comando.ExecuteReader();

               while (reader.Read())
               {
                   Usuario pUsuario = new Usuario();
                   pUsuario.Id = reader.GetInt64(0);
                   pUsuario.Nombre = reader.GetString(1);
                   pUsuario.NivelUsuario = reader.GetInt64(2);
                   pUsuario.Email = reader.GetString(3);
                   pUsuario.Fecha_Ing = Convert.ToString(reader.GetDateTime(4));

                   Lista.Add(pUsuario);

               }
               conexion.Close();
               return Lista;

           }

       }



       public static Usuario ObtenerUsuario(Int64 pId)
       {

           using (SqlConnection conexion = BDComun.ObtnerCOnexion())
           {

               Usuario pUsuario = new Usuario();
               SqlCommand comando = new SqlCommand(string.Format(
                   "Select Id, Nombre,  NivelUsuario, Email, Fecha_Ing from Usuarios where Id={0}",pId), conexion);

               SqlDataReader reader = comando.ExecuteReader();

               while (reader.Read())
               {
                   pUsuario.Id = reader.GetInt64(0);
                   pUsuario.Nombre = reader.GetString(1);
                   pUsuario.NivelUsuario = reader.GetInt64(2);
                   pUsuario.Email = reader.GetString(3);
                   pUsuario.Fecha_Ing = Convert.ToString(reader.GetDateTime(4));

                   

               }
               conexion.Close();
               return pUsuario;

           }

       }



       public static int Modificar(Usuario pUsuario)
       {
           int retorno = 0;
           using (SqlConnection conexion = BDComun.ObtnerCOnexion())
           {
               SqlCommand comando = new SqlCommand(string.Format("Update Usuarios set Nombre='{0}', NivelUsuario='{1}', Email='{2}', Fecha_Ingreso='{3}' where Id={4}",
                   pUsuario.Nombre, pUsuario.NivelUsuario, pUsuario.Email, pUsuario.Fecha_Ing, pUsuario.Id), conexion);

               retorno = comando.ExecuteNonQuery();
               conexion.Close();
           }
           return retorno;
       
       }


       public static int Eliminar(Int64 pId)
       {
           int retorno = 0;
           using (SqlConnection conexion = BDComun.ObtnerCOnexion())
           {

               SqlCommand comando = new SqlCommand(string.Format("Delete from Usuarios where Id={0}", pId), conexion);
               retorno = comando.ExecuteNonQuery();
               conexion.Close();
           }
           return retorno;
       
       }





    }
}
