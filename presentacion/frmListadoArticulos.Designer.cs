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
            this.pbxImagenArticulo.Location = new System.Drawing.Point(12, 211);
            this.pbxImagenArticulo.Name = "pbxImagenArticulo";
            this.pbxImagenArticulo.Size = new System.Drawing.Size(355, 528);
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(834, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblListadoFabricante
            // 
            this.lblListadoFabricante.AutoSize = true;
            this.lblListadoFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoFabricante.Location = new System.Drawing.Point(428, 294);
            this.lblListadoFabricante.Name = "lblListadoFabricante";
            this.lblListadoFabricante.Size = new System.Drawing.Size(120, 25);
            this.lblListadoFabricante.TabIndex = 5;
            this.lblListadoFabricante.Text = "Fabricante:";
            // 
            // lblListadoModelo
            // 
            this.lblListadoModelo.AutoSize = true;
            this.lblListadoModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoModelo.Location = new System.Drawing.Point(428, 334);
            this.lblListadoModelo.Name = "lblListadoModelo";
            this.lblListadoModelo.Size = new System.Drawing.Size(89, 25);
            this.lblListadoModelo.TabIndex = 6;
            this.lblListadoModelo.Text = "Modelo:";
            // 
            // lblListadoPrecio
            // 
            this.lblListadoPrecio.AutoSize = true;
            this.lblListadoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoPrecio.Location = new System.Drawing.Point(428, 373);
            this.lblListadoPrecio.Name = "lblListadoPrecio";
            this.lblListadoPrecio.Size = new System.Drawing.Size(79, 25);
            this.lblListadoPrecio.TabIndex = 7;
            this.lblListadoPrecio.Text = "Precio:";
            // 
            // lblListadoArticulo
            // 
            this.lblListadoArticulo.AutoSize = true;
            this.lblListadoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoArticulo.Location = new System.Drawing.Point(554, 294);
            this.lblListadoArticulo.Name = "lblListadoArticulo";
            this.lblListadoArticulo.Size = new System.Drawing.Size(136, 24);
            this.lblListadoArticulo.TabIndex = 8;
            this.lblListadoArticulo.Text = "Nombre Marca";
            // 
            // lblListadoModeloArticulo
            // 
            this.lblListadoModeloArticulo.AutoSize = true;
            this.lblListadoModeloArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoModeloArticulo.Location = new System.Drawing.Point(523, 335);
            this.lblListadoModeloArticulo.Name = "lblListadoModeloArticulo";
            this.lblListadoModeloArticulo.Size = new System.Drawing.Size(148, 24);
            this.lblListadoModeloArticulo.TabIndex = 9;
            this.lblListadoModeloArticulo.Text = "Nombre Modelo";
            // 
            // frmListadoPrecioArticulo
            // 
            this.frmListadoPrecioArticulo.AutoSize = true;
            this.frmListadoPrecioArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmListadoPrecioArticulo.Location = new System.Drawing.Point(513, 374);
            this.frmListadoPrecioArticulo.Name = "frmListadoPrecioArticulo";
            this.frmListadoPrecioArticulo.Size = new System.Drawing.Size(133, 24);
            this.frmListadoPrecioArticulo.TabIndex = 10;
            this.frmListadoPrecioArticulo.Text = "Precio Modelo";
            // 
            // frmListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 790);
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
    }
}