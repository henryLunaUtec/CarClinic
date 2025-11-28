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
            try
            {
                this.inventarioTableAdapter.Fill(this.carClinicBDDataSet.Inventario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el inventario: " + ex.Message);
            }
        }

        private void btnNuevoRepuesto_Click(object sender, EventArgs e)
        {
            inventarioBindingSource.AddNew();

            txtNombreRepuesto.Text = "";
            txtPrecioRepuesto.Text = "";
            txtStockRepuesto.Text = "";

            txtNombreRepuesto.Focus();
        }

        private void btnGuardarRepuesto_Click(object sender, EventArgs e)
        {
            if (txtNombreRepuesto.Text == "")
            {
                MessageBox.Show("El nombre del repuesto es obligatorio.");
                txtNombreRepuesto.Focus();
                return;
            }

            try
            {
                DataRowView fila = (DataRowView)inventarioBindingSource.Current;

                fila["NombreRepuesto"] = txtNombreRepuesto.Text;

                if (txtPrecioRepuesto.Text != "")
                {
                    decimal precio = Convert.ToDecimal(txtPrecioRepuesto.Text);
                    fila["Precio"] = precio;
                }
                else
                {
                    MessageBox.Show("Debe poner un precio.");
                    return;
                }

                if (txtStockRepuesto.Text != "")
                {
                    int stock = Convert.ToInt32(txtStockRepuesto.Text);
                    fila["Stock"] = stock;
                }
                else
                {
                    MessageBox.Show("Debe poner la cantidad (Stock).");
                    return;
                }

                inventarioBindingSource.EndEdit();

                inventarioTableAdapter.Update(carClinicBDDataSet.Inventario);

                inventarioTableAdapter.Fill(carClinicBDDataSet.Inventario);

                MessageBox.Show("Repuesto guardado.");

                btnNuevoRepuesto_Click(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor revise los números. El Precio y el Stock deben ser valores numéricos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
    }
}
// Codigo actualizado al 28/11/2025
