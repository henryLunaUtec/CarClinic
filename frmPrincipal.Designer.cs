namespace ProyectoU
{
    partial class frmPrincipal
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(803, 41);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(124, 41);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Gestión de Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Location = new System.Drawing.Point(803, 97);
            this.btnVehiculos.Margin = new System.Windows.Forms.Padding(2);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(124, 41);
            this.btnVehiculos.TabIndex = 1;
            this.btnVehiculos.Text = "Gerstión de Vehículos";
            this.btnVehiculos.UseVisualStyleBackColor = true;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.Location = new System.Drawing.Point(803, 155);
            this.btnOrdenes.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(124, 41);
            this.btnOrdenes.TabIndex = 2;
            this.btnOrdenes.Text = "Órdenes de Trabajo";
            this.btnOrdenes.UseVisualStyleBackColor = true;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(803, 215);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(124, 41);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiToolStripMenuItem,
            this.gestiónDeVehiculosToolStripMenuItem,
            this.ordenesDeTrabajoToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestiToolStripMenuItem
            // 
            this.gestiToolStripMenuItem.Name = "gestiToolStripMenuItem";
            this.gestiToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestiToolStripMenuItem.Text = "Gestión de Clientes";
            this.gestiToolStripMenuItem.Click += new System.EventHandler(this.managementClientMenuItem);
            // 
            // gestiónDeVehiculosToolStripMenuItem
            // 
            this.gestiónDeVehiculosToolStripMenuItem.Name = "gestiónDeVehiculosToolStripMenuItem";
            this.gestiónDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.gestiónDeVehiculosToolStripMenuItem.Text = "Gestión de Vehiculos";
            this.gestiónDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.managementCarsMenuItem);
            // 
            // ordenesDeTrabajoToolStripMenuItem
            // 
            this.ordenesDeTrabajoToolStripMenuItem.Name = "ordenesDeTrabajoToolStripMenuItem";
            this.ordenesDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.ordenesDeTrabajoToolStripMenuItem.Text = "Ordenes de Trabajo";
            this.ordenesDeTrabajoToolStripMenuItem.Click += new System.EventHandler(this.workOrdersMenuItem);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventoryMenuItem);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 478);
            this.panel1.TabIndex = 7;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnOrdenes);
            this.Controls.Add(this.btnVehiculos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

