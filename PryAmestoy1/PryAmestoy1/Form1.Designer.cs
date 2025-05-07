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
            ((System.ComponentModel.ISupportInitialize)(this.PictureImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmSuperheroes
            // 
            this.cbmSuperheroes.FormattingEnabled = true;
            this.cbmSuperheroes.Location = new System.Drawing.Point(333, 26);
            this.cbmSuperheroes.Name = "cbmSuperheroes";
            this.cbmSuperheroes.Size = new System.Drawing.Size(121, 21);
            this.cbmSuperheroes.TabIndex = 0;
            this.cbmSuperheroes.SelectedIndexChanged += new System.EventHandler(this.cbmSuperheroes_SelectedIndexChanged);
            // 
            // PictureImagenes
            // 
            this.PictureImagenes.Location = new System.Drawing.Point(312, 66);
            this.PictureImagenes.Name = "PictureImagenes";
            this.PictureImagenes.Size = new System.Drawing.Size(165, 176);
            this.PictureImagenes.TabIndex = 1;
            this.PictureImagenes.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureImagenes);
            this.Controls.Add(this.cbmSuperheroes);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureImagenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmSuperheroes;
        private System.Windows.Forms.PictureBox PictureImagenes;
    }
}

