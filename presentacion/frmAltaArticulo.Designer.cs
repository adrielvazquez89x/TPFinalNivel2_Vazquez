﻿namespace presentacion
{
    partial class frmAltaArticulo
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbxAltaImagen = new System.Windows.Forms.PictureBox();
            this.lblRequeridoCodigo = new System.Windows.Forms.Label();
            this.lblRequeridoNombre = new System.Windows.Forms.Label();
            this.lblRequeridoPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAltaImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(26, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Alta de nuevo artículo";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(42, 83);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(79, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo artículo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(77, 130);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(58, 177);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtCodigo.Location = new System.Drawing.Point(127, 80);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(153, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 127);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(127, 174);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(153, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(64, 224);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(57, 13);
            this.lblUrl.TabIndex = 7;
            this.lblUrl.Text = "Url imagen";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(127, 221);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(153, 20);
            this.txtUrl.TabIndex = 8;
            this.txtUrl.Leave += new System.EventHandler(this.txtUrl_Leave);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(84, 271);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(127, 268);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(153, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(84, 318);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "Marca";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(127, 315);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(153, 21);
            this.cboMarca.TabIndex = 12;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(69, 366);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoria";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(127, 363);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(153, 21);
            this.cboCategoria.TabIndex = 14;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(205, 423);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(342, 423);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbxAltaImagen
            // 
            this.pbxAltaImagen.Location = new System.Drawing.Point(328, 104);
            this.pbxAltaImagen.Name = "pbxAltaImagen";
            this.pbxAltaImagen.Size = new System.Drawing.Size(233, 232);
            this.pbxAltaImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAltaImagen.TabIndex = 17;
            this.pbxAltaImagen.TabStop = false;
            // 
            // lblRequeridoCodigo
            // 
            this.lblRequeridoCodigo.AutoSize = true;
            this.lblRequeridoCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblRequeridoCodigo.Location = new System.Drawing.Point(127, 104);
            this.lblRequeridoCodigo.Name = "lblRequeridoCodigo";
            this.lblRequeridoCodigo.Size = new System.Drawing.Size(92, 13);
            this.lblRequeridoCodigo.TabIndex = 18;
            this.lblRequeridoCodigo.Text = "Campo Requerido";
            this.lblRequeridoCodigo.Visible = false;
            // 
            // lblRequeridoNombre
            // 
            this.lblRequeridoNombre.AutoSize = true;
            this.lblRequeridoNombre.ForeColor = System.Drawing.Color.Red;
            this.lblRequeridoNombre.Location = new System.Drawing.Point(127, 150);
            this.lblRequeridoNombre.Name = "lblRequeridoNombre";
            this.lblRequeridoNombre.Size = new System.Drawing.Size(92, 13);
            this.lblRequeridoNombre.TabIndex = 19;
            this.lblRequeridoNombre.Text = "Campo Requerido";
            this.lblRequeridoNombre.Visible = false;
            // 
            // lblRequeridoPrecio
            // 
            this.lblRequeridoPrecio.AutoSize = true;
            this.lblRequeridoPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblRequeridoPrecio.Location = new System.Drawing.Point(127, 291);
            this.lblRequeridoPrecio.Name = "lblRequeridoPrecio";
            this.lblRequeridoPrecio.Size = new System.Drawing.Size(92, 13);
            this.lblRequeridoPrecio.TabIndex = 20;
            this.lblRequeridoPrecio.Text = "Campo Requerido";
            this.lblRequeridoPrecio.Visible = false;
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 507);
            this.Controls.Add(this.lblRequeridoPrecio);
            this.Controls.Add(this.lblRequeridoNombre);
            this.Controls.Add(this.lblRequeridoCodigo);
            this.Controls.Add(this.pbxAltaImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAltaArticulo";
            this.Text = "Articulo nuevo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAltaImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbxAltaImagen;
        private System.Windows.Forms.Label lblRequeridoCodigo;
        private System.Windows.Forms.Label lblRequeridoNombre;
        private System.Windows.Forms.Label lblRequeridoPrecio;
    }
}