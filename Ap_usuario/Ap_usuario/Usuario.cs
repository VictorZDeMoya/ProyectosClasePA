using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ap_usuario
{
  public  class Usuario
    {

      public Int64 Id { get; set; }
      public String Nombre { get; set; }
      public Int64 NivelUsuario { get; set; }
      public String Email { get; set; }
      public String Fecha_Ing { get; set; }

      public Usuario() { }

      public Usuario(Int64 pId, String pNombre, Int64 pNivelUsuario, String pEmail, String pFecha_Ing)

      {
          this.Id = pId;
          this.Nombre = pNombre;
          this.NivelUsuario = pNivelUsuario;
          this.Email = pEmail;
          this.Fecha_Ing = pFecha_Ing;
      
      }


    }
}
