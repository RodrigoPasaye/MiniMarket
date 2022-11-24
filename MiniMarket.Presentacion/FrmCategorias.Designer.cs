namespace MiniMarket.Presentacion {
  partial class FrmCategorias {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.tbpPrincipal = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.dgvPrincipal = new System.Windows.Forms.DataGridView();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.txtBuscar = new System.Windows.Forms.TextBox();
      this.lblBuscar = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.btnRetornar = new System.Windows.Forms.Button();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.txtCategoria = new System.Windows.Forms.TextBox();
      this.lblCategoria = new System.Windows.Forms.Label();
      this.btnNuevo = new System.Windows.Forms.Button();
      this.btnActualizar = new System.Windows.Forms.Button();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.btnReporte = new System.Windows.Forms.Button();
      this.btnSalir = new System.Windows.Forms.Button();
      this.tbpPrincipal.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tbpPrincipal
      // 
      this.tbpPrincipal.Controls.Add(this.tabPage1);
      this.tbpPrincipal.Controls.Add(this.tabPage2);
      this.tbpPrincipal.Location = new System.Drawing.Point(11, 12);
      this.tbpPrincipal.Name = "tbpPrincipal";
      this.tbpPrincipal.SelectedIndex = 0;
      this.tbpPrincipal.Size = new System.Drawing.Size(740, 260);
      this.tbpPrincipal.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.dgvPrincipal);
      this.tabPage1.Controls.Add(this.btnBuscar);
      this.tabPage1.Controls.Add(this.txtBuscar);
      this.tabPage1.Controls.Add(this.lblBuscar);
      this.tabPage1.Location = new System.Drawing.Point(4, 25);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(732, 231);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Listado";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // dgvPrincipal
      // 
      this.dgvPrincipal.AllowUserToAddRows = false;
      this.dgvPrincipal.AllowUserToDeleteRows = false;
      this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPrincipal.Location = new System.Drawing.Point(9, 44);
      this.dgvPrincipal.Name = "dgvPrincipal";
      this.dgvPrincipal.ReadOnly = true;
      this.dgvPrincipal.RowHeadersWidth = 51;
      this.dgvPrincipal.RowTemplate.Height = 24;
      this.dgvPrincipal.Size = new System.Drawing.Size(610, 150);
      this.dgvPrincipal.TabIndex = 3;
      this.dgvPrincipal.DoubleClick += new System.EventHandler(this.dgvPrincipal_DoubleClick);
      // 
      // btnBuscar
      // 
      this.btnBuscar.Location = new System.Drawing.Point(326, 15);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(75, 23);
      this.btnBuscar.TabIndex = 2;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // txtBuscar
      // 
      this.txtBuscar.Location = new System.Drawing.Point(64, 16);
      this.txtBuscar.Name = "txtBuscar";
      this.txtBuscar.Size = new System.Drawing.Size(245, 22);
      this.txtBuscar.TabIndex = 1;
      // 
      // lblBuscar
      // 
      this.lblBuscar.AutoSize = true;
      this.lblBuscar.Location = new System.Drawing.Point(6, 19);
      this.lblBuscar.Name = "lblBuscar";
      this.lblBuscar.Size = new System.Drawing.Size(52, 16);
      this.lblBuscar.TabIndex = 0;
      this.lblBuscar.Text = "Buscar:";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.btnRetornar);
      this.tabPage2.Controls.Add(this.btnGuardar);
      this.tabPage2.Controls.Add(this.btnCancelar);
      this.tabPage2.Controls.Add(this.txtCategoria);
      this.tabPage2.Controls.Add(this.lblCategoria);
      this.tabPage2.Location = new System.Drawing.Point(4, 25);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(732, 231);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Mantenimiento";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // btnRetornar
      // 
      this.btnRetornar.Location = new System.Drawing.Point(337, 75);
      this.btnRetornar.Name = "btnRetornar";
      this.btnRetornar.Size = new System.Drawing.Size(81, 23);
      this.btnRetornar.TabIndex = 4;
      this.btnRetornar.Text = "Retornar";
      this.btnRetornar.UseVisualStyleBackColor = true;
      this.btnRetornar.Visible = false;
      this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
      // 
      // btnGuardar
      // 
      this.btnGuardar.Location = new System.Drawing.Point(237, 75);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(81, 23);
      this.btnGuardar.TabIndex = 3;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Visible = false;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // btnCancelar
      // 
      this.btnCancelar.Location = new System.Drawing.Point(128, 75);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(85, 23);
      this.btnCancelar.TabIndex = 2;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Visible = false;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // txtCategoria
      // 
      this.txtCategoria.Location = new System.Drawing.Point(123, 32);
      this.txtCategoria.Name = "txtCategoria";
      this.txtCategoria.ReadOnly = true;
      this.txtCategoria.Size = new System.Drawing.Size(281, 22);
      this.txtCategoria.TabIndex = 1;
      // 
      // lblCategoria
      // 
      this.lblCategoria.AutoSize = true;
      this.lblCategoria.Location = new System.Drawing.Point(26, 35);
      this.lblCategoria.Name = "lblCategoria";
      this.lblCategoria.Size = new System.Drawing.Size(85, 16);
      this.lblCategoria.TabIndex = 0;
      this.lblCategoria.Text = "Categoría: (*)";
      // 
      // btnNuevo
      // 
      this.btnNuevo.Location = new System.Drawing.Point(25, 290);
      this.btnNuevo.Name = "btnNuevo";
      this.btnNuevo.Size = new System.Drawing.Size(86, 51);
      this.btnNuevo.TabIndex = 1;
      this.btnNuevo.Text = "Nuevo";
      this.btnNuevo.UseVisualStyleBackColor = true;
      this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
      // 
      // btnActualizar
      // 
      this.btnActualizar.Location = new System.Drawing.Point(126, 290);
      this.btnActualizar.Name = "btnActualizar";
      this.btnActualizar.Size = new System.Drawing.Size(86, 51);
      this.btnActualizar.TabIndex = 2;
      this.btnActualizar.Text = "Actualizar";
      this.btnActualizar.UseVisualStyleBackColor = true;
      this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
      // 
      // btnEliminar
      // 
      this.btnEliminar.Location = new System.Drawing.Point(230, 290);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(86, 51);
      this.btnEliminar.TabIndex = 3;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
      // 
      // btnReporte
      // 
      this.btnReporte.Location = new System.Drawing.Point(333, 290);
      this.btnReporte.Name = "btnReporte";
      this.btnReporte.Size = new System.Drawing.Size(86, 51);
      this.btnReporte.TabIndex = 4;
      this.btnReporte.Text = "Reporte";
      this.btnReporte.UseVisualStyleBackColor = true;
      // 
      // btnSalir
      // 
      this.btnSalir.Location = new System.Drawing.Point(436, 290);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new System.Drawing.Size(86, 51);
      this.btnSalir.TabIndex = 5;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      // 
      // FrmCategorias
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(782, 353);
      this.Controls.Add(this.btnSalir);
      this.Controls.Add(this.btnReporte);
      this.Controls.Add(this.btnEliminar);
      this.Controls.Add(this.btnActualizar);
      this.Controls.Add(this.btnNuevo);
      this.Controls.Add(this.tbpPrincipal);
      this.Name = "FrmCategorias";
      this.Text = "Categorias";
      this.Load += new System.EventHandler(this.Categorias_Load);
      this.tbpPrincipal.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.TabControl tbpPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnRetornar;
    }
}