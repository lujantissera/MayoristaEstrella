using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Diagnostics;

namespace PruebaExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
           // Ejemplo1();
            // Ejemplo2();
           // Ejemplo3();
             Ejemplo4();
        }
        public static void Ejemplo1()
        {
            // Ejemplo 1 - Try catch
            try
            {
                Console.WriteLine("try");
                throw new Exception("Mi excepción"); // Dispara la excepcion
            }
            catch
            {
                Console.WriteLine("catch atrapa la excepción");
            }
            finally
            {
                Console.WriteLine("finally se ejecuta siempre");
            }
            Console.ReadKey();
        }
        public static void Ejemplo2()
        {
            // Ejemplo 2
            try
            {
                Console.WriteLine("try");
                throw new Exception("Mi excepción");

            }
            catch (Exception e)
            {
                Console.WriteLine("catch");
                Console.WriteLine("Excepción detectada: " + e.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.ReadKey();
        }
        public static void Ejemplo3()
        {
            int numerador = 10;
            Console.WriteLine("Numerador es = {0}", numerador);
            Console.Write("Denominador = ");
            string strDen = Console.ReadLine();
            int denominador, cociente;
            // Trata de hacer una división
            try
            {
                Console.WriteLine("--> try");
                denominador = Convert.ToInt16(strDen);
                cociente = numerador / denominador;
                Console.WriteLine("Cociente = {0}", cociente);

                throw new MiException(DateTime.Now, "Hugo");

            }
            // Atrapa excepción OverflowException
            catch (OverflowException e)
            {
                Console.WriteLine("--> catch");
                Console.WriteLine("Excepción de argumento muy grande");
                Console.WriteLine("ArgumentNullException Handler: {0}",
                e.ToString());
            }
            //Atrapa excepción ArithmeticException
            catch (ArithmeticException e)
            {
                Console.WriteLine("--> catch");
                Console.WriteLine("Excepción aritmética");
                Console.WriteLine("ArithmeticException Handler: {0}",
                e.ToString());
            }

            catch (MiException e)
            {
                Console.WriteLine("--> catch");
                Console.WriteLine("Mi excepcion");
                Console.WriteLine("Exception personalizad usuario: {0} , fecha {1} , mensaje {2}",
                e.UsuarioLogueado, e.FechaError, e.Message);
            }

            // Atrapa excepción General
            catch (Exception e)
            {
                Console.WriteLine("--> catch");
                Console.WriteLine("Excepción de argumento generico");
                Console.WriteLine("generic Handler: {0}",
                e.ToString());
            }
            finally
            {
                Console.WriteLine("--> finally");
            }
            Console.ReadLine();
        }
        public static void Ejemplo4()
        {
            int numerador = 10;
            Console.WriteLine("Numerador es = {0}", numerador);
            Console.Write("Denominador = ");
            string strDen = Console.ReadLine();
            int denominador, cociente;
            try
            {
                Console.WriteLine("--> try");
                denominador = Convert.ToInt16(strDen);
                cociente = numerador / denominador;
                Console.WriteLine("Cociente = {0}", cociente);
            }
            catch (Exception e)
            {
                Console.WriteLine("--> catch");
                Console.WriteLine("Generic Handler: {0}", e.ToString());
                Console.WriteLine();
                StackTrace st = new StackTrace(e, true);
                Console.WriteLine("Traza de la pila:");
                for (int i = 0; i < st.FrameCount; i++)
                {
                    StackFrame sf = st.GetFrame(i);
                    Console.WriteLine(" Pila de llamadas, Método: {0}",
                    sf.GetMethod());
                    Console.WriteLine(" Pila de llamadas, Línea : {0}",
                    sf.GetFileLineNumber());
                }
                Console.WriteLine();
            }
            finally
            {
                Console.WriteLine("--> finally");
            }
            Console.ReadLine();

        }
    }
}
