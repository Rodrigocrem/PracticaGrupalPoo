using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Pago_Efectivo:Pago
    {
        public override void RealizarPago(double cantidad)
        {
            Console.WriteLine($"Pagando en efectivo: ${cantidad}");
            // Aquí pondremos la lógica para realizar el pago en efectivo
        }
    }
}
