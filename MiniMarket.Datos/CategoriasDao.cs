using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MiniMarket.Entidades;

namespace MiniMarket.Datos {
  public class CategoriasDao {
    public DataTable ListadoCategorias(string id) {
      SqlDataReader sqlDataReader;
      DataTable dataTable = new DataTable();
      SqlConnection connection = new SqlConnection();

      try {
        connection = Conexion.GetInstancia().CrearConexion();
        SqlCommand command = new SqlCommand("SP_OBTENER_CATEGORIAS", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("@texto", SqlDbType.VarChar).Value = id;
        connection.Open();
        sqlDataReader = command.ExecuteReader();
        dataTable.Load(sqlDataReader);
        return dataTable;
      } catch (Exception ex) {
        throw ex;
      } finally {
        if (connection.State == ConnectionState.Open) {
          connection.Close();
        }
      }
    }

    public string GuardarCategoria(int opcion, Categorias categorias) {
      string respuesta = "";
      SqlConnection connection = new SqlConnection();
      try {
        connection = Conexion.GetInstancia().CrearConexion();
        SqlCommand command = new SqlCommand("SP_INSERTUALIZA_CATEGORIA", connection);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("@opcion", SqlDbType.Int).Value = opcion;
        command.Parameters.Add("@id_categoria", SqlDbType.Int).Value = categorias.IdCategoria;
        command.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = categorias.Descripcion;
        connection.Open();
        respuesta = command.ExecuteNonQuery() == 1 ? "OK" : "Error. No se pudo registrar los datos";
      } catch (Exception ex) {
        respuesta = ex.Message;
      } finally {
        if (connection.State == ConnectionState.Open) {
          connection.Close();
        }
      }
      return respuesta;
    }
  }
}
