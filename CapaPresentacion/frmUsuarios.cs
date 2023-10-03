using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new OpcionesCombo() {Valor = 1, Texto= "Activo"});
            cboEstado.Items.Add(new OpcionesCombo() {Valor = 0, Texto= "No Activo"});
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedItem = 0;

            List<Rol> ListaRol = new Cn_Rol().Listar();
            foreach (Rol item in ListaRol)
            {
                cboRol.Items.Add(new OpcionesCombo() {Valor = item.IdRol, Texto= item.Descripcion});
               
            }
            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";
            cboRol.SelectedItem = 0;

        }


    }
}
