using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroArreglado.UI.Registros;

namespace RegistroArreglado
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }
        private void RegistroUsuariosSLT_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Visible = true;
        }

        private void MenuConsultasSLT_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();
            consultas.Visible = true;
        }
    }
}
