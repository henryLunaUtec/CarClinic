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
    public partial class frmOrdenes : Form
    {
        public frmOrdenes()
        {
            InitializeComponent();
        }

        private void frmOrdenes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'carClinicBDDataSet.DetalleOrden' Puede moverla o quitarla según sea necesario.
            this.detalleOrdenTableAdapter.Fill(this.carClinicBDDataSet.DetalleOrden);
            // TODO: esta línea de código carga datos en la tabla 'carClinicBDDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.carClinicBDDataSet.Inventario);
            // TODO: esta línea de código carga datos en la tabla 'carClinicBDDataSet.Ordenes' Puede moverla o quitarla según sea necesario.
            this.ordenesTableAdapter.Fill(this.carClinicBDDataSet.Ordenes);
            // TODO: esta línea de código carga datos en la tabla 'carClinicBDDataSet.Vehiculos' Puede moverla o quitarla según sea necesario.
            this.vehiculosTableAdapter.Fill(this.carClinicBDDataSet.Vehiculos);
            // TODO: esta línea de código carga datos en la tabla 'carClinicBDDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.carClinicBDDataSet.Clientes);
            try
            {
                this.ordenesTableAdapter.Fill(this.carClinicBDDataSet.Ordenes);
                this.vehiculosTableAdapter.Fill(this.carClinicBDDataSet.Vehiculos);
                this.clientesTableAdapter.Fill(this.carClinicBDDataSet.Clientes);
                ////////////////////////////////////////////////////////////////////////
                this.detalleOrdenTableAdapter.Fill(this.carClinicBDDataSet.DetalleOrden);
                this.inventarioTableAdapter.Fill(this.carClinicBDDataSet.Inventario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void cmbClienteOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClienteOrden.SelectedValue != null)
            {
                try
                {
                    int clienteIDseleccionado = (int)cmbClienteOrden.SelectedValue;

                    this.vehiculosBindingSource.Filter = "ClienteID = " + clienteIDseleccionado;
                }
                catch (Exception)
                {
                    this.vehiculosBindingSource.Filter = null;
                }
            }
            else
            {
                this.vehiculosBindingSource.Filter = null;
            }
        }

        private void btnCrearOrden_Click(object sender, EventArgs e)
        {
            if (cmbClienteOrden.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.");
                cmbClienteOrden.Focus();
                return;
            }

            if (cmbVehiculoOrden.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un vehículo.");
                cmbVehiculoOrden.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcionProblema.Text))
            {
                MessageBox.Show("Debe ingresar una descripción del problema.");
                txtDescripcionProblema.Focus();
                return;
            }

            try
            {
                int vehiculoID = (int)cmbVehiculoOrden.SelectedValue;

                this.ordenesBindingSource.AddNew();

                DataRowView filaActual = (DataRowView)this.ordenesBindingSource.Current;

                filaActual["Fecha"] = dtpFechaOrden.Value;
                filaActual["DescripcionProblema"] = txtDescripcionProblema.Text;
                filaActual["VehiculoID"] = vehiculoID;

                filaActual["Estado"] = "Pendiente";

                this.Validate();
                this.ordenesBindingSource.EndEdit();
                this.ordenesTableAdapter.Update(this.carClinicBDDataSet.Ordenes);

                this.ordenesTableAdapter.Fill(this.carClinicBDDataSet.Ordenes);

                MessageBox.Show("Orden creada exitosamente.");

                txtDescripcionProblema.Text = "";
                cmbClienteOrden.SelectedIndex = -1;
                cmbVehiculoOrden.SelectedIndex = -1;
                this.vehiculosBindingSource.Filter = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la orden: " + ex.Message);
                this.ordenesTableAdapter.Fill(this.carClinicBDDataSet.Ordenes);
            }
        }

        private void dgvOrdenes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrdenes.CurrentRow != null)
            {
                try
                {
                    DataRowView filaSeleccionada = (DataRowView)dgvOrdenes.CurrentRow.DataBoundItem;
                    int ordenIDseleccionada = (int)filaSeleccionada["OrdenID"];
                    this.detalleOrdenBindingSource.Filter = "OrdenID = " + ordenIDseleccionada;
                }
                catch (Exception)
                {
                    this.detalleOrdenBindingSource.Filter = null;
                }
            }
            else
            {
                this.detalleOrdenBindingSource.Filter = null;
            }
        }

        private void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {
        if (dgvOrdenes.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar una orden primero.");
                    return;
                }

                if (cmbRepuestos.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un repuesto.");
                    return;
                }

                if (numCantidad.Value <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor a cero.");
                    return;
                }

                try
                {
                    DataRowView filaOrden = (DataRowView)dgvOrdenes.CurrentRow.DataBoundItem;
                    int ordenID = (int)filaOrden["OrdenID"];

                    DataRowView filaRepuesto = (DataRowView)cmbRepuestos.SelectedItem;
                    int repuestoID = (int)filaRepuesto["RepuestoID"];
                    decimal precioUnitario = (decimal)filaRepuesto["Precio"];
                    int cantidad = (int)numCantidad.Value;

                    int stockActual = (int)filaRepuesto["Stock"];
                    if (cantidad > stockActual)
                    {
                        MessageBox.Show("No hay suficiente stock. Quedan: " + stockActual);
                        return;
                    }

                    this.detalleOrdenTableAdapter.Insert(
                        ordenID,
                        repuestoID,
                        cantidad,
                        precioUnitario
                    );

                    filaRepuesto["Stock"] = stockActual - cantidad;
                    this.inventarioTableAdapter.Update(this.carClinicBDDataSet.Inventario);
                    this.inventarioTableAdapter.Fill(this.carClinicBDDataSet.Inventario);

                    this.detalleOrdenTableAdapter.Fill(this.carClinicBDDataSet.DetalleOrden);

                    MessageBox.Show("Repuesto agregado a la orden.");

                    cmbRepuestos.SelectedIndex = -1;
                    numCantidad.Value = 1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el repuesto: " + ex.Message);

                    this.inventarioTableAdapter.Fill(this.carClinicBDDataSet.Inventario);
                    this.detalleOrdenTableAdapter.Fill(this.carClinicBDDataSet.DetalleOrden);
                }
            }
    }
}
