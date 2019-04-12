using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abarrotes_Limon
{
    class Producto
    {


        public double SubTotal (int cantidad, int precio)
        {
            return (cantidad * precio);

        }

        public double IVA (double Subtotal)
        {
            return (Subtotal + (Subtotal * .16));
        }

        public double Total (double subtotal, double iva)
        {
            return (subtotal + iva);
        }

        public double Pago (double total, double pago)
        {
             return (pago - total);
        }

        public string Productos (string nombre, int cantidad, int precio, int importe )
        {
            return "Gracias por su compra :)" + "Artículo:" + nombre + "/n" + "Cantidad: " + cantidad + "/n" + "Precio" + precio + "/n" + "Importe:" + importe;
        }
    }
}
