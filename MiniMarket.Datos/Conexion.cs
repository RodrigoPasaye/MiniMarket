using System;
using System.Data.SqlClient;

namespace MiniMarket.Datos {
  public class Conexion {
    private string BD { get; set; }
    private string Servidor { get; set; }
    private string Usuario { get; set; }
    private string Password { get; set; }
    private bool Seguridad { get; set; }
    private static Conexion Con = null;

    private Conexion() {
      this.BD = "DB_MINIMARKET";
      this.Servidor = "DESKTOP-Q43GDQM\\SQLEXPRESS";
      this.Usuario = "sa";
      this.Password = "Abcde1";
      this.Seguridad = false;
    }

    public SqlConnection CrearConexion() {
      SqlConnection cadena = new SqlConnection();
      try {
        cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.BD + ";";
        if (Seguridad) {
          cadena.ConnectionString += "Integrated Security = SSPI";
        } else {
          cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.Usuario + "; Password=" + this.Password;
        }
      } catch (Exception ex) {
        cadena = null;
        throw ex;
      }
      return cadena;
    }

    public static Conexion GetInstancia() {
      if (Con == null) {
        Con = new Conexion();
      }
      return Con;
    }
  }
}
