namespace PryAmestoy1
{
    partial class Form1
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
            this.cbmSuperheroes = new System.Windows.Forms.ComboBox();
            this.PictureImagenes = new System.Windows.Forms.PictureBox();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.groupNuevo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDatoNuevo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureImagenes)).BeginInit();
            this.groupNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbmSuperheroes
            // 
            this.cbmSuperheroes.FormattingEnabled = true;
            this.cbmSuperheroes.Location = new System.Drawing.Point(66, 27);
            this.cbmSuperheroes.Name = "cbmSuperheroes";
            this.cbmSuperheroes.Size = new System.Drawing.Size(121, 21);
            this.cbmSuperheroes.TabIndex = 0;
            this.cbmSuperheroes.SelectedIndexChanged += new System.EventHandler(this.cbmSuperheroes_SelectedIndexChanged);
            // 
            // PictureImagenes
            // 
            this.PictureImagenes.Location = new System.Drawing.Point(52, 97);
            this.PictureImagenes.Name = "PictureImagenes";
            this.PictureImagenes.Size = new System.Drawing.Size(165, 176);
            this.PictureImagenes.TabIndex = 1;
            this.PictureImagenes.TabStop = false;
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(157, 197);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(75, 23);
            this.BtnCrear.TabIndex = 2;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // groupNuevo
            // 
            this.groupNuevo.Controls.Add(this.TxtDatoNuevo);
            this.groupNuevo.Controls.Add(this.label1);
            this.groupNuevo.Controls.Add(this.BtnCrear);
            this.groupNuevo.Location = new System.Drawing.Point(492, 38);
            this.groupNuevo.Name = "groupNuevo";
            this.groupNuevo.Size = new System.Drawing.Size(255, 240);
            this.groupNuevo.TabIndex = 3;
            this.groupNuevo.TabStop = false;
            this.groupNuevo.Text = "Nuevo Elemento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dato a grabar :";
            // 
            // TxtDatoNuevo
            // 
            this.TxtDatoNuevo.Location = new System.Drawing.Point(110, 38);
            this.TxtDatoNuevo.Name = "TxtDatoNuevo";
            this.TxtDatoNuevo.Size = new System.Drawing.Size(122, 20);
            this.TxtDatoNuevo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupNuevo);
            this.Controls.Add(this.PictureImagenes);
            this.Controls.Add(this.cbmSuperheroes);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureImagenes)).EndInit();
            this.groupNuevo.ResumeLayout(false);
            this.groupNuevo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmSuperheroes;
        private System.Windows.Forms.PictureBox PictureImagenes;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.GroupBox groupNuevo;
        private System.Windows.Forms.TextBox TxtDatoNuevo;
        private System.Windows.Forms.Label label1;
    }
}

