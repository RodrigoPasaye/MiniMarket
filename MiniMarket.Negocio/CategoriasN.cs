﻿using System;
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
    public static DataTable ListadoCategorias(string texto) {
      CategoriasDao categoriasDao = new CategoriasDao();
      return categoriasDao.ListadoCategorias(texto);
    }

    public static string GuardarCategoria(int opcion, Categorias categorias) {
      CategoriasDao categoriasDao = new CategoriasDao();
      return categoriasDao.GuardarCategoria(opcion, categorias);
    }

    public static string EliminarCategoria(int idcategoria) {
      CategoriasDao categoriasDao = new CategoriasDao();
      return categoriasDao.EliminarCategoria(idcategoria);
    }
  }
}
