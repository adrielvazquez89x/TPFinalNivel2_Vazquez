namespace presentacion
{
    partial class frmRecuperarArticulos
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
            this.lblTituloRecuperar = new System.Windows.Forms.Label();
            this.dgvListadoArticulos = new System.Windows.Forms.DataGridView();
            this.pbxImagenArticulo = new System.Windows.Forms.PictureBox();
            this.bntRecuperarRegistro = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloRecuperar
            // 
            this.lblTituloRecuperar.AutoSize = true;
            this.lblTituloRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRecuperar.Location = new System.Drawing.Point(28, 25);
            this.lblTituloRecuperar.Name = "lblTituloRecuperar";
            this.lblTituloRecuperar.Size = new System.Drawing.Size(209, 25);
            this.lblTituloRecuperar.TabIndex = 0;
            this.lblTituloRecuperar.Text = "Recuperar Registros";
            // 
            // dgvListadoArticulos
            // 
            this.dgvListadoArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoArticulos.Location = new System.Drawing.Point(33, 83);
            this.dgvListadoArticulos.Name = "dgvListadoArticulos";
            this.dgvListadoArticulos.Size = new System.Drawing.Size(803, 174);
            this.dgvListadoArticulos.TabIndex = 1;
            this.dgvListadoArticulos.SelectionChanged += new System.EventHandler(this.dgvListadoArticulos_SelectionChanged);
            // 
            // pbxImagenArticulo
            // 
            this.pbxImagenArticulo.Location = new System.Drawing.Point(910, 59);
            this.pbxImagenArticulo.Name = "pbxImagenArticulo";
            this.pbxImagenArticulo.Size = new System.Drawing.Size(233, 232);
            this.pbxImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenArticulo.TabIndex = 18;
            this.pbxImagenArticulo.TabStop = false;
            // 
            // bntRecuperarRegistro
            // 
            this.bntRecuperarRegistro.Location = new System.Drawing.Point(33, 298);
            this.bntRecuperarRegistro.Name = "bntRecuperarRegistro";
            this.bntRecuperarRegistro.Size = new System.Drawing.Size(120, 23);
            this.bntRecuperarRegistro.TabIndex = 19;
            this.bntRecuperarRegistro.Text = "Restaurar Registro";
            this.bntRecuperarRegistro.UseVisualStyleBackColor = true;
            this.bntRecuperarRegistro.Click += new System.EventHandler(this.bntRecuperarRegistro_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(172, 298);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(79, 23);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmRecuperarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 371);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.bntRecuperarRegistro);
            this.Controls.Add(this.pbxImagenArticulo);
            this.Controls.Add(this.dgvListadoArticulos);
            this.Controls.Add(this.lblTituloRecuperar);
            this.Name = "frmRecuperarArticulos";
            this.Text = "frmRecuperarArticulos";
            this.Load += new System.EventHandler(this.frmRecuperarArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloRecuperar;
        private System.Windows.Forms.DataGridView dgvListadoArticulos;
        private System.Windows.Forms.PictureBox pbxImagenArticulo;
        private System.Windows.Forms.Button bntRecuperarRegistro;
        private System.Windows.Forms.Button btnCerrar;
    }
}