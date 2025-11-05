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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiToolStripMenuItem,
            this.gestiónDeVehiculosToolStripMenuItem,
            this.ordenesDeTrabajoToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2381, 38);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestiToolStripMenuItem
            // 
            this.gestiToolStripMenuItem.Name = "gestiToolStripMenuItem";
            this.gestiToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
            this.gestiToolStripMenuItem.Text = "Gestión de Clientes";
            this.gestiToolStripMenuItem.Click += new System.EventHandler(this.managementClientMenuItem);
            // 
            // gestiónDeVehiculosToolStripMenuItem
            // 
            this.gestiónDeVehiculosToolStripMenuItem.Name = "gestiónDeVehiculosToolStripMenuItem";
            this.gestiónDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(160, 34);
            this.gestiónDeVehiculosToolStripMenuItem.Text = "Gestión de Vehiculos";
            this.gestiónDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.managementCarsMenuItem);
            // 
            // ordenesDeTrabajoToolStripMenuItem
            // 
            this.ordenesDeTrabajoToolStripMenuItem.Name = "ordenesDeTrabajoToolStripMenuItem";
            this.ordenesDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.ordenesDeTrabajoToolStripMenuItem.Text = "Ordenes de Trabajo";
            this.ordenesDeTrabajoToolStripMenuItem.Click += new System.EventHandler(this.workOrdersMenuItem);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(89, 34);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventoryMenuItem);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2400, 1350);
            this.panel1.TabIndex = 7;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1905, 1042);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.Text = "Formulario ";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

