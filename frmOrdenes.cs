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
            try
            {
                this.clientesTableAdapter.Fill(this.carClinicBDDataSet.Clientes);
                this.vehiculosTableAdapter.Fill(this.carClinicBDDataSet.Vehiculos);
                this.inventarioTableAdapter.Fill(this.carClinicBDDataSet.Inventario);

                this.ordenesTableAdapter.Fill(this.carClinicBDDataSet.Ordenes);
                this.detalleOrdenTableAdapter.Fill(this.carClinicBDDataSet.DetalleOrden);
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
                    int idCliente = Convert.ToInt32(cmbClienteOrden.SelectedValue);
                    vehiculosBindingSource.Filter = "ClienteID = " + idCliente;
                }
                catch
                {
                    vehiculosBindingSource.Filter = null;
                }
            }
        }

        private void btnCrearOrden_Click(object sender, EventArgs e)
        {
            if (cmbClienteOrden.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el cliente.");
                return;
            }

            if (cmbVehiculoOrden.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el vehículo.");
                return;
            }

            if (txtDescripcionProblema.Text == "")
            {
                MessageBox.Show("Escriba el problema del carro.");
                txtDescripcionProblema.Focus();
                return;
            }

            try
            {
                ordenesBindingSource.AddNew();
                DataRowView fila = (DataRowView)ordenesBindingSource.Current;

                fila["Fecha"] = dtpFechaOrden.Value;
                fila["DescripcionProblema"] = txtDescripcionProblema.Text;
                fila["Estado"] = "Pendiente";

                int idVehiculo = Convert.ToInt32(cmbVehiculoOrden.SelectedValue);
                fila["VehiculoID"] = idVehiculo;

                ordenesBindingSource.EndEdit();
                ordenesTableAdapter.Update(carClinicBDDataSet.Ordenes);

                ordenesTableAdapter.Fill(carClinicBDDataSet.Ordenes);

                MessageBox.Show("Orden creada.");

                txtDescripcionProblema.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la orden: " + ex.Message);
            }
        }

        private void dgvOrdenes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrdenes.CurrentRow != null)
            {
                try
                {
                    DataRowView fila = (DataRowView)dgvOrdenes.CurrentRow.DataBoundItem;

                    int idOrden = Convert.ToInt32(fila["OrdenID"]);

                    detalleOrdenBindingSource.Filter = "OrdenID = " + idOrden;
                }
                catch
                {
                    detalleOrdenBindingSource.Filter = null;
                }
            }
        }

        private void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {
            if (dgvOrdenes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una orden de la lista de arriba.");
                return;
            }

            if (cmbRepuestos.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un repuesto.");
                return;
            }

            try
            {
                DataRowView filaOrden = (DataRowView)dgvOrdenes.CurrentRow.DataBoundItem;
                int idOrden = Convert.ToInt32(filaOrden["OrdenID"]);

                DataRowView filaRepuesto = (DataRowView)cmbRepuestos.SelectedItem;
                int idRepuesto = Convert.ToInt32(filaRepuesto["RepuestoID"]);
                decimal precio = Convert.ToDecimal(filaRepuesto["Precio"]);
                int stockActual = Convert.ToInt32(filaRepuesto["Stock"]);

                int cantidad = (int)numCantidad.Value;

                if (cantidad > stockActual)
                {
                    MessageBox.Show("No hay suficiente stock. Solo quedan: " + stockActual);
                    return;
                }

                detalleOrdenTableAdapter.Insert(idOrden, idRepuesto, cantidad, precio);

                int nuevoStock = stockActual - cantidad;
                filaRepuesto["Stock"] = nuevoStock;

                inventarioTableAdapter.Update(carClinicBDDataSet.Inventario);

                inventarioTableAdapter.Fill(carClinicBDDataSet.Inventario);
                detalleOrdenTableAdapter.Fill(carClinicBDDataSet.DetalleOrden);

                MessageBox.Show("Repuesto agregado correctamente.");

                numCantidad.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }
    }
}
