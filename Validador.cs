using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoU
{
    public class Validador
    {
        public bool EsTextoValido(TextBox caja, string nombreCampo)
        {
            if (caja.Text.Trim() == "")
            {
                MessageBox.Show("El campo '" + nombreCampo + "' es obligatorio.");
                caja.Focus();
                return false; 
            }
            return true;
        }

        public bool EsDecimal(TextBox caja, string nombreCampo)
        {
            if (caja.Text.Trim() == "")
            {
                MessageBox.Show("El campo '" + nombreCampo + "' es obligatorio.");
                caja.Focus();
                return false;
            }

            try
            {
                Convert.ToDecimal(caja.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("El campo '" + nombreCampo + "' debe ser un número válido.");
                caja.Focus();
                return false;
            }
        }
        public bool EsEntero(TextBox caja, string nombreCampo)
        {
            if (caja.Text.Trim() == "")
            {
                return true;
            }

            try
            {
                Convert.ToInt32(caja.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("El campo '" + nombreCampo + "' debe ser un número entero.");
                caja.Focus();
                return false;
            }
        }
    }
}