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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        public Usuario UsuarioSeleccionado { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = UsuarioDAL.BuscarUsuarios(txtNombre.Text, txtNivelUsuario.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Int64 Id = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                UsuarioSeleccionado = UsuarioDAL.ObtenerUsuario(Id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado Ningun Usuario");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Load(object sender, EventArgs e)
        {

        }
    }
}
