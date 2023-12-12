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
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoArticulos
            // 
            this.dgvListadoArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoArticulos.Location = new System.Drawing.Point(12, 31);
            this.dgvListadoArticulos.Name = "dgvListadoArticulos";
            this.dgvListadoArticulos.Size = new System.Drawing.Size(803, 174);
            this.dgvListadoArticulos.TabIndex = 0;
            this.dgvListadoArticulos.SelectionChanged += new System.EventHandler(this.dgvListadoArticulos_SelectionChanged);
            // 
            // pbxImagenArticulo
            // 
            this.pbxImagenArticulo.Location = new System.Drawing.Point(125, 323);
            this.pbxImagenArticulo.Name = "pbxImagenArticulo";
            this.pbxImagenArticulo.Size = new System.Drawing.Size(389, 396);
            this.pbxImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenArticulo.TabIndex = 1;
            this.pbxImagenArticulo.TabStop = false;
            // 
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.Location = new System.Drawing.Point(834, 61);
            this.btnNuevoArticulo.Name = "btnNuevoArticulo";
            this.btnNuevoArticulo.Size = new System.Drawing.Size(155, 23);
            this.btnNuevoArticulo.TabIndex = 2;
            this.btnNuevoArticulo.Text = "Nuevo Artículo";
            this.btnNuevoArticulo.UseVisualStyleBackColor = true;
            this.btnNuevoArticulo.Click += new System.EventHandler(this.btnNuevoArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Location = new System.Drawing.Point(834, 99);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(155, 23);
            this.btnModificarArticulo.TabIndex = 3;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(834, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblListadoFabricante
            // 
            this.lblListadoFabricante.AutoSize = true;
            this.lblListadoFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoFabricante.Location = new System.Drawing.Point(566, 347);
            this.lblListadoFabricante.Name = "lblListadoFabricante";
            this.lblListadoFabricante.Size = new System.Drawing.Size(120, 25);
            this.lblListadoFabricante.TabIndex = 5;
            this.lblListadoFabricante.Text = "Fabricante:";
            // 
            // lblListadoModelo
            // 
            this.lblListadoModelo.AutoSize = true;
            this.lblListadoModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoModelo.Location = new System.Drawing.Point(597, 386);
            this.lblListadoModelo.Name = "lblListadoModelo";
            this.lblListadoModelo.Size = new System.Drawing.Size(89, 25);
            this.lblListadoModelo.TabIndex = 6;
            this.lblListadoModelo.Text = "Modelo:";
            // 
            // lblListadoPrecio
            // 
            this.lblListadoPrecio.AutoSize = true;
            this.lblListadoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoPrecio.Location = new System.Drawing.Point(607, 425);
            this.lblListadoPrecio.Name = "lblListadoPrecio";
            this.lblListadoPrecio.Size = new System.Drawing.Size(79, 25);
            this.lblListadoPrecio.TabIndex = 7;
            this.lblListadoPrecio.Text = "Precio:";
            // 
            // lblListadoArticulo
            // 
            this.lblListadoArticulo.AutoSize = true;
            this.lblListadoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoArticulo.Location = new System.Drawing.Point(692, 347);
            this.lblListadoArticulo.Name = "lblListadoArticulo";
            this.lblListadoArticulo.Size = new System.Drawing.Size(136, 24);
            this.lblListadoArticulo.TabIndex = 8;
            this.lblListadoArticulo.Text = "Nombre Marca";
            // 
            // lblListadoModeloArticulo
            // 
            this.lblListadoModeloArticulo.AutoSize = true;
            this.lblListadoModeloArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoModeloArticulo.Location = new System.Drawing.Point(692, 387);
            this.lblListadoModeloArticulo.Name = "lblListadoModeloArticulo";
            this.lblListadoModeloArticulo.Size = new System.Drawing.Size(148, 24);
            this.lblListadoModeloArticulo.TabIndex = 9;
            this.lblListadoModeloArticulo.Text = "Nombre Modelo";
            // 
            // frmListadoPrecioArticulo
            // 
            this.frmListadoPrecioArticulo.AutoSize = true;
            this.frmListadoPrecioArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmListadoPrecioArticulo.Location = new System.Drawing.Point(692, 425);
            this.frmListadoPrecioArticulo.Name = "frmListadoPrecioArticulo";
            this.frmListadoPrecioArticulo.Size = new System.Drawing.Size(133, 24);
            this.frmListadoPrecioArticulo.TabIndex = 10;
            this.frmListadoPrecioArticulo.Text = "Precio Modelo";
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Location = new System.Drawing.Point(641, 482);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(155, 23);
            this.btnVerDetalle.TabIndex = 11;
            this.btnVerDetalle.Text = "Ver detalles";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(17, 224);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(46, 16);
            this.lblFiltro.TabIndex = 12;
            this.lblFiltro.Text = "Filtrar: ";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(69, 223);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(170, 20);
            this.txtFiltro.TabIndex = 13;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(17, 265);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(51, 16);
            this.lblCampo.TabIndex = 14;
            this.lblCampo.Text = "Campo";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(82, 263);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 15;
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(283, 263);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 17;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(217, 265);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(52, 16);
            this.lblCriterio.TabIndex = 16;
            this.lblCriterio.Text = "Criterio:";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(532, 263);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(126, 20);
            this.txtFiltroAvanzado.TabIndex = 18;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(418, 265);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(103, 16);
            this.lblFiltroAvanzado.TabIndex = 19;
            this.lblFiltroAvanzado.Text = "Filtro Avanzado:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(672, 262);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 790);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.frmListadoPrecioArticulo);
            this.Controls.Add(this.lblListadoModeloArticulo);
            this.Controls.Add(this.lblListadoArticulo);
            this.Controls.Add(this.lblListadoPrecio);
            this.Controls.Add(this.lblListadoModelo);
            this.Controls.Add(this.lblListadoFabricante);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnNuevoArticulo);
            this.Controls.Add(this.pbxImagenArticulo);
            this.Controls.Add(this.dgvListadoArticulos);
            this.Name = "frmListadoArticulos";
            this.Text = "frmListadoArticulos";
            this.Load += new System.EventHandler(this.frmListadoArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).EndInit();
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
    }
}