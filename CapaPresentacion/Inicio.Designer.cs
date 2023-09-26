namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuTitular = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MenuUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.MenuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.MenuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.MenuProveedor = new FontAwesome.Sharp.IconMenuItem();
            this.MenuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.lblUsuarioEtiqueta = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTitular
            // 
            this.MenuTitular.AutoSize = false;
            this.MenuTitular.BackColor = System.Drawing.Color.SteelBlue;
            this.MenuTitular.Location = new System.Drawing.Point(0, 0);
            this.MenuTitular.Name = "MenuTitular";
            this.MenuTitular.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitular.Size = new System.Drawing.Size(971, 61);
            this.MenuTitular.TabIndex = 0;
            this.MenuTitular.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuario,
            this.MenuMantenedor,
            this.MenuVentas,
            this.MenuCompras,
            this.MenuProveedor,
            this.MenuClientes,
            this.MenuReportes,
            this.MenuAcercaDe});
            this.menuStrip2.Location = new System.Drawing.Point(0, 61);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(971, 73);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MenuUsuario
            // 
            this.MenuUsuario.AutoSize = false;
            this.MenuUsuario.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.MenuUsuario.IconColor = System.Drawing.Color.Black;
            this.MenuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUsuario.IconSize = 50;
            this.MenuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuario.Name = "MenuUsuario";
            this.MenuUsuario.Size = new System.Drawing.Size(80, 69);
            this.MenuUsuario.Text = "Usuarios";
            this.MenuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuMantenedor
            // 
            this.MenuMantenedor.AutoSize = false;
            this.MenuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.MenuMantenedor.IconColor = System.Drawing.Color.Black;
            this.MenuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuMantenedor.IconSize = 50;
            this.MenuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuMantenedor.Name = "MenuMantenedor";
            this.MenuMantenedor.Size = new System.Drawing.Size(80, 69);
            this.MenuMantenedor.Text = "Mantenedor";
            this.MenuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuVentas
            // 
            this.MenuVentas.AutoSize = false;
            this.MenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.MenuVentas.IconColor = System.Drawing.Color.Black;
            this.MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVentas.IconSize = 50;
            this.MenuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVentas.Name = "MenuVentas";
            this.MenuVentas.Size = new System.Drawing.Size(80, 69);
            this.MenuVentas.Text = "Ventas";
            this.MenuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuCompras
            // 
            this.MenuCompras.AutoSize = false;
            this.MenuCompras.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.MenuCompras.IconColor = System.Drawing.Color.Black;
            this.MenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuCompras.IconSize = 50;
            this.MenuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuCompras.Name = "MenuCompras";
            this.MenuCompras.Size = new System.Drawing.Size(80, 69);
            this.MenuCompras.Text = "Compras";
            this.MenuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuProveedor
            // 
            this.MenuProveedor.AutoSize = false;
            this.MenuProveedor.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.MenuProveedor.IconColor = System.Drawing.Color.Black;
            this.MenuProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuProveedor.IconSize = 50;
            this.MenuProveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProveedor.Name = "MenuProveedor";
            this.MenuProveedor.Size = new System.Drawing.Size(80, 69);
            this.MenuProveedor.Text = "Proveedores";
            this.MenuProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuClientes
            // 
            this.MenuClientes.AutoSize = false;
            this.MenuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.MenuClientes.IconColor = System.Drawing.Color.Black;
            this.MenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuClientes.IconSize = 50;
            this.MenuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(80, 69);
            this.MenuClientes.Text = "Clientes";
            this.MenuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuReportes
            // 
            this.MenuReportes.AutoSize = false;
            this.MenuReportes.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.MenuReportes.IconColor = System.Drawing.Color.Black;
            this.MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReportes.IconSize = 50;
            this.MenuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(80, 69);
            this.MenuReportes.Text = "Reportes";
            this.MenuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuAcercaDe
            // 
            this.MenuAcercaDe.AutoSize = false;
            this.MenuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.MenuAcercaDe.IconColor = System.Drawing.Color.Black;
            this.MenuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuAcercaDe.IconSize = 50;
            this.MenuAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuAcercaDe.Name = "MenuAcercaDe";
            this.MenuAcercaDe.Size = new System.Drawing.Size(80, 69);
            this.MenuAcercaDe.Text = "Acerca de";
            this.MenuAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(13, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(192, 20);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "SISTEMA DE VENTAS";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 134);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(971, 258);
            this.contenedor.TabIndex = 3;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // lblUsuarioEtiqueta
            // 
            this.lblUsuarioEtiqueta.AutoSize = true;
            this.lblUsuarioEtiqueta.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUsuarioEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioEtiqueta.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioEtiqueta.Location = new System.Drawing.Point(702, 23);
            this.lblUsuarioEtiqueta.Name = "lblUsuarioEtiqueta";
            this.lblUsuarioEtiqueta.Size = new System.Drawing.Size(74, 17);
            this.lblUsuarioEtiqueta.TabIndex = 4;
            this.lblUsuarioEtiqueta.Text = "Usuario: ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(782, 23);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(12, 17);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "l";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 392);
            this.Controls.Add(this.lblUsuarioEtiqueta);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.MenuTitular);
            this.MainMenuStrip = this.MenuTitular;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema De Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuTitular;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconMenuItem MenuAcercaDe;
        private FontAwesome.Sharp.IconMenuItem MenuUsuario;
        private FontAwesome.Sharp.IconMenuItem MenuMantenedor;
        private FontAwesome.Sharp.IconMenuItem MenuProveedor;
        private FontAwesome.Sharp.IconMenuItem MenuCompras;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private FontAwesome.Sharp.IconMenuItem MenuClientes;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label lblUsuarioEtiqueta;
        private System.Windows.Forms.Label lblUsuario;
    }
}

