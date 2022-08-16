﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace prefinalentrega1.ADO
{
    public class VentaHandler : DbHandler
    {
        public static List<ProductoVendido> GetProductosVendidos(int id)
        {
            List<ProductoVendido> listProductosVendidos = new List<ProductoVendido>();
            List<Producto> listProductos = ProductoHandler.GetProductos(id);

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {


                    foreach (Producto producto in listProductos)
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Connection.Open();
                        sqlCommand.CommandText = "select* from ProductoVendido where IdProducto = @idProducto";

                        sqlCommand.Parameters.AddWithValue("@idProducto", producto.Id);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter();
                        dataAdapter.SelectCommand = sqlCommand;
                        DataTable table = new DataTable();
                        dataAdapter.Fill(table); 
                        sqlCommand.Parameters.Clear();
                        
                        foreach (DataRow row in table.Rows)
                        {
                            ProductoVendido productoVendido = new ProductoVendido();
                            productoVendido.Id = Convert.ToInt32(row["Id"]);
                            productoVendido.Stock = Convert.ToInt32(row["Stock"]);
                            productoVendido.IdProducto = Convert.ToInt32(row["IdProducto"]);
                            productoVendido.IdVenta = Convert.ToInt32(row["IdVenta"]);

                            listProductosVendidos.Add(productoVendido);
                        }
                        sqlCommand.Connection.Close();
                    }

                }
            }
            return listProductosVendidos;
        }
    }


}

