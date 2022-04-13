using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoPrincipal : Producto
    {

        public ProductoPrincipal()
        {
        }

        public ProductoPrincipal(string material, string color)
        {
            this.Material = material;
            this.Color = color;
        }




        public string Material { get; set; }
        public string Color { get; set; }

        public string DescripcionCompleta => Material + " - " + Color;



        // pisar el metodo virtual del padre
        public override string MostrarCategoria()
        {

            return "Producto Principal";
        }

    }
}
