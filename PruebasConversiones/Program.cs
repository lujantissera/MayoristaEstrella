using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversionImplicita();
            ConversionImplicitaDerivada();
            ConversionExplicita();
            ConeversionExplicitaDerivada();
            ConversionBoxing();
            ConversionUnBoxing();
            ListaObjetosHeterogeneos();

            Console.ReadKey();
        }


        static void ConversionImplicita()
        {
            int NumeroCorto = 1234;
            long NumeroLargo = NumeroCorto;

            Console.WriteLine("Se convirtio el numero generado como Int: " + NumeroCorto +
                " a Long de manera implicita");
        }

        static void ConversionImplicitaDerivada()
        {
            ProductoPrincipal productoPrincipal = new ProductoPrincipal();
            productoPrincipal.Descripcion = "Producto Principal";
            Producto producto = productoPrincipal;

            Console.WriteLine("Se convirtio un objeto ProductoPrincipal a Producto Por conversion implicita");
            Console.WriteLine("Descripcion del Producto: " + producto.Descripcion);
        }


        static void ConversionExplicita()
        {
            double numeroDecimal = 1234.7;
            int numeroEntero;
            // Cast double a int.
            numeroEntero = (int)numeroDecimal;
            System.Console.WriteLine("Se convierte explicitamente a travez de Cast de tipos" +
                                     " de Double a Entero el siguiente numero: " + numeroEntero);
        }

        static void ConeversionExplicitaDerivada()
        {
            Producto ProductoBase = new Producto();
            ProductoBase.Descripcion = "Producto Base";

            try
            {
                ProductoPrincipal productoDerivado = (ProductoPrincipal)ProductoBase;
                Console.WriteLine("Se convirtio un objeto Producto  a  ProductoPrincipal  Por conversion Explicita");
                Console.WriteLine("Descripcion del Producto: " + productoDerivado.Descripcion);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Error al intentar realizar la conversion");
            }
        }

        static void ConversionBoxing()
        {
            int i = 123;
            object o = i; // Conversion Boxing de un tipo primitivo a un object

            Console.WriteLine("Se realiza una conversion implicita Boxing de un objeto entero a un objeto Object +" +
                              "del numero  " + i);

        }

        static void ConversionUnBoxing()
        {
            object objeto = 123;
            object numero = (int)objeto; // Unboxing

            Console.WriteLine("Se realiza una conversion explicita UnBoxing de un Object a un Entero " +
                              "del numero  " + numero);

        }

        static void ListaObjetosHeterogeneos()
        {
            List<object> listaObjetos = new List<object>();
            listaObjetos.Add("Primer Grupo:");
            for (int j = 1; j < 5; j++)
            {
                listaObjetos.Add(j);
            }
            listaObjetos.Add("Segundo Grupo:");
            for (int j = 5; j < 10; j++)
            {
                listaObjetos.Add(j);
            }
            foreach (var item in listaObjetos)
            {
                Console.WriteLine(item);
            }
            var sum = 0;
            for (var j = 1; j < 5; j++)
            {
                sum += (int)listaObjetos[j] * (int)listaObjetos[j];
            }
            Console.WriteLine("Sum: " + sum);
        }



    }
}
