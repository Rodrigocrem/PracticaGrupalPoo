using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MquinaDeVending
{
    internal class Produc_MaterialesPreciosos:Product_General
    {
        public string Material {  get; set; }
        public int Peso {  get; set; }

        public Produc_MaterialesPreciosos() { }

        public Produc_MaterialesPreciosos( public Product_Alimentos(int id, string nombre, double precio, int precioUnidad, string descripcion, int peso, string material )
        : base(id, nombre, precio, precioUnidad, descripcion, material, peso)
        {
            Material = material;
            Peso = peso;
        }
        public override string ObtenerInforamcionProducto()
        {
           
        }

    }
}
