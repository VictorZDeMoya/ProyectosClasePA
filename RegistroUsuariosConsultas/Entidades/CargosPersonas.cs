using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistroArreglado.Entidades
{
    public class CargosPersonas
    {
        [Key]
        public int CargoId { get; set; }
        public string Descripcion { get; set; }


        public CargosPersonas()
        {
            CargoId = 0;
            Descripcion = string.Empty;
        }
    }
}
