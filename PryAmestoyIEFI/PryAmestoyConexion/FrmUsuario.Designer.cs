namespace PryAmestoyConexion
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureRestaurar = new System.Windows.Forms.PictureBox();
            this.pictureMaximizar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureMinimizar1 = new System.Windows.Forms.PictureBox();
            this.pictureCancel = new System.Windows.Forms.PictureBox();
            this.lblAudi = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.txtCodigoUS = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblCodigoUS = new System.Windows.Forms.Label();
            this.lblTelefonoUS = new System.Windows.Forms.Label();
            this.lblDireccionUS = new System.Windows.Forms.Label();
            this.lblDniUS = new System.Windows.Forms.Label();
            this.lblContraseñaUS = new System.Windows.Forms.Label();
            this.lblNombreUS = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panelTop.Controls.Add(this.pictureRestaurar);
            this.panelTop.Controls.Add(this.pictureMaximizar);
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Controls.Add(this.pictureMinimizar1);
            this.panelTop.Controls.Add(this.pictureCancel);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(948, 34);
            this.panelTop.TabIndex = 0;
            // 
            // pictureRestaurar
            // 
            this.pictureRestaurar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pictureRestaurar.Image")));
            this.pictureRestaurar.Location = new System.Drawing.Point(879, 3);
            this.pictureRestaurar.Name = "pictureRestaurar";
            this.pictureRestaurar.Size = new System.Drawing.Size(25, 25);
            this.pictureRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRestaurar.TabIndex = 20;
            this.pictureRestaurar.TabStop = false;
            this.pictureRestaurar.Visible = false;
            this.pictureRestaurar.Click += new System.EventHandler(this.pictureRestaurar_Click);
            // 
            // pictureMaximizar
            // 
            this.pictureMaximizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureMaximizar.Image")));
            this.pictureMaximizar.Location = new System.Drawing.Point(879, 3);
            this.pictureMaximizar.Name = "pictureMaximizar";
            this.pictureMaximizar.Size = new System.Drawing.Size(25, 25);
            this.pictureMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMaximizar.TabIndex = 19;
            this.pictureMaximizar.TabStop = false;
            this.pictureMaximizar.Visible = false;
            this.pictureMaximizar.Click += new System.EventHandler(this.pictureMaximizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(44, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 390);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Cliente";
            // 
            // pictureMinimizar1
            // 
            this.pictureMinimizar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureMinimizar1.BackColor = System.Drawing.Color.Transparent;
            this.pictureMinimizar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimizar1.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimizar1.Image")));
            this.pictureMinimizar1.Location = new System.Drawing.Point(848, 3);
            this.pictureMinimizar1.Name = "pictureMinimizar1";
            this.pictureMinimizar1.Size = new System.Drawing.Size(25, 25);
            this.pictureMinimizar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMinimizar1.TabIndex = 1;
            this.pictureMinimizar1.TabStop = false;
            this.pictureMinimizar1.Visible = false;
            this.pictureMinimizar1.Click += new System.EventHandler(this.pictureMinimizar1_Click);
            // 
            // pictureCancel
            // 
            this.pictureCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureCancel.BackColor = System.Drawing.Color.Transparent;
            this.pictureCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureCancel.Image = ((System.Drawing.Image)(resources.GetObject("pictureCancel.Image")));
            this.pictureCancel.Location = new System.Drawing.Point(911, 3);
            this.pictureCancel.Name = "pictureCancel";
            this.pictureCancel.Size = new System.Drawing.Size(25, 25);
            this.pictureCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCancel.TabIndex = 0;
            this.pictureCancel.TabStop = false;
            this.pictureCancel.Visible = false;
            this.pictureCancel.Click += new System.EventHandler(this.pictureCancel_Click);
            // 
            // lblAudi
            // 
            this.lblAudi.AutoSize = true;
            this.lblAudi.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAudi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAudi.Location = new System.Drawing.Point(396, 54);
            this.lblAudi.Name = "lblAudi";
            this.lblAudi.Size = new System.Drawing.Size(152, 33);
            this.lblAudi.TabIndex = 1;
            this.lblAudi.Text = "AUDITORIA";
            // 
            // DgvListado
            // 
            this.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListado.ColumnHeadersHeight = 26;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListado.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListado.EnableHeadersVisualStyles = false;
            this.DgvListado.GridColor = System.Drawing.Color.SteelBlue;
            this.DgvListado.Location = new System.Drawing.Point(506, 112);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            this.DgvListado.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.ShowEditingIcon = false;
            this.DgvListado.Size = new System.Drawing.Size(407, 341);
            this.DgvListado.TabIndex = 2;
            this.DgvListado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.Location = new System.Drawing.Point(290, 152);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 37);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.Location = new System.Drawing.Point(290, 217);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 37);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Modificar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Modificar.FlatAppearance.BorderSize = 0;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Modificar.Location = new System.Drawing.Point(290, 88);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(97, 37);
            this.Modificar.TabIndex = 5;
            this.Modificar.Text = "MODIFICAR";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // txtCodigoUS
            // 
            this.txtCodigoUS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoUS.Location = new System.Drawing.Point(142, 55);
            this.txtCodigoUS.Name = "txtCodigoUS";
            this.txtCodigoUS.Size = new System.Drawing.Size(112, 27);
            this.txtCodigoUS.TabIndex = 6;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Location = new System.Drawing.Point(142, 241);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(112, 27);
            this.txtContraseña.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(142, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(112, 27);
            this.txtNombre.TabIndex = 8;
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni.Location = new System.Drawing.Point(142, 147);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(112, 27);
            this.txtDni.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(142, 193);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(112, 27);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Location = new System.Drawing.Point(142, 285);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(112, 27);
            this.txtTelefono.TabIndex = 11;
            // 
            // lblCodigoUS
            // 
            this.lblCodigoUS.AutoSize = true;
            this.lblCodigoUS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoUS.ForeColor = System.Drawing.Color.LightGray;
            this.lblCodigoUS.Location = new System.Drawing.Point(22, 60);
            this.lblCodigoUS.Name = "lblCodigoUS";
            this.lblCodigoUS.Size = new System.Drawing.Size(90, 20);
            this.lblCodigoUS.TabIndex = 12;
            this.lblCodigoUS.Text = "CodigoUS :";
            // 
            // lblTelefonoUS
            // 
            this.lblTelefonoUS.AutoSize = true;
            this.lblTelefonoUS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoUS.ForeColor = System.Drawing.Color.LightGray;
            this.lblTelefonoUS.Location = new System.Drawing.Point(22, 290);
            this.lblTelefonoUS.Name = "lblTelefonoUS";
            this.lblTelefonoUS.Size = new System.Drawing.Size(79, 20);
            this.lblTelefonoUS.TabIndex = 13;
            this.lblTelefonoUS.Text = "Teléfono :";
            // 
            // lblDireccionUS
            // 
            this.lblDireccionUS.AutoSize = true;
            this.lblDireccionUS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionUS.ForeColor = System.Drawing.Color.LightGray;
            this.lblDireccionUS.Location = new System.Drawing.Point(22, 198);
            this.lblDireccionUS.Name = "lblDireccionUS";
            this.lblDireccionUS.Size = new System.Drawing.Size(88, 20);
            this.lblDireccionUS.TabIndex = 14;
            this.lblDireccionUS.Text = "Direccion :";
            // 
            // lblDniUS
            // 
            this.lblDniUS.AutoSize = true;
            this.lblDniUS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniUS.ForeColor = System.Drawing.Color.LightGray;
            this.lblDniUS.Location = new System.Drawing.Point(22, 152);
            this.lblDniUS.Name = "lblDniUS";
            this.lblDniUS.Size = new System.Drawing.Size(44, 20);
            this.lblDniUS.TabIndex = 15;
            this.lblDniUS.Text = "DNI :";
            // 
            // lblContraseñaUS
            // 
            this.lblContraseñaUS.AutoSize = true;
            this.lblContraseñaUS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaUS.ForeColor = System.Drawing.Color.LightGray;
            this.lblContraseñaUS.Location = new System.Drawing.Point(22, 246);
            this.lblContraseñaUS.Name = "lblContraseñaUS";
            this.lblContraseñaUS.Size = new System.Drawing.Size(103, 20);
            this.lblContraseñaUS.TabIndex = 16;
            this.lblContraseñaUS.Text = "Contraseña :";
            // 
            // lblNombreUS
            // 
            this.lblNombreUS.AutoSize = true;
            this.lblNombreUS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUS.ForeColor = System.Drawing.Color.LightGray;
            this.lblNombreUS.Location = new System.Drawing.Point(23, 105);
            this.lblNombreUS.Name = "lblNombreUS";
            this.lblNombreUS.Size = new System.Drawing.Size(76, 20);
            this.lblNombreUS.TabIndex = 17;
            this.lblNombreUS.Text = "Nombre :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.groupBox2.Controls.Add(this.lblCodigoUS);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.Modificar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.txtContraseña);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.lblTelefonoUS);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.lblContraseñaUS);
            this.groupBox2.Controls.Add(this.txtDni);
            this.groupBox2.Controls.Add(this.lblNombreUS);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.lblDireccionUS);
            this.groupBox2.Controls.Add(this.lblDniUS);
            this.groupBox2.Controls.Add(this.txtCodigoUS);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(26, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 341);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NUEVO USUARIO";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(948, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DgvListado);
            this.Controls.Add(this.lblAudi);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureCancel;
        private System.Windows.Forms.PictureBox pictureMinimizar1;
        private System.Windows.Forms.Label lblAudi;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.TextBox txtCodigoUS;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCodigoUS;
        private System.Windows.Forms.Label lblTelefonoUS;
        private System.Windows.Forms.Label lblDireccionUS;
        private System.Windows.Forms.Label lblDniUS;
        private System.Windows.Forms.Label lblContraseñaUS;
        private System.Windows.Forms.Label lblNombreUS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureMaximizar;
        private System.Windows.Forms.PictureBox pictureRestaurar;
    }
}