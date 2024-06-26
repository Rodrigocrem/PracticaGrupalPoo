﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Pago_Tarjeta : Pago
    {
        public double Monto { get; set; }
        public double Saldo { get; set; }

        public override bool RealizarPago(double cantidad)
        {

            Console.WriteLine("Rellena los siguientes datos:");
            Console.WriteLine("Numero de Tarjeta");
            string nTarjeta = Console.ReadLine();
            Console.WriteLine("Fecha de caducidad de la tarjeta(DD/MM/YYYY):");
            string fCaducidad = Console.ReadLine();
            Console.WriteLine("Codigo de seguridad (CVV):");
            int CVV = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuanto saldo dispone:");
            double saldo = double.Parse(Console.ReadLine());

            if (Saldo >= cantidad)
            {
                Console.WriteLine("Compra realizada correctamente.");
                Console.ReadKey();
                return true;

            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
                Console.ReadKey();
                return false;
            }
        }
        // Método para realizar el pago con tarjeta.
        public void PagoTarjeta(List<Product_General> Carrito)
        {
            foreach (Product_General p in Carrito)
            {
                Console.WriteLine("Rellena los siguientes datos:");
                Console.WriteLine("Numero de Tarjeta");
                string nTarjeta = Console.ReadLine();
                Console.WriteLine("Fecha de caducidad de la tarjeta(DD/MM/YYYY):");
                string fCaducidad = Console.ReadLine();
                Console.WriteLine("Codigo de seguridad (CVV):");
                int CVV = int.Parse(Console.ReadLine());
                Console.WriteLine("Cuanto saldo dispone:");
                double saldo = double.Parse(Console.ReadLine());
            }
            if (Saldo >= Monto)
            {
                Console.WriteLine("Compra realizada correctamente.");


            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");

            }

        }

    }
}
