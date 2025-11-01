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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            openModalInPanel(new frmClientes());
        }

        private void openModalInPanel(Form form)
        {
            //validacion para no tener mas de un panel abierto(evita que hayan muchos paneles sobrepuestos) asi evitamos fuga de memoria
            if (this.panel1.Controls.Count > 0) this.panel1.Controls.Clear();

            // configuracion de como se ven las vistas dentro del panel
            form.TopLevel = false; // indicamos que el form a llamar no se vera a manera de modal sino que se vera como un elemento mas ejemplo button o text
            form.FormBorderStyle = FormBorderStyle.None; // quitamos el borde
            form.Dock = DockStyle.Fill; //ocupa todo el espacio del pannel

            // Agrega el form al panel
            this.panel1.Controls.Add(form);

            form.Show(); //mostrar el formulario
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
