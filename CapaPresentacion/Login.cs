using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Inicio inicio = new Inicio();

            inicio.Show();
            this.Hide();

            inicio.FormClosed += frm_closing; 
           
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
