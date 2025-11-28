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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.Fill(this.carClinicBDDataSet.Clientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clientesBindingSource.AddNew();

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";

            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validador miValidador = new Validador();

            if (miValidador.EsTextoValido(txtNombre, "Nombre") == false) return;
            if (miValidador.EsTextoValido(txtApellido, "Apellido") == false) return;
            if (miValidador.EsTextoValido(txtTelefono, "Teléfono") == false) return;

            try
            {
                DataRowView filaActual = (DataRowView)clientesBindingSource.Current;

                filaActual["Nombre"] = txtNombre.Text;
                filaActual["Apellido"] = txtApellido.Text;
                filaActual["Telefono"] = txtTelefono.Text;
                filaActual["Direccion"] = txtDireccion.Text;

                clientesBindingSource.EndEdit();

                clientesTableAdapter.Update(carClinicBDDataSet.Clientes);

                clientesTableAdapter.Fill(carClinicBDDataSet.Clientes);

                MessageBox.Show("Cliente guardado correctamente.");

                btnNuevo_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar este cliente?",
                                                     "Confirmación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try { 
                
                    clientesBindingSource.RemoveCurrent();

                    clientesTableAdapter.Update(carClinicBDDataSet.Clientes);

                    MessageBox.Show("Cliente eliminado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar el cliente. Verifique que no tenga vehículos registrados o inténtelo de nuevo.\n\nError: " + ex.Message);

                    clientesTableAdapter.Fill(carClinicBDDataSet.Clientes);
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
