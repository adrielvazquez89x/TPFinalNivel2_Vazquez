namespace presentacion
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblRealizado = new System.Windows.Forms.Label();
            this.pbxSitio = new System.Windows.Forms.PictureBox();
            this.linkGH = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkSitio = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSitio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(54, 61);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(233, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Catalog Adminstrator";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(3)))), ((int)(((byte)(46)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrar.Location = new System.Drawing.Point(994, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 34);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblRealizado
            // 
            this.lblRealizado.AutoSize = true;
            this.lblRealizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealizado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRealizado.Location = new System.Drawing.Point(121, 126);
            this.lblRealizado.Name = "lblRealizado";
            this.lblRealizado.Size = new System.Drawing.Size(289, 20);
            this.lblRealizado.TabIndex = 25;
            this.lblRealizado.Text = "Realizado por Adriel Alejandro Vazquez";
            // 
            // pbxSitio
            // 
            this.pbxSitio.Image = ((System.Drawing.Image)(resources.GetObject("pbxSitio.Image")));
            this.pbxSitio.Location = new System.Drawing.Point(72, 227);
            this.pbxSitio.Name = "pbxSitio";
            this.pbxSitio.Size = new System.Drawing.Size(35, 35);
            this.pbxSitio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSitio.TabIndex = 26;
            this.pbxSitio.TabStop = false;
            // 
            // linkGH
            // 
            this.linkGH.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkGH.AutoSize = true;
            this.linkGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkGH.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkGH.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkGH.Location = new System.Drawing.Point(121, 181);
            this.linkGH.Name = "linkGH";
            this.linkGH.Size = new System.Drawing.Size(57, 20);
            this.linkGH.TabIndex = 27;
            this.linkGH.TabStop = true;
            this.linkGH.Text = "Github";
            this.linkGH.VisitedLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkGH.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGH_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(72, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // linkSitio
            // 
            this.linkSitio.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkSitio.AutoSize = true;
            this.linkSitio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSitio.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSitio.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkSitio.Location = new System.Drawing.Point(121, 236);
            this.linkSitio.Name = "linkSitio";
            this.linkSitio.Size = new System.Drawing.Size(77, 20);
            this.linkSitio.TabIndex = 29;
            this.linkSitio.TabStop = true;
            this.linkSitio.Text = "Sitio Web";
            this.linkSitio.VisitedLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkSitio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSitio_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(72, 117);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1050, 816);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.linkSitio);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkGH);
            this.Controls.Add(this.pbxSitio);
            this.Controls.Add(this.lblRealizado);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSitio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblRealizado;
        private System.Windows.Forms.PictureBox pbxSitio;
        private System.Windows.Forms.LinkLabel linkGH;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkSitio;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}