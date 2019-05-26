using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroArreglado.Entidades;
using RegistroArreglado.DAL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace RegistroArreglado.BLL
{
    class CargosPersonasBLL
    {
        public static bool Guardar(CargosPersonas cargospersonas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.CargosPersonas.Add(cargospersonas) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static bool Editar(CargosPersonas cargospersonas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(cargospersonas).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {

                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();


            try
            {
                CargosPersonas cargospersonas = contexto.CargosPersonas.Find(id);
                contexto.CargosPersonas.Remove(cargospersonas);
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static CargosPersonas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            CargosPersonas cargospersonas = new CargosPersonas();

            try
            {
                cargospersonas = contexto.CargosPersonas.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return cargospersonas;
        }

        public static List<CargosPersonas> GetList(Expression<Func<CargosPersonas, bool>> expression)
        {
            List<CargosPersonas> cargospersonas = new List<CargosPersonas>();
            Contexto contexto = new Contexto();
            try
            {
                cargospersonas = contexto.CargosPersonas.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return cargospersonas;
        }
    }
}

