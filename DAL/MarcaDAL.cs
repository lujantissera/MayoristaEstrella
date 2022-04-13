using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public  class MarcaDAL
    {
        public int Insertar(string connectionString, Marca marca)
        {
            string sCon = connectionString;
            string sel;
            sel = "INSERT INTO Marca" +
            "(DescripcionMarca) " +
            "VALUES " + "(@DescripcionMarca) " +
       "SELECT @@Identity";
            using (SqlConnection con = new SqlConnection(sCon))
            {
                SqlCommand cmd = new SqlCommand(sel, con);
                cmd.Parameters.AddWithValue("@DescripcionMarca", marca.DescripcionMarca);
                con.Open();
                int t = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return t;
            }
        }

        public int InsertarAdapter(string connectionString, Marca marca)
        {
            string sCon = connectionString;
            string sel;
            // Usando un DataAdapter
            sel = "SELECT * FROM Marca";
            SqlDataAdapter da = new SqlDataAdapter(sel, sCon);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["DescripcionMarca"] = marca.DescripcionMarca;

            dt.Rows.Add(dr);
            da.Update(dt);
            return Convert.ToInt32(dr["ID"]);
        }

    }
}
