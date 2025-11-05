using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoU
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes formularioClientes = new frmClientes();
            formularioClientes.MdiParent = this;
            formularioClientes.Show();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            frmVehiculos formularioVehiculos = new frmVehiculos();
            formularioVehiculos.MdiParent = this;
            formularioVehiculos.Show();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            frmOrdenes formularioOrdenes = new frmOrdenes();
            formularioOrdenes.MdiParent = this;
            formularioOrdenes.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmInventario formularioInventario = new frmInventario();
            formularioInventario.MdiParent = this;
            formularioInventario.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            openModalInPanel(new frmClientes());
        }

        private void openModalInPanel(Form form)
        {
            
            if (this.panel1.Controls.Count > 0) this.panel1.Controls.Clear();

            
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            this.panel1.Controls.Add(form);

            form.Show();
        }

        private void managementClientMenuItem(object sender, EventArgs e)
        {
            openModalInPanel(new frmClientes());
        }

        private void managementCarsMenuItem(object sender, EventArgs e)
        {
            openModalInPanel(new frmVehiculos());
        }

        private void workOrdersMenuItem(object sender, EventArgs e)
        {
            openModalInPanel(new frmOrdenes());

        }

        private void inventoryMenuItem(object sender, EventArgs e)
        {
            openModalInPanel(new frmInventario());
        }
    }
}
