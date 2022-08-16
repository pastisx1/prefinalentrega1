using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace prefinalentrega1.ADO
{
    public class VentaHandler : DbHandler
    {
        public static List<Venta> GetVentas(int id)
        {
            List<Venta> ventas = new List<Venta>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.Connection.Open();
                    sqlCommand.CommandText = "select * from Venta where IdUsuario = @idUsuario;";

                    sqlCommand.Parameters.AddWithValue("@idUsuario", id);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = sqlCommand;
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    sqlCommand.Connection.Close();
                    foreach (DataRow row in table.Rows)
                    {
                        Venta producto = new Venta();
                        Venta.Id = Convert.ToInt32(row["Id"]);
                        venta.Comentarios = row["Comentarios"]?.ToString();
                        ventas.IdUsuario = Convert.ToInt32(row["IdUsuario"]);
                        ventas.Add(venta);
                    }
                    sqlCommand.Connection.Close();
                }
            }

            return ventas;
        }
    }
    

}

