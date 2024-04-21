using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Pago_Efectivo : Pago
    {
       public double Monto { get; set; }
        public static double[] Coins = new double[]
        {
           0.01,
           0.02,
           0.5,
           0.10,
           0.20,
           0.50,
           1.00,
           2.00,
           5.0,
           10.0,
           20.0,
           50.0,
           100.0,
           200.0,
           500.0
,
        };
        public void PEfectivo(List<Product_General> Carrito)
        {
            foreach (Product_General p in Carrito)
            {
                Monto = Monto + p.PrecioUnidad;
            }
            do 
            {
                Monedas();
                Console.
            
            
            } while (true);
        }

    }
}
