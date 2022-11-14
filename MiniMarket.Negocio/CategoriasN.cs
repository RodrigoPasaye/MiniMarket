using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MiniMarket.Entidades;
using MiniMarket.Datos;

namespace MiniMarket.Negocio {
  public class CategoriasN {
    public static DataTable ListadoCategorias(string id) {
      CategoriasDao categoriasDao = new CategoriasDao();
      return categoriasDao.ListadoCategorias(id);
    }

    public static string GuardarCategoria(int opcion, Categorias categorias) {
      CategoriasDao categoriasDao = new CategoriasDao();
      return categoriasDao.GuardarCategoria(opcion, categorias);
    }
  }
}
