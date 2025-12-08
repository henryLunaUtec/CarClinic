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
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();
        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.Fill(this.carClinicBDDataSet.Clientes);
                this.vehiculosTableAdapter.Fill(this.carClinicBDDataSet.Vehiculos);

                vehiculosBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedValue != null)
            {
                try
                {
                    int idCliente = Convert.ToInt32(cmbClientes.SelectedValue);

                    vehiculosBindingSource.Filter = "ClienteID = " + idCliente;
                }
                catch
                {
                    vehiculosBindingSource.Filter = null;
                }
            }
        }

        private void btnGuardarVehiculo_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text == "")
            {
                MessageBox.Show("Debe escribir la placa.");
                txtPlaca.Focus();
                return;
            }

            if (cmbClientes.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.");
                return;
            }

            try
            {

                DataRowView fila = (DataRowView)vehiculosBindingSource.Current;

                fila["Placa"] = txtPlaca.Text;
                fila["Marca"] = txtMarca.Text;
                fila["Modelo"] = txtModelo.Text;

                int idCliente = Convert.ToInt32(cmbClientes.SelectedValue);
                fila["ClienteID"] = idCliente;

                if (txtAno.Text != "")
                {
                    int anio = Convert.ToInt32(txtAno.Text);
                    fila["Ano"] = anio;
                }

                vehiculosBindingSource.EndEdit();
                vehiculosTableAdapter.Update(carClinicBDDataSet.Vehiculos);
                vehiculosTableAdapter.Fill(carClinicBDDataSet.Vehiculos);

                MessageBox.Show("Vehículo guardado exitosamente.");

                vehiculosBindingSource.AddNew();

                txtPlaca.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("El año debe ser un número válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
    }
}
