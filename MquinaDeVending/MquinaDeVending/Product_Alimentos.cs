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
        return $"({Id}) Titulo: {Titulo}\n\t Año: {Anio}\n\tGénero: {Genero}" + $"\n\tDirector: {Director}\n\tDuración: {Duracion} minutos" + $"\n\tNarrador: {Narrador}\n\tTema: {Tema}";
    }



}
