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
         0.05,
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
        public override bool RealizarPago(double cantidad)
        {
            bool coste = false;
            int opcion;
            Monto = 0;
            do
            {
                Console.Clear();
                Console.WriteLine($"Cantidad introducida: {Monto}");
                Console.WriteLine($"Coste del carrito: {cantidad}");
                Console.WriteLine("Introduzca dinero");
                Console.WriteLine($"1- {Coins[0]}");
                Console.WriteLine($"2- {Coins[1]}");
                Console.WriteLine($"3- {Coins[2]}");
                Console.WriteLine($"4- {Coins[3]}");
                Console.WriteLine($"5- {Coins[4]}");
                Console.WriteLine($"6- {Coins[5]}");
                Console.WriteLine($"7- {Coins[6]}");
                Console.WriteLine($"8- {Coins[7]}");
                Console.WriteLine($"9- {Coins[8]}");
                Console.WriteLine($"10- {Coins[9]}");
                Console.WriteLine($"11- {Coins[10]}");
                Console.WriteLine($"12- {Coins[11]}");
                Console.WriteLine($"13- {Coins[12]}");
                Console.WriteLine($"14- {Coins[13]}");
                Console.WriteLine($"15- {Coins[14]}");
                Console.WriteLine("16- Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Monto += Coins[0];
                        break;
                    case 2:
                        Monto += Coins[1];
                        break;
                    case 3:
                        Monto += Coins[2];
                        break;
                    case 4:
                        Monto += Coins[3];
                        break;
                    case 5:
                        Monto += Coins[4];
                        break;
                    case 6:
                        Monto += Coins[5];
                        break;
                    case 7:
                        Monto += Coins[6];
                        break;
                    case 8:
                        Monto += Coins[7];
                        break;
                    case 9:
                        Monto += Coins[8];
                        break;
                    case 10:
                        Monto += Coins[9];
                        break;
                    case 11:
                        Monto += Coins[10];
                        break;
                    case 12:
                        Monto += Coins[11];
                        break;
                    case 13:
                        Monto += Coins[12];
                        break;
                    case 14:
                        Monto += Coins[13];
                        break;
                    case 15:
                        Monto += Coins[14];
                        break;
                    case 16:
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;

                }
                if (Monto == cantidad || Monto > cantidad)
                {
                    coste = true;
                    return true;
                }
            } while (coste == false);
            return false;

        }
    }
}
