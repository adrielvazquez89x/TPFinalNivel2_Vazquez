namespace presentacion
{
    partial class frmListadoArticulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListadoArticulos = new System.Windows.Forms.DataGridView();
            this.pbxImagenArticulo = new System.Windows.Forms.PictureBox();
            this.btnNuevoArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblListadoFabricante = new System.Windows.Forms.Label();
            this.lblListadoModelo = new System.Windows.Forms.Label();
            this.lblListadoPrecio = new System.Windows.Forms.Label();
            this.lblListadoArticulo = new System.Windows.Forms.Label();
            this.lblListadoModeloArticulo = new System.Windows.Forms.Label();
            this.frmListadoPrecioArticulo = new System.Windows.Forms.Label();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegistrosEliminados = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelMenuDerecho = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelFiltros = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).BeginInit();
            this.panelMenuDerecho.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListadoArticulos
            // 
            this.dgvListadoArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.dgvListadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.dgvListadoArticulos.Location = new System.Drawing.Point(25, 29);
            this.dgvListadoArticulos.Name = "dgvListadoArticulos";
            this.dgvListadoArticulos.Size = new System.Drawing.Size(803, 174);
            this.dgvListadoArticulos.TabIndex = 0;
            this.dgvListadoArticulos.SelectionChanged += new System.EventHandler(this.dgvListadoArticulos_SelectionChanged);
            // 
            // pbxImagenArticulo
            // 
            this.pbxImagenArticulo.Location = new System.Drawing.Point(25, 368);
            this.pbxImagenArticulo.Name = "pbxImagenArticulo";
            this.pbxImagenArticulo.Size = new System.Drawing.Size(389, 396);
            this.pbxImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenArticulo.TabIndex = 1;
            this.pbxImagenArticulo.TabStop = false;
            // 
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.FlatAppearance.BorderSize = 0;
            this.btnNuevoArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(138)))), ((int)(((byte)(36)))));
            this.btnNuevoArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnNuevoArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoArticulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNuevoArticulo.Location = new System.Drawing.Point(0, 101);
            this.btnNuevoArticulo.Name = "btnNuevoArticulo";
            this.btnNuevoArticulo.Size = new System.Drawing.Size(200, 45);
            this.btnNuevoArticulo.TabIndex = 2;
            this.btnNuevoArticulo.Text = "Nuevo Artículo";
            this.btnNuevoArticulo.UseVisualStyleBackColor = true;
            this.btnNuevoArticulo.Click += new System.EventHandler(this.btnNuevoArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.FlatAppearance.BorderSize = 0;
            this.btnModificarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(138)))), ((int)(((byte)(36)))));
            this.btnModificarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnModificarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArticulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarArticulo.Location = new System.Drawing.Point(0, 148);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(197, 45);
            this.btnModificarArticulo.TabIndex = 3;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(138)))), ((int)(((byte)(36)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(0, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblListadoFabricante
            // 
            this.lblListadoFabricante.AutoSize = true;
            this.lblListadoFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoFabricante.Location = new System.Drawing.Point(458, 463);
            this.lblListadoFabricante.Name = "lblListadoFabricante";
            this.lblListadoFabricante.Size = new System.Drawing.Size(120, 25);
            this.lblListadoFabricante.TabIndex = 5;
            this.lblListadoFabricante.Text = "Fabricante:";
            // 
            // lblListadoModelo
            // 
            this.lblListadoModelo.AutoSize = true;
            this.lblListadoModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoModelo.Location = new System.Drawing.Point(489, 502);
            this.lblListadoModelo.Name = "lblListadoModelo";
            this.lblListadoModelo.Size = new System.Drawing.Size(89, 25);
            this.lblListadoModelo.TabIndex = 6;
            this.lblListadoModelo.Text = "Modelo:";
            // 
            // lblListadoPrecio
            // 
            this.lblListadoPrecio.AutoSize = true;
            this.lblListadoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoPrecio.Location = new System.Drawing.Point(499, 541);
            this.lblListadoPrecio.Name = "lblListadoPrecio";
            this.lblListadoPrecio.Size = new System.Drawing.Size(79, 25);
            this.lblListadoPrecio.TabIndex = 7;
            this.lblListadoPrecio.Text = "Precio:";
            // 
            // lblListadoArticulo
            // 
            this.lblListadoArticulo.AutoSize = true;
            this.lblListadoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoArticulo.Location = new System.Drawing.Point(584, 463);
            this.lblListadoArticulo.Name = "lblListadoArticulo";
            this.lblListadoArticulo.Size = new System.Drawing.Size(136, 24);
            this.lblListadoArticulo.TabIndex = 8;
            this.lblListadoArticulo.Text = "Nombre Marca";
            // 
            // lblListadoModeloArticulo
            // 
            this.lblListadoModeloArticulo.AutoSize = true;
            this.lblListadoModeloArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoModeloArticulo.Location = new System.Drawing.Point(584, 503);
            this.lblListadoModeloArticulo.Name = "lblListadoModeloArticulo";
            this.lblListadoModeloArticulo.Size = new System.Drawing.Size(148, 24);
            this.lblListadoModeloArticulo.TabIndex = 9;
            this.lblListadoModeloArticulo.Text = "Nombre Modelo";
            // 
            // frmListadoPrecioArticulo
            // 
            this.frmListadoPrecioArticulo.AutoSize = true;
            this.frmListadoPrecioArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmListadoPrecioArticulo.Location = new System.Drawing.Point(584, 541);
            this.frmListadoPrecioArticulo.Name = "frmListadoPrecioArticulo";
            this.frmListadoPrecioArticulo.Size = new System.Drawing.Size(133, 24);
            this.frmListadoPrecioArticulo.TabIndex = 10;
            this.frmListadoPrecioArticulo.Text = "Precio Modelo";
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(206)))), ((int)(((byte)(172)))));
            this.btnVerDetalle.FlatAppearance.BorderSize = 0;
            this.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalle.Location = new System.Drawing.Point(533, 598);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(155, 35);
            this.btnVerDetalle.TabIndex = 11;
            this.btnVerDetalle.Text = "Ver detalles";
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltro.Location = new System.Drawing.Point(35, 15);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(46, 16);
            this.lblFiltro.TabIndex = 12;
            this.lblFiltro.Text = "Filtrar: ";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(87, 14);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(170, 20);
            this.txtFiltro.TabIndex = 13;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCampo.Location = new System.Drawing.Point(22, 65);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(51, 16);
            this.lblCampo.TabIndex = 14;
            this.lblCampo.Text = "Campo";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(87, 63);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 15;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(288, 63);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 17;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCriterio.Location = new System.Drawing.Point(222, 65);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(52, 16);
            this.lblCriterio.TabIndex = 16;
            this.lblCriterio.Text = "Criterio:";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(537, 63);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(126, 20);
            this.txtFiltroAvanzado.TabIndex = 18;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(423, 65);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(103, 16);
            this.lblFiltroAvanzado.TabIndex = 19;
            this.lblFiltroAvanzado.Text = "Filtro Avanzado:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(206)))), ((int)(((byte)(172)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(677, 62);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRegistrosEliminados
            // 
            this.btnRegistrosEliminados.FlatAppearance.BorderSize = 0;
            this.btnRegistrosEliminados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(138)))), ((int)(((byte)(36)))));
            this.btnRegistrosEliminados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnRegistrosEliminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrosEliminados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrosEliminados.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrosEliminados.Location = new System.Drawing.Point(0, 238);
            this.btnRegistrosEliminados.Name = "btnRegistrosEliminados";
            this.btnRegistrosEliminados.Size = new System.Drawing.Size(200, 45);
            this.btnRegistrosEliminados.TabIndex = 21;
            this.btnRegistrosEliminados.Text = "Registros Eliminados";
            this.btnRegistrosEliminados.UseVisualStyleBackColor = true;
            this.btnRegistrosEliminados.Click += new System.EventHandler(this.btnRegistrosEliminados_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(3)))), ((int)(((byte)(46)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrar.Location = new System.Drawing.Point(74, 29);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 34);
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelMenuDerecho
            // 
            this.panelMenuDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.panelMenuDerecho.Controls.Add(this.panel2);
            this.panelMenuDerecho.Controls.Add(this.btnRegistrosEliminados);
            this.panelMenuDerecho.Controls.Add(this.btnNuevoArticulo);
            this.panelMenuDerecho.Controls.Add(this.btnModificarArticulo);
            this.panelMenuDerecho.Controls.Add(this.button1);
            this.panelMenuDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuDerecho.Location = new System.Drawing.Point(850, 0);
            this.panelMenuDerecho.Name = "panelMenuDerecho";
            this.panelMenuDerecho.Size = new System.Drawing.Size(200, 800);
            this.panelMenuDerecho.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(70)))));
            this.panelFiltros.Controls.Add(this.lblFiltro);
            this.panelFiltros.Controls.Add(this.btnBuscar);
            this.panelFiltros.Controls.Add(this.txtFiltro);
            this.panelFiltros.Controls.Add(this.lblFiltroAvanzado);
            this.panelFiltros.Controls.Add(this.cboCampo);
            this.panelFiltros.Controls.Add(this.txtFiltroAvanzado);
            this.panelFiltros.Controls.Add(this.lblCampo);
            this.panelFiltros.Controls.Add(this.cboCriterio);
            this.panelFiltros.Controls.Add(this.lblCriterio);
            this.panelFiltros.Location = new System.Drawing.Point(25, 238);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(803, 108);
            this.panelFiltros.TabIndex = 24;
            // 
            // frmListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1050, 800);
            this.ControlBox = false;
            this.Controls.Add(this.panelMenuDerecho);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.frmListadoPrecioArticulo);
            this.Controls.Add(this.lblListadoModeloArticulo);
            this.Controls.Add(this.lblListadoArticulo);
            this.Controls.Add(this.lblListadoPrecio);
            this.Controls.Add(this.lblListadoModelo);
            this.Controls.Add(this.lblListadoFabricante);
            this.Controls.Add(this.pbxImagenArticulo);
            this.Controls.Add(this.dgvListadoArticulos);
            this.Controls.Add(this.panelFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmListadoArticulos";
            this.Load += new System.EventHandler(this.frmListadoArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).EndInit();
            this.panelMenuDerecho.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoArticulos;
        private System.Windows.Forms.PictureBox pbxImagenArticulo;
        private System.Windows.Forms.Button btnNuevoArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblListadoFabricante;
        private System.Windows.Forms.Label lblListadoModelo;
        private System.Windows.Forms.Label lblListadoPrecio;
        private System.Windows.Forms.Label lblListadoArticulo;
        private System.Windows.Forms.Label lblListadoModeloArticulo;
        private System.Windows.Forms.Label frmListadoPrecioArticulo;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegistrosEliminados;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelMenuDerecho;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelFiltros;
    }
}