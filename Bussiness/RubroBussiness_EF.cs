using ObjetosDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bussiness
{
    public static class RubroBussiness_EF
    {
        //Listar la lista de rubros de la pagina indicada con ítems x pagina.
        public static List<Rubro> ListRubros(int pagina, int cantItemsXPagina)
        {
            var res = new List<Rubro>();
            //Aquí vendría cualquier lógica adicional que quisiéramos agregar
            res = DAL.RubroDAL_EF.ListRubros(pagina, cantItemsXPagina);
            return res;
        }

        //Obtener un rubro por ID
        public static Rubro GetRubro(int rubroId)
        {
            Rubro res = null;
            //Aquí vendría cualquier lógica adicional que quisiéramos agregar
            res = DAL.RubroDAL_EF.GetRubro(rubroId);
            return res;
        }
        //Eliminar un rubro con solo el ID
        public static int DeleteRubro(int rubroId)
        {
            var res = 0;
            //Aquí vendría cualquier lógica adicional que quisiéramos agregar
            res = DAL.RubroDAL_EF.DeleteRubro(rubroId);
            return res;
        }

        //Actualizar rubro existente
        public static int UpdateRubro(Rubro rubroAActualizar)
        {
            var res = 0;
            //Aquí vendría cualquier lógica adicional que quisiéramos agregar
            res = DAL.RubroDAL_EF.UpdateRubro(rubroAActualizar);
            return res;
        }
        //Agregar nuevo Rubro
        public static int InsertRubro(Rubro rubroAInsertar)
        {
            var res = 0;
            //Aquí vendría cualquier lógica adicional que quisiéramos agregar
            res = DAL.RubroDAL_EF.InsertRubro(rubroAInsertar);
            return res;
        }


    }
}
