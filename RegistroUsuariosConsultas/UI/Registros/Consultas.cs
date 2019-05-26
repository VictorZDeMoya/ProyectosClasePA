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

namespace RegistroArreglado.UI.Registros
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }
        private void climpiar()
        {
            CIdSLT.Value = 0;
            DescripcionTXT.Text = String.Empty;
            CSuperErrorProvider.Clear();
        }
        private bool cValidar()
        {
            bool paso = true;
            if (String.IsNullOrWhiteSpace(DescripcionTXT.Text))
            {
                if (String.IsNullOrWhiteSpace(DescripcionTXT.Text))
                {
                    CSuperErrorProvider.SetError(DescripcionTXT, "¡Este campo no debe estar vacio!");
                }
                paso = false; }
            return paso;
        }
        private CargosPersonas cllenarClase()
        {
            CargosPersonas Usuario = new CargosPersonas();
            Usuario.CargoId = Convert.ToInt32(CIdSLT.Value);
            Usuario.Descripcion = DescripcionTXT.Text.ToString();
            return Usuario;
        }
        private void CGuardarBoton_Click(object sender, EventArgs e)
        {
            CargosPersonas Usuario;
            bool paso = false;


            if (!cValidar())
                return;
            Usuario = cllenarClase();
            climpiar();

            if (CIdSLT.Value == 0)
            {
                paso = CargosPersonasBLL.Guardar(Usuario);
            }
            else
            {
                if (!CExisteEnLaBasedeDatos())
                {
                    MessageBox.Show("¡No se puede modificar una cargo no existente!", "¡Falló!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = CargosPersonasBLL.Editar(Usuario);
            }
            if (paso)
                MessageBox.Show("¡Guardado!", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("¡No se pudo guardar!", "¡Falló!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool CExisteEnLaBasedeDatos()
        {
            CargosPersonas Usuario = CargosPersonasBLL.Buscar((int)CIdSLT.Value);
            return (Usuario != null);
        }
        private void CNuevoBoton_Click(object sender, EventArgs e)
        {
            climpiar();
        }

        private void LlenarCampos(CargosPersonas usuario)
        {
            CIdSLT.Value = usuario.CargoId;
            DescripcionTXT.Text = usuario.Descripcion;
            
        }
        private void CBuscarBoton_Click(object sender, EventArgs e)
        {
            int id;
            CargosPersonas usuario = new CargosPersonas();
            int.TryParse(CIdSLT.Value.ToString(), out id);
            climpiar();

            usuario = CargosPersonasBLL.Buscar(id);

            if (usuario != null)
            {
                MessageBox.Show("¡Persona Encontrada!");
                LlenarCampos(usuario);
            }
            else
                MessageBox.Show("¡Persona no encontrada!");
        }
        private void CEliminarBoton_Click(object sender, EventArgs e)
        {
            CSuperErrorProvider.Clear();
            int id;
            int.TryParse(Convert.ToString(CIdSLT.Value), out id);
            climpiar();
            if (PersonasBLL.Eliminar(id))
                MessageBox.Show("¡Eliminado!");
            else
                CSuperErrorProvider.SetError(CIdSLT, "¡No se puede eliminar una persona no existente!");
        }
    }

}
