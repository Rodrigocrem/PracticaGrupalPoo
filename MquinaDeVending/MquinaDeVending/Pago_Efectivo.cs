using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Pago_Efectivo : Pago
    {
        // Array estático que contiene los valores de las monedas y billetes disponibles
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
            // Bucle para permitir al usuario introducir dinero hasta alcanzar o superar la cantidad requerida
            do
            {
                Console.Clear();
                Console.WriteLine($"Cantidad introducida: {Monto}");
                Console.WriteLine($"Coste del carrito: {cantidad}");
                Console.WriteLine("Introduzca dinero");
                Console.WriteLine($"1- Moneda de {Coins[0]} centimos");
                Console.WriteLine($"2- Moneda de {Coins[1]} centimos");
                Console.WriteLine($"3- Moneda de {Coins[2]} centimos");
                Console.WriteLine($"4- Moneda de {Coins[3]} centimos");
                Console.WriteLine($"5- Moneda de {Coins[4]} centimos");
                Console.WriteLine($"6- Moneda de {Coins[5]} centimos");
                Console.WriteLine($"7- Moneda de {Coins[6]} euros");
                Console.WriteLine($"8- Moneda de {Coins[7]} euros");
                Console.WriteLine($"9- Billete de {Coins[8]} euros");
                Console.WriteLine($"10- Billete de {Coins[9]} euros");
                Console.WriteLine($"11- Billete de {Coins[10]} euros");
                Console.WriteLine($"12- Billete de {Coins[11]} euros");
                Console.WriteLine($"13- Billete de {Coins[12]} euros");
                Console.WriteLine($"14- Billete de {Coins[13]} euros");
                Console.WriteLine($"15- Billete de {Coins[14]} euros");
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
                // Comprobar si el monto introducido es suficiente para pagar la cantidad requerida.
                if (Monto == cantidad || Monto > cantidad)
                {
                    Monto = Monto - cantidad;
                    Console.WriteLine($"Cantidad devuelta: {Monto}");
                    Console.ReadKey();
                    coste = true;
                    return true;               
                }
            } while (coste == false);
            return false;

        }
    }
}
