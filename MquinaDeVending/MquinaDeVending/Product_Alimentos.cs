using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Product_Alimentos:Product_General
    {
        public int Calorias {  get; set; }
        public int Grasa { get; set; }
        public int Azucar { get; set;}
    }

    public Product_Alimentos (){ }

    public Product_Alimentos (int id, string nombre, double precio, int precioUnidad, string descripcion, int calorias, int grasa, int azucar)
        :base(id, nombre, precio, precioUnidad, descripcion, calorias, grasa, azucar)
    {
        Calorias = calorias;
        Grasa = grasa;
        Azucar = azucar;
    }
    public override string ObtenerInforamcionProducto()
    {
        return $"Id: {Id}\n\t Nombre: {Nombre}\n\t Precio: {Precio}\n\t PrecioUnidad: {PrecioUnidad}\n\t Descripcion: {Descripcion}\n\t Calorias: {Calorias}\n\t Grasa: {Grasa} \n\t Azucar: {Azucar}";
    }



}
