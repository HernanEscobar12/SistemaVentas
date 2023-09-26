using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        public Inicio(Usuario objusuario)
        {

            usuarioActual = objusuario;
            InitializeComponent();
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {
            lblUsuario.Text = usuarioActual.NombreCompleto.ToString();
        }
 
    }
}
