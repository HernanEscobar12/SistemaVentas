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
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio(Usuario objusuario)
        {

            usuarioActual = objusuario;
            InitializeComponent();
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {
            lblUsuario.Text = usuarioActual.NombreCompleto.ToString();
        }

        private void AbrirFormulario(IconMenuItem Menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
                
                Menu.BackColor = Color.Silver;
                MenuActivo = Menu;


            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;
            contenedor.Controls.Add(formulario);

            formulario.Show();  
        }

        private void MenuUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());

        }


        // Menu Administrador
        private void subMenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuAdministrador, new frmCategorias());
        }
        private void subMenuProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuAdministrador, new frmProductos());
        }



        
        // Menu Proveedor
        private void MenuProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

         // Menu Clientes

        private void MenuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }



   

        // Menu Ventas

        private void subMenuRegistarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new frmVentas());
        }

        private void subMenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new frmDetalleVenta());
        }

        // Menu Compra
        private void subMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new frmDetalleCompra());
        }

        private void subMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new frmCompras());
        }

        // Menu Reportes

        private void MenuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
        }

     

    }
}
