using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;


namespace RegistroArreglado.Entidades
{
    public class Personas
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string LvlUsuario { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Personas()
        {
            IdUsuario = 0;
            Nombres = string.Empty;
            Email = string.Empty;
            LvlUsuario = string.Empty;
            Usuario = string.Empty;
            Contrasena = string.Empty;
            FechaIngreso = DateTime.Now;

        }

    }
}
