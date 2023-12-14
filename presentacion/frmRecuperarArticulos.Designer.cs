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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarRecuperar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloRecuperar
            // 
            this.lblTituloRecuperar.AutoSize = true;
            this.lblTituloRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRecuperar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTituloRecuperar.Location = new System.Drawing.Point(484, 22);
            this.lblTituloRecuperar.Name = "lblTituloRecuperar";
            this.lblTituloRecuperar.Size = new System.Drawing.Size(209, 25);
            this.lblTituloRecuperar.TabIndex = 0;
            this.lblTituloRecuperar.Text = "Recuperar Registros";
            // 
            // dgvListadoArticulos
            // 
            this.dgvListadoArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.dgvListadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.dgvListadoArticulos.Location = new System.Drawing.Point(12, 89);
            this.dgvListadoArticulos.Name = "dgvListadoArticulos";
            this.dgvListadoArticulos.Size = new System.Drawing.Size(919, 232);
            this.dgvListadoArticulos.TabIndex = 1;
            this.dgvListadoArticulos.SelectionChanged += new System.EventHandler(this.dgvListadoArticulos_SelectionChanged);
            // 
            // pbxImagenArticulo
            // 
            this.pbxImagenArticulo.Location = new System.Drawing.Point(937, 89);
            this.pbxImagenArticulo.Name = "pbxImagenArticulo";
            this.pbxImagenArticulo.Size = new System.Drawing.Size(233, 232);
            this.pbxImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenArticulo.TabIndex = 18;
            this.pbxImagenArticulo.TabStop = false;
            // 
            // bntRecuperarRegistro
            // 
            this.bntRecuperarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(206)))), ((int)(((byte)(172)))));
            this.bntRecuperarRegistro.FlatAppearance.BorderSize = 0;
            this.bntRecuperarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntRecuperarRegistro.Location = new System.Drawing.Point(475, 349);
            this.bntRecuperarRegistro.Name = "bntRecuperarRegistro";
            this.bntRecuperarRegistro.Size = new System.Drawing.Size(120, 23);
            this.bntRecuperarRegistro.TabIndex = 19;
            this.bntRecuperarRegistro.Text = "Restaurar Registro";
            this.bntRecuperarRegistro.UseVisualStyleBackColor = false;
            this.bntRecuperarRegistro.Click += new System.EventHandler(this.bntRecuperarRegistro_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(3)))), ((int)(((byte)(46)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.Location = new System.Drawing.Point(614, 349);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(79, 23);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.btnCerrarRecuperar);
            this.panel1.Controls.Add(this.lblTituloRecuperar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 77);
            this.panel1.TabIndex = 21;
            // 
            // btnCerrarRecuperar
            // 
            this.btnCerrarRecuperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(3)))), ((int)(((byte)(46)))));
            this.btnCerrarRecuperar.FlatAppearance.BorderSize = 0;
            this.btnCerrarRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarRecuperar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrarRecuperar.Location = new System.Drawing.Point(1150, 12);
            this.btnCerrarRecuperar.Name = "btnCerrarRecuperar";
            this.btnCerrarRecuperar.Size = new System.Drawing.Size(44, 34);
            this.btnCerrarRecuperar.TabIndex = 24;
            this.btnCerrarRecuperar.Text = "X";
            this.btnCerrarRecuperar.UseVisualStyleBackColor = false;
            this.btnCerrarRecuperar.Click += new System.EventHandler(this.btnCerrarRecuperar_Click);
            // 
            // frmRecuperarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 398);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.bntRecuperarRegistro);
            this.Controls.Add(this.pbxImagenArticulo);
            this.Controls.Add(this.dgvListadoArticulos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecuperarArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecuperarArticulos";
            this.Load += new System.EventHandler(this.frmRecuperarArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTituloRecuperar;
        private System.Windows.Forms.DataGridView dgvListadoArticulos;
        private System.Windows.Forms.PictureBox pbxImagenArticulo;
        private System.Windows.Forms.Button bntRecuperarRegistro;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarRecuperar;
    }
}