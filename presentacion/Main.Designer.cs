namespace presentacion
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnAbrirMarcas = new System.Windows.Forms.Button();
            this.btnAbrirArticulos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenuLateral.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.panelMenuLateral.Controls.Add(this.btnAbout);
            this.panelMenuLateral.Controls.Add(this.btnAbrirMarcas);
            this.panelMenuLateral.Controls.Add(this.btnAbrirArticulos);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(250, 821);
            this.panelMenuLateral.TabIndex = 1;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(138)))), ((int)(((byte)(36)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbout.Location = new System.Drawing.Point(0, 776);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(250, 45);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "Acerca de";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnAbrirMarcas
            // 
            this.btnAbrirMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbrirMarcas.FlatAppearance.BorderSize = 0;
            this.btnAbrirMarcas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(138)))), ((int)(((byte)(36)))));
            this.btnAbrirMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnAbrirMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirMarcas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbrirMarcas.Location = new System.Drawing.Point(0, 190);
            this.btnAbrirMarcas.Name = "btnAbrirMarcas";
            this.btnAbrirMarcas.Size = new System.Drawing.Size(250, 45);
            this.btnAbrirMarcas.TabIndex = 1;
            this.btnAbrirMarcas.Text = "Marcas";
            this.btnAbrirMarcas.UseVisualStyleBackColor = true;
            this.btnAbrirMarcas.Click += new System.EventHandler(this.btnAbrirMarcas_Click);
            // 
            // btnAbrirArticulos
            // 
            this.btnAbrirArticulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbrirArticulos.FlatAppearance.BorderSize = 0;
            this.btnAbrirArticulos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(138)))), ((int)(((byte)(36)))));
            this.btnAbrirArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnAbrirArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArticulos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbrirArticulos.Location = new System.Drawing.Point(0, 145);
            this.btnAbrirArticulos.Name = "btnAbrirArticulos";
            this.btnAbrirArticulos.Size = new System.Drawing.Size(250, 45);
            this.btnAbrirArticulos.TabIndex = 0;
            this.btnAbrirArticulos.Text = "Artículos";
            this.btnAbrirArticulos.UseVisualStyleBackColor = true;
            this.btnAbrirArticulos.Click += new System.EventHandler(this.btnAbrirArticulos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 145);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1304, 821);
            this.Controls.Add(this.panelMenuLateral);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalog Administrator";
            this.panelMenuLateral.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnAbrirMarcas;
        private System.Windows.Forms.Button btnAbrirArticulos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

