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
            // TODO: esta línea de código carga datos en la tabla 'carClinicBDDataSet.Vehiculos' Puede moverla o quitarla según sea necesario.
            this.vehiculosTableAdapter.Fill(this.carClinicBDDataSet.Vehiculos);
            // TODO: esta línea de código carga datos en la tabla 'carClinicBDDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.carClinicBDDataSet.Clientes);

            ///////////////////////////////////////////////////////////////////////
            try
            {
                this.vehiculosTableAdapter.Fill(this.carClinicBDDataSet.Vehiculos);
                this.clientesTableAdapter.Fill(this.carClinicBDDataSet.Clientes);
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
                    int clienteIDseleccionado = (int)cmbClientes.SelectedValue;
                    this.vehiculosBindingSource.Filter = "ClienteID = " + clienteIDseleccionado;
                }
                catch (Exception ex)
                {
                    this.vehiculosBindingSource.Filter = null;
                }
            }
            else
            {
                this.vehiculosBindingSource.Filter = null;
            }
        }

        private void btnGuardarVehiculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlaca.Text))
            {
                MessageBox.Show("La placa del vehículo es obligatoria.");
                txtPlaca.Focus();
                return;
            }
            if (cmbClientes.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.");
                cmbClientes.Focus();
                return;
            }
            try
            {
                int clienteID = (int)cmbClientes.SelectedValue;

                this.vehiculosBindingSource.AddNew();

                DataRowView filaActual = (DataRowView)this.vehiculosBindingSource.Current;

                filaActual["Placa"] = txtPlaca.Text;
                filaActual["Marca"] = txtMarca.Text;
                filaActual["Modelo"] = txtModelo.Text;
                ///////////////////////////////////////
                int ano;
                if (int.TryParse(txtAno.Text, out ano))
                {
                    filaActual["Ano"] = ano;
                }
                else if (string.IsNullOrWhiteSpace(txtAno.Text))
                {
                    filaActual["Ano"] = DBNull.Value;
                }
                else
                {
                    MessageBox.Show("El año debe ser un número válido (ej. 2011).");
                    txtAno.Focus();
                    return;
                }
                filaActual["ClienteID"] = clienteID;

                this.Validate();
                this.vehiculosBindingSource.EndEdit();
                this.vehiculosTableAdapter.Update(this.carClinicBDDataSet.Vehiculos);
                this.vehiculosTableAdapter.Fill(this.carClinicBDDataSet.Vehiculos);

                MessageBox.Show("Vehículo guardado exitosamente.");

                txtPlaca.Text = "";
                txtMarca.Text = "";
                txtModelo.Text = "";
                txtAno.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el vehículo: " + ex.Message);
                this.vehiculosTableAdapter.Fill(this.carClinicBDDataSet.Vehiculos);
            }
        }
    }
}
