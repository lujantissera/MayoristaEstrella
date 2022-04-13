using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetosDeNegocio;

namespace DAL
{
    public static class RubroDAL_EF
    {

        public static List<Rubro> ListRubros(int pagina, int cantItemsXPagina)
        {
            var res = new List<Rubro>();
            var contexto = new MayoristaEstrellaEntities();
            //Usando Linq ordenamos los datos: OrderBy(o=>o.DescripcionMarca)
            //saltamos las paginas que indiquemos: Skip((pagina) * cantItemsXPagina)
            //y tomamos la cantidad de ítems por página: Take(cantItemsXPagina
            res = contexto.Rubro.OrderBy(o => o.DescripcionRubro).Skip((pagina) *
            cantItemsXPagina).Take(cantItemsXPagina).ToList();
            return res;
        }
        //Obtener una Rubro por ID
        public static Rubro GetRubro(int rubroId)
        {
            Rubro res = null;

            var contexto = new MayoristaEstrellaEntities();
            res = contexto.Rubro.FirstOrDefault(x => x.IdRubro == rubroId);

            return res;
        }
        //Eliminar una Rubro con solo el ID
        public static int DeleteRubro(int rubroId)
        {
            var res = 0;
            var contexto = new MayoristaEstrellaEntities();
            var dato = contexto.Rubro.FirstOrDefault(x => x.IdRubro == rubroId);
            contexto.Rubro.Remove(dato);
            res = contexto.SaveChanges();
            return res;
        }
        //Actualizar rubro existente
        public static int UpdateRubro(Rubro RubroAActualizar)
        {
            var res = 0;
            var contexto = new MayoristaEstrellaEntities();
            var dato = contexto.Rubro.FirstOrDefault(e => e.IdRubro == RubroAActualizar.IdRubro);
            dato.DescripcionRubro = RubroAActualizar.DescripcionRubro;

            res = contexto.SaveChanges();
            return res;
        }

        //Agregar nueva rubro
        public static int InsertRubro(Rubro rubroAInsertar)
        {
            var res = 0;
            var contexto = new MayoristaEstrellaEntities();
            contexto.Rubro.Add(rubroAInsertar);
            res = contexto.SaveChanges();
            return res;
        }



    }
}
