using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroArreglado.BLL;
using RegistroArreglado.Entidades;
using RegistroArreglado.DAL;
using System.Data.Entity;

namespace RegistroArreglado.UI.Registros
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            FechaIngresoSLT.Value.ToString("yyyy/MM/dd");
        }
        private void limpiar()
        {
            IdSLT.Value = 0;
            NombreTXT.Text = String.Empty;
            EmailTXT.Text = String.Empty;
            LvlUsuarioTXT.Text = String.Empty;
            NombreUsuarioTXT.Text = String.Empty;
            ContrasenaTXT.Text = String.Empty;
            FechaIngresoSLT.Value = DateTime.Now;
            SuperErrorProvider.Clear();
        }

        private bool Validar()
        {
            bool paso = true;
            if (String.IsNullOrWhiteSpace(NombreTXT.Text) || String.IsNullOrWhiteSpace(EmailTXT.Text) || String.IsNullOrWhiteSpace(LvlUsuarioTXT.Text) ||
                String.IsNullOrWhiteSpace(NombreUsuarioTXT.Text) || String.IsNullOrWhiteSpace(ContrasenaTXT.Text))
            {
                if (String.IsNullOrWhiteSpace(NombreTXT.Text))
                {
                    SuperErrorProvider.SetError(NombreTXT, "¡Este campo no debe estar vacio!");
                }

                if (String.IsNullOrWhiteSpace(EmailTXT.Text))
                {
                    SuperErrorProvider.SetError(EmailTXT, "¡Este campo no debe estar vacio!");
                    EmailTXT.Focus();
                }

                if (String.IsNullOrWhiteSpace(LvlUsuarioTXT.Text))
                {
                    SuperErrorProvider.SetError(LvlUsuarioTXT, "¡Este campo no debe estar vacio!");
                    LvlUsuarioTXT.Focus();
                }

                if (String.IsNullOrWhiteSpace(NombreUsuarioTXT.Text))
                {
                    SuperErrorProvider.SetError(NombreUsuarioTXT, "¡Este campo no debe estar vacio!");
                    NombreUsuarioTXT.Focus();
                }

                if (String.IsNullOrWhiteSpace(ContrasenaTXT.Text))
                {
                    SuperErrorProvider.SetError(ContrasenaTXT, "¡Este campo no debe estar vacio!");
                    ContrasenaTXT.Focus();
                }
                paso = false;


            }
            return paso;
        }
        private Personas llenarClase()
        {
            Personas Usuario = new Personas();
            Usuario.IdUsuario = Convert.ToInt32(IdSLT.Value);
            Usuario.Nombres = NombreTXT.Text.ToString();
            Usuario.Email = EmailTXT.Text.ToString();
            Usuario.LvlUsuario = LvlUsuarioTXT.Text.ToString();
            Usuario.Contrasena = ContrasenaTXT.Text.ToString();
            Usuario.Usuario = NombreUsuarioTXT.Text.ToString();
            Usuario.FechaIngreso = FechaIngresoSLT.Value;
            return Usuario;
        }
        private void GuardarBoton_Click(object sender, EventArgs e)
        {
            Personas Usuario;
            bool paso = false;


            if (!Validar())
                return;
            Usuario = llenarClase();
            limpiar();

            if (IdSLT.Value == 0)
            {
                paso = PersonasBLL.Guardar(Usuario);
            }
            else
            {
                if (!ExisteEnLaBasedeDatos())
                {
                    MessageBox.Show("¡No se puede modificar una persona no existente!", "¡Falló!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = PersonasBLL.Editar(Usuario);
            }
            if (paso)
                MessageBox.Show("¡Guardado!", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("¡No se pudo guardar!", "¡Falló!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ExisteEnLaBasedeDatos()
        {
            Personas Usuario = PersonasBLL.Buscar((int)IdSLT.Value);
            return (Usuario != null);
        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void LlenarCampos(Personas usuario)
        {
            IdSLT.Value = usuario.IdUsuario;
            NombreTXT.Text = usuario.Nombres;
            EmailTXT.Text = usuario.Email;
            LvlUsuarioTXT.Text = usuario.LvlUsuario;
            NombreUsuarioTXT.Text = usuario.Usuario;
            ContrasenaTXT.Text = usuario.Contrasena;
            FechaIngresoSLT.Value = usuario.FechaIngreso;
        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            int id;
            Personas usuario = new Personas();
            int.TryParse(IdSLT.Value.ToString(), out id);
            limpiar();

            usuario = PersonasBLL.Buscar(id);

            if (usuario != null)
            {
                MessageBox.Show("¡Persona Encontrada!");
                LlenarCampos(usuario);
            }
            else
                MessageBox.Show("¡Persona no encontrada!");
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            SuperErrorProvider.Clear();
            int id;
            int.TryParse(Convert.ToString(IdSLT.Value), out id);
            limpiar();
            if (PersonasBLL.Eliminar(id))
                MessageBox.Show("¡Eliminado!");
            else
                SuperErrorProvider.SetError(IdSLT, "¡No se puede eliminar una persona no existente!");
        }

    }
}
