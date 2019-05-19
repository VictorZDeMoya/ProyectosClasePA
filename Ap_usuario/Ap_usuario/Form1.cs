using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ap_usuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Usuario UsuarioActual { get; set; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            if (txtNombre.Text == "" || txtNivelUsuario.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Usuario Usuario = new Usuario();
                Usuario.Nombre = txtNombre.Text;
                Usuario.NivelUsuario = txtNivelUsuario.Text;
                Usuario.Email = txtEmail.Text;
                Usuario.Fecha_Ing = dtfecha.Value.ToShortDateString();


                int resultado = UsuarioDAL.Agregar(Usuario);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos Guardados Corerectamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                   
                }

                else
                {
                    MessageBox.Show("No se pudieron Guardar lo datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar pBuscar = new Buscar();
            pBuscar.ShowDialog();

            if (pBuscar.UsuarioSeleccionado != null)
            {
                UsuarioActual = pBuscar.UsuarioSeleccionado;

                txtNombre.Text = pBuscar.UsuarioSeleccionado.Nombre;
                txtNivelUsuario.Text = pBuscar.UsuarioSeleccionado.Apellido;
                txtEmail.Text = pBuscar.UsuarioSeleccionado.Email;
                dtfechaIng.Text = pBuscar.UsuarioSeleccionado.Fecha_Ing;

                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usiario pUsuario = new Usuario();
            pUsuario.Nombre = txtNombre.Text;
            pUsuario.NivelUsuario = txtNivelUsuario.Text;
            pUsuario.Email = txtEmail.Text;
            pUsuario.Fecha_Ing = dtfechaIng.Value.ToShortDateString();
            pUsuario.Id = UsuarioActual.Id;


            int resultado = UsuarioDAL.Modificar(pUsuario);

            if (resultado > 0)
            {

                MessageBox.Show("Usuario Modificado con exito", "Usuario Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnGuardar.Enabled = true;
            }

            else
            {
                MessageBox.Show("No se pudo Modificar el Usuario", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




        }


        void limpiar()
        {
            txtNombre.Clear();
            txtNivelUsuario.Clear();
            txtEmail.Clear();
            dtfechaIng.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el Usuario?", "¿Esta seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int resultado = UsuarioDAL.Eliminar(UsuarioActual.Id);

                if (resultado > 0)
                {

                    MessageBox.Show("Usuarios Eliminado Correctamente", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = true;
                }

                else
                {
                    MessageBox.Show("No se pudo Eliminar el usuario", "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Cancelado");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Registro_Usuarios re = new Registro_Usuarios();
            re.Show();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
       
    }
}
