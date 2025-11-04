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
            // TODO: esta línea de código carga datos en la tabla 'carClinicBDDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.carClinicBDDataSet.Clientes);

            try 
            {
                this.clientesTableAdapter.Fill(this.carClinicBDDataSet.Clientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de clientes: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.clientesBindingSource.AddNew();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                txtNombre.Focus(); // Ponemos el cursor en el nombre
                return;
            }
            try
            {
                DataRowView filaActual = (DataRowView)this.clientesBindingSource.Current;
                filaActual["Nombre"] = txtNombre.Text;
                filaActual["Apellido"] = txtApellido.Text;
                filaActual["Telefono"] = txtTelefono.Text;
                filaActual["Direccion"] = txtDireccion.Text;

                this.Validate();
                this.clientesBindingSource.EndEdit();
                this.clientesTableAdapter.Update(this.carClinicBDDataSet.Clientes);

                this.clientesTableAdapter.Fill(this.carClinicBDDataSet.Clientes);

                MessageBox.Show("Datos guardados exitosamente.");
                btnNuevo_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminar.");
                return;
            }

            DataRowView filaActual = (DataRowView)this.clientesBindingSource.Current;
            int clienteID = (int)filaActual["ClienteID"];

            CarClinicBDDataSetTableAdapters.VehiculosTableAdapter vehiculosAdapter =
                new CarClinicBDDataSetTableAdapters.VehiculosTableAdapter();

            int conteoVehiculos = (int)vehiculosAdapter.GetVehiculoCountByClienteID(clienteID);

            if (conteoVehiculos > 0)
            {
                MessageBox.Show(
                    "Este cliente no se puede eliminar porque tiene " + conteoVehiculos + " vehículo(s) registrado(s).\n" +
                    "Por favor, elimine sus vehículos primero.",
                    "Error de eliminación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        this.clientesBindingSource.RemoveCurrent();

                        this.clientesTableAdapter.Update(this.carClinicBDDataSet.Clientes);
                        this.clientesTableAdapter.Fill(this.carClinicBDDataSet.Clientes);
                        MessageBox.Show("Cliente eliminado.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                        this.clientesTableAdapter.Fill(this.carClinicBDDataSet.Clientes);
                    }
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
