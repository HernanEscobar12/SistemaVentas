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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> Test = new CN_Usuario().Listar();
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtNroDocumento.Text && u.Clave == txtContraseña.Text).FirstOrDefault();
            if (ousuario != null)
            {
                Inicio inicio = new Inicio(ousuario);

                inicio.Show();
                this.Hide();

                inicio.FormClosed += frm_closing;
            }
            else
            {
                MessageBox.Show("No se Encontro el Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        //Mostrar pantalla de login ocultada previamente
        private void frm_closing(object sender, FormClosedEventArgs e)
        {
            txtNroDocumento.Clear();
            txtContraseña.Clear();
            this.Show();
        }

        

    }
}
