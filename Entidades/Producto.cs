using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public Producto()
        {
            this.Id = 1;
            this.Descripcion = "PrimerProducto";
            this.Precio = 200;
        }
        public Producto(int pId, string pDescripcion, decimal pPrecio)
        {
            this.Id = pId;
            this.Descripcion = pDescripcion;
            this.Precio = pPrecio;
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string propiedad { get; set; }
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }


        private decimal _precio;

        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }


        public Producto MostrarProducto()
        {
            this._id = 1;
            this.Descripcion = "Primer Producto";
            return this;
        }

        public Producto MostrarProducto(int pId, string pDescripcion , decimal pPrecio)
        {
            this._id = pId;
            this.Descripcion = pDescripcion;
            this.Precio = pPrecio;

            return this;
        }


        public virtual string MostrarCategoria()
        {
            return "Producto Generico";
        }

        public const string categoriaA = "A";
        public const int stockMinimo = 1000;

        // campo 
        public string CodBarras;

        // campo de solo lectura
        public static readonly double Iva = 0.21;


    }
}
