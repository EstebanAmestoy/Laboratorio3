namespace PryAmestoyConexion
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureRes = new System.Windows.Forms.PictureBox();
            this.pictureMax = new System.Windows.Forms.PictureBox();
            this.pictureMin = new System.Windows.Forms.PictureBox();
            this.pictureCancel1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.LblAdmin = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCancel1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureRes);
            this.panel1.Controls.Add(this.pictureMax);
            this.panel1.Controls.Add(this.pictureMin);
            this.panel1.Controls.Add(this.pictureCancel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 39);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureRes
            // 
            this.pictureRes.BackColor = System.Drawing.Color.Transparent;
            this.pictureRes.Image = ((System.Drawing.Image)(resources.GetObject("pictureRes.Image")));
            this.pictureRes.Location = new System.Drawing.Point(1104, 7);
            this.pictureRes.Name = "pictureRes";
            this.pictureRes.Size = new System.Drawing.Size(25, 25);
            this.pictureRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRes.TabIndex = 5;
            this.pictureRes.TabStop = false;
            this.pictureRes.Click += new System.EventHandler(this.pictureRes_Click);
            // 
            // pictureMax
            // 
            this.pictureMax.BackColor = System.Drawing.Color.Transparent;
            this.pictureMax.Image = ((System.Drawing.Image)(resources.GetObject("pictureMax.Image")));
            this.pictureMax.Location = new System.Drawing.Point(1104, 7);
            this.pictureMax.Name = "pictureMax";
            this.pictureMax.Size = new System.Drawing.Size(25, 25);
            this.pictureMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMax.TabIndex = 4;
            this.pictureMax.TabStop = false;
            this.pictureMax.Click += new System.EventHandler(this.pictureMax_Click);
            // 
            // pictureMin
            // 
            this.pictureMin.BackColor = System.Drawing.Color.Transparent;
            this.pictureMin.Image = ((System.Drawing.Image)(resources.GetObject("pictureMin.Image")));
            this.pictureMin.Location = new System.Drawing.Point(1073, 9);
            this.pictureMin.Name = "pictureMin";
            this.pictureMin.Size = new System.Drawing.Size(25, 25);
            this.pictureMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMin.TabIndex = 3;
            this.pictureMin.TabStop = false;
            this.pictureMin.Click += new System.EventHandler(this.pictureMin_Click);
            // 
            // pictureCancel1
            // 
            this.pictureCancel1.BackColor = System.Drawing.Color.Transparent;
            this.pictureCancel1.Image = ((System.Drawing.Image)(resources.GetObject("pictureCancel1.Image")));
            this.pictureCancel1.Location = new System.Drawing.Point(1135, 7);
            this.pictureCancel1.Name = "pictureCancel1";
            this.pictureCancel1.Size = new System.Drawing.Size(25, 25);
            this.pictureCancel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCancel1.TabIndex = 2;
            this.pictureCancel1.TabStop = false;
            this.pictureCancel1.Click += new System.EventHandler(this.pictureCancel1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnStock);
            this.panel2.Controls.Add(this.LblAdmin);
            this.panel2.Controls.Add(this.btnClientes);
            this.panel2.Controls.Add(this.btnUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 592);
            this.panel2.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(36, 477);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(171, 41);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "  SALIR";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(36, 369);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(171, 41);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "  STOCK";
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblAdmin.Location = new System.Drawing.Point(21, 62);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(225, 33);
            this.LblAdmin.TabIndex = 4;
            this.LblAdmin.Text = "ADMINISTACION";
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(36, 252);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(171, 41);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "AUDITORIA";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(40, 138);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(167, 41);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "   USUARIO";
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.lblFecha);
            this.panelContenedor.Controls.Add(this.lblHora);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(255, 39);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(918, 592);
            this.panelContenedor.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFecha.Location = new System.Drawing.Point(585, 524);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(126, 37);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "FECHA";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(200)))));
            this.lblHora.Location = new System.Drawing.Point(355, 238);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(163, 55);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "HORA";
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(1173, 631);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCancel1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureCancel1;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label LblAdmin;
        private System.Windows.Forms.PictureBox pictureMin;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureRes;
        private System.Windows.Forms.PictureBox pictureMax;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer HoraFecha;
    }
}

