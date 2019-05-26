using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RegistroArreglado.Entidades;

namespace RegistroArreglado.DAL
{
    public class Contexto : DbContext { 

    public DbSet<Personas> Personas { get; set; }
    public DbSet<CargosPersonas> CargosPersonas { get; set; }
    public Contexto() : base("ConStr")
    {

    }
}
}
