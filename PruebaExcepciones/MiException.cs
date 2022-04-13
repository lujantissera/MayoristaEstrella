using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaExcepciones
{
    public class MiException : Exception
    {
        public DateTime FechaError { get; set; }
        public string UsuarioLogueado { get; set; }

        public MiException(DateTime Fecha, string Usuario)
            :base("Mi error personalizado")
        {
            FechaError = Fecha;
            UsuarioLogueado = Usuario;

        }

    }
}