using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniMarket.Entidades;
using MiniMarket.Negocio;

namespace MiniMarket.Presentacion {
  public partial class FrmCategorias : Form {
    public FrmCategorias() {
      InitializeComponent();
    }

    #region "Mis variables"
    int estadoGuardar = 0; //Sin Ninguna Accion
    int idCategoria = 0;
    #endregion

    #region "Mis metodos"

    private void FormatoCategorias() {
      dgvPrincipal.Columns[0].Width = 100;
      dgvPrincipal.Columns[0].HeaderText = "ID";
      dgvPrincipal.Columns[1].Width = 300;
      dgvPrincipal.Columns[1].HeaderText = "CATEGORIA";
    }

    private void ListadoCategorias(string id) {
      try {
        dgvPrincipal.DataSource = CategoriasN.ListadoCategorias(id);
        this.FormatoCategorias();
      } catch (Exception ex) {
        MessageBox.Show(ex.Message + ex.StackTrace);
      }
    }

    private void EstadoBotonesPrincipales(bool estado) {
      this.btnNuevo.Enabled = estado;
      this.btnActualizar.Enabled = estado;
      this.btnEliminar.Enabled = estado;
      this.btnReporte.Enabled = estado;
      this.btnSalir.Enabled = estado;
    }

    private void EstadoBotonesProcesos(bool estado) {
      this.btnCancelar.Visible = estado;
      this.btnGuardar.Visible = estado;
      this.btnRetornar.Visible = !estado;
    }

    private void SeleccionaItem() {
      if (string.IsNullOrEmpty(Convert.ToString(dgvPrincipal.CurrentRow.Cells["id_categoria"].Value))) {
        MessageBox.Show("No se tiene información para visualizar", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
      } else {
        this.idCategoria = Convert.ToInt32(dgvPrincipal.CurrentRow.Cells["id_categoria"].Value);
        txtCategoria.Text = Convert.ToString(dgvPrincipal.CurrentRow.Cells["descripcion"].Value);
      }
    }

    #endregion

    private void Categorias_Load(object sender, EventArgs e) {
      this.ListadoCategorias("%");
    }

    private void btnGuardar_Click(object sender, EventArgs e) {
      if (txtCategoria.Text == string.Empty) {
        MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
      } else {
        string respuesta = "";
        Categorias categorias = new Categorias();
        categorias.IdCategoria = this.idCategoria;
        categorias.Descripcion = txtCategoria.Text.Trim();
        respuesta = CategoriasN.GuardarCategoria(estadoGuardar, categorias);
        if (respuesta == "OK") {
          this.ListadoCategorias("%");
          MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
          estadoGuardar = 0; //Sin Ninguna Accion
          this.EstadoBotonesPrincipales(true);
          this.EstadoBotonesProcesos(false);
          this.txtCategoria.Text = "";
          txtCategoria.ReadOnly = true;
          tbpPrincipal.SelectedIndex = 0;
          this.idCategoria = 0;
        } else {
          MessageBox.Show(respuesta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void btnNuevo_Click(object sender, EventArgs e) {
      estadoGuardar = 1; //Nuevo Registro
      this.EstadoBotonesPrincipales(false);
      this.EstadoBotonesProcesos(true);
      txtCategoria.Text = "";
      txtCategoria.ReadOnly = false;
      tbpPrincipal.SelectedIndex = 1;
      txtCategoria.Focus();
    }

    private void btnActualizar_Click(object sender, EventArgs e) {
      estadoGuardar = 2; //Actualizar Registro
      this.EstadoBotonesPrincipales(false);
      this.EstadoBotonesProcesos(true);
      this.SeleccionaItem();
      tbpPrincipal.SelectedIndex = 1;
      txtCategoria.ReadOnly = false;
      txtCategoria.Focus();
    }

    private void btnCancelar_Click(object sender, EventArgs e) {
      estadoGuardar = 0; //Sin Ninguna Accion
      txtCategoria.Text = "";
      txtCategoria.ReadOnly = true;
      this.EstadoBotonesPrincipales(true);
      this.EstadoBotonesProcesos(false);
      tbpPrincipal.SelectedIndex = 0;
    }

    private void dgvPrincipal_DoubleClick(object sender, EventArgs e) {
      this.SeleccionaItem();
      this.EstadoBotonesProcesos(false);
      tbpPrincipal.SelectedIndex = 1;
    }

    private void btnRetornar_Click(object sender, EventArgs e) {
      this.EstadoBotonesProcesos(false);
      tbpPrincipal.SelectedIndex = 0;
    }
  }
}
