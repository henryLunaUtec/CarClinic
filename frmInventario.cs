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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'carClinicBDDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.carClinicBDDataSet.Inventario);

            try
            {
                this.inventarioTableAdapter.Fill(this.carClinicBDDataSet.Inventario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el inventario: " + ex.Message);
            }
        }

        private void btnNuevoRepuesto_Click(object sender, EventArgs e)
        {
            this.inventarioBindingSource.AddNew();
            txtNombreRepuesto.Focus();
        }

        private void btnGuardarRepuesto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreRepuesto.Text))
            {
                MessageBox.Show("El nombre del repuesto es obligatorio.");
                txtNombreRepuesto.Focus();
                return;
            }

            try
            {
                DataRowView filaActual = (DataRowView)this.inventarioBindingSource.Current;
                filaActual["NombreRepuesto"] = txtNombreRepuesto.Text;

                decimal precio;
                if (decimal.TryParse(txtPrecioRepuesto.Text, out precio))
                {
                    filaActual["Precio"] = precio;
                }
                else
                {
                    MessageBox.Show("El precio debe ser un número válido (ej. 150.50).");
                    txtPrecioRepuesto.Focus();
                    this.inventarioBindingSource.CancelEdit();
                    return;
                }

                int stock;
                if (int.TryParse(txtStockRepuesto.Text, out stock))
                {
                    filaActual["Stock"] = stock;
                }
                else
                {
                    MessageBox.Show("El stock debe ser un número entero válido (ej. 10).");
                    txtStockRepuesto.Focus();
                    this.inventarioBindingSource.CancelEdit();
                    return;
                }

                this.Validate();
                this.inventarioBindingSource.EndEdit();
                this.inventarioTableAdapter.Update(this.carClinicBDDataSet.Inventario);

                this.inventarioTableAdapter.Fill(this.carClinicBDDataSet.Inventario);

                MessageBox.Show("Repuesto guardado exitosamente.");

                btnNuevoRepuesto_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el repuesto: " + ex.Message);
                this.inventarioTableAdapter.Fill(this.carClinicBDDataSet.Inventario);
            }
        }
    }
}
