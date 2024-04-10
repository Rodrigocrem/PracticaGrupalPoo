using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Pago_Tarjeta:Pago
    {
        private string numeroTarjeta;
        private string nombreTitular;
        private string fechaExpiracion;
        private int codigoSeguridad;

        public Pago_Tarjeta(string numero, string nombre, string fecha, int codigo)
        {
            numeroTarjeta = numero;
            nombreTitular = nombre;
            fechaExpiracion = fecha;
            codigoSeguridad = codigo;
        }

        public override void RealizarPago(double cantidad)
        {
            Console.WriteLine($"Pagando con tarjeta: ${cantidad}");
            // Aquí ponemos la lógica para realizar el pago con tarjeta
        }
    }
}
