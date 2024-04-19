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
            //string dinero = GestionarPago(cantidad);
            //Console.WriteLine("Monedas introducidas: " + dinero);

        }

        //private string GestionarPago(double cantidad)
        //{
        //  int[] ValorDinero = { 20, 10, 5, 2, 1};
        //int[] centimos = (int)(cantidad * 100); //Revisar esto. 
        //StringBuilder monedasEntregadas = new StringBuilder();
        //}
    }
}
