using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Prodruct_Electronica:Product_General
    {
        public string Material {  get; set; }
        public int Peso { get; set; }

        public Prodruct_Electronica() { }

        public Prodruct_Electronica(int id, string nombre, double precio, int precioUnidad, string descripcion, string material, int peso)
            :base(id, nombre, precio, precioUnidad,)
        {
            material = Material;
            peso = Peso;
        }
       
        public string ObtenerInforamcionProducto()
        {
            return $"Id: {Id}\n\t Nombre: {Nombre}\n\t Precio: {Precio}\n\t PrecioUnidad: {PrecioUnidad}\n\t Descripcion: {Descripcion}\n\t Material: {Material}\n\t Peso: {Peso} ";
        }

    }
}
