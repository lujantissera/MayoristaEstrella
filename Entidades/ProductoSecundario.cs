using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoSecundario : Producto
    {
        public ProductoSecundario(int pId, string pDescripcion, decimal pPrecio)
        :base(pId, pDescripcion,pPrecio)
        {
            // base.Id = pId;
            //base.Descripcion = pDescripcion;
            //base.Precio = pPrecio;

            this.AltoEnMetros = 100;
            this.AnchoEnMetros = 3;
        }


        public decimal AltoEnMetros { get; set; }
        public decimal AnchoEnMetros { get; set; }


        // extender el metodo virtual del pabre
        public override string MostrarCategoria()
        {

            return  "Categoria de la base: " + base.MostrarCategoria() + " Producto Secundario";
        }


    }
}
