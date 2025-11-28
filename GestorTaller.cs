using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoU
{
    public class GestorTaller
    {
        public decimal CalcularSubtotal(decimal precioUnitario, int cantidad)
        {
            decimal total = precioUnitario * cantidad;
            return total;
        }
        public bool ValidarStock(int stockActual, int cantidadSolicitada)
        {
            if (stockActual >= cantidadSolicitada)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
