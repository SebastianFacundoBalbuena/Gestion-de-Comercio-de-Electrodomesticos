namespace Mercado
{
    partial class FormularioAgregar
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAgregar = new System.Windows.Forms.Label();
            this.botonombre = new System.Windows.Forms.Label();
            this.botoncategoria = new System.Windows.Forms.Label();
            this.botonmarca = new System.Windows.Forms.Label();
            this.botonprecio = new System.Windows.Forms.Label();
            this.botondescripcion = new System.Windows.Forms.Label();
            this.barranombre = new System.Windows.Forms.TextBox();
            this.barraprecio = new System.Windows.Forms.TextBox();
            this.barradescripcion = new System.Windows.Forms.TextBox();
            this.barraimagen = new System.Windows.Forms.TextBox();
            this.textoimagen = new System.Windows.Forms.Label();
            this.barracategoria = new System.Windows.Forms.ComboBox();
            this.barramarca = new System.Windows.Forms.ComboBox();
            this.cancelarnuevoarticulo = new System.Windows.Forms.Button();
            this.agregarnuevoarticulo = new System.Windows.Forms.Button();
            this.imagenAgregar = new System.Windows.Forms.PictureBox();
            this.textoCodigo = new System.Windows.Forms.Label();
            this.barracodigo = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.labelAgregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 99);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mercado.Properties.Resources.producto;
            this.pictureBox1.Location = new System.Drawing.Point(27, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelAgregar
            // 
            this.labelAgregar.AutoSize = true;
            this.labelAgregar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregar.ForeColor = System.Drawing.Color.White;
            this.labelAgregar.Location = new System.Drawing.Point(133, 36);
            this.labelAgregar.Name = "labelAgregar";
            this.labelAgregar.Size = new System.Drawing.Size(178, 24);
            this.labelAgregar.TabIndex = 0;
            this.labelAgregar.Text = "NUEVO ARTICULO";
            // 
            // botonombre
            // 
            this.botonombre.AutoSize = true;
            this.botonombre.Location = new System.Drawing.Point(33, 171);
            this.botonombre.Name = "botonombre";
            this.botonombre.Size = new System.Drawing.Size(44, 13);
            this.botonombre.TabIndex = 1;
            this.botonombre.Text = "Nombre";
            // 
            // botoncategoria
            // 
            this.botoncategoria.AutoSize = true;
            this.botoncategoria.Location = new System.Drawing.Point(25, 234);
            this.botoncategoria.Name = "botoncategoria";
            this.botoncategoria.Size = new System.Drawing.Size(52, 13);
            this.botoncategoria.TabIndex = 2;
            this.botoncategoria.Text = "Categoria";
            // 
            // botonmarca
            // 
            this.botonmarca.AutoSize = true;
            this.botonmarca.Location = new System.Drawing.Point(33, 266);
            this.botonmarca.Name = "botonmarca";
            this.botonmarca.Size = new System.Drawing.Size(37, 13);
            this.botonmarca.TabIndex = 3;
            this.botonmarca.Text = "Marca";
            // 
            // botonprecio
            // 
            this.botonprecio.AutoSize = true;
            this.botonprecio.Location = new System.Drawing.Point(33, 293);
            this.botonprecio.Name = "botonprecio";
            this.botonprecio.Size = new System.Drawing.Size(37, 13);
            this.botonprecio.TabIndex = 4;
            this.botonprecio.Text = "Precio";
            // 
            // botondescripcion
            // 
            this.botondescripcion.AutoSize = true;
            this.botondescripcion.Location = new System.Drawing.Point(7, 320);
            this.botondescripcion.Name = "botondescripcion";
            this.botondescripcion.Size = new System.Drawing.Size(63, 13);
            this.botondescripcion.TabIndex = 5;
            this.botondescripcion.Text = "Descripcion";
            // 
            // barranombre
            // 
            this.barranombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barranombre.Location = new System.Drawing.Point(85, 164);
            this.barranombre.Name = "barranombre";
            this.barranombre.Size = new System.Drawing.Size(103, 20);
            this.barranombre.TabIndex = 2;
            // 
            // barraprecio
            // 
            this.barraprecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barraprecio.Location = new System.Drawing.Point(85, 286);
            this.barraprecio.Name = "barraprecio";
            this.barraprecio.Size = new System.Drawing.Size(103, 20);
            this.barraprecio.TabIndex = 6;
            // 
            // barradescripcion
            // 
            this.barradescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barradescripcion.Location = new System.Drawing.Point(85, 313);
            this.barradescripcion.Name = "barradescripcion";
            this.barradescripcion.Size = new System.Drawing.Size(103, 20);
            this.barradescripcion.TabIndex = 7;
            // 
            // barraimagen
            // 
            this.barraimagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barraimagen.Location = new System.Drawing.Point(85, 197);
            this.barraimagen.Name = "barraimagen";
            this.barraimagen.Size = new System.Drawing.Size(103, 20);
            this.barraimagen.TabIndex = 3;
            this.barraimagen.Leave += new System.EventHandler(this.barraimagen_Leave);
            // 
            // textoimagen
            // 
            this.textoimagen.AutoSize = true;
            this.textoimagen.Location = new System.Drawing.Point(13, 204);
            this.textoimagen.Name = "textoimagen";
            this.textoimagen.Size = new System.Drawing.Size(64, 13);
            this.textoimagen.TabIndex = 12;
            this.textoimagen.Text = "(Url) Imagen";
            // 
            // barracategoria
            // 
            this.barracategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.barracategoria.FormattingEnabled = true;
            this.barracategoria.Location = new System.Drawing.Point(85, 226);
            this.barracategoria.Name = "barracategoria";
            this.barracategoria.Size = new System.Drawing.Size(103, 21);
            this.barracategoria.TabIndex = 4;
            // 
            // barramarca
            // 
            this.barramarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.barramarca.FormattingEnabled = true;
            this.barramarca.Location = new System.Drawing.Point(85, 258);
            this.barramarca.Name = "barramarca";
            this.barramarca.Size = new System.Drawing.Size(103, 21);
            this.barramarca.TabIndex = 5;
            // 
            // cancelarnuevoarticulo
            // 
            this.cancelarnuevoarticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(91)))));
            this.cancelarnuevoarticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarnuevoarticulo.FlatAppearance.BorderSize = 0;
            this.cancelarnuevoarticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(91)))));
            this.cancelarnuevoarticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarnuevoarticulo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarnuevoarticulo.ForeColor = System.Drawing.Color.White;
            this.cancelarnuevoarticulo.Image = global::Mercado.Properties.Resources.icons8_multiplicar_20;
            this.cancelarnuevoarticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarnuevoarticulo.Location = new System.Drawing.Point(221, 385);
            this.cancelarnuevoarticulo.Name = "cancelarnuevoarticulo";
            this.cancelarnuevoarticulo.Size = new System.Drawing.Size(112, 32);
            this.cancelarnuevoarticulo.TabIndex = 9;
            this.cancelarnuevoarticulo.Text = " Cancelar";
            this.cancelarnuevoarticulo.UseVisualStyleBackColor = false;
            this.cancelarnuevoarticulo.Click += new System.EventHandler(this.cancelarnuevoarticulo_Click);
            // 
            // agregarnuevoarticulo
            // 
            this.agregarnuevoarticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(91)))));
            this.agregarnuevoarticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarnuevoarticulo.FlatAppearance.BorderSize = 0;
            this.agregarnuevoarticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(91)))));
            this.agregarnuevoarticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarnuevoarticulo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarnuevoarticulo.ForeColor = System.Drawing.Color.White;
            this.agregarnuevoarticulo.Image = global::Mercado.Properties.Resources.icons8_más_20;
            this.agregarnuevoarticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarnuevoarticulo.Location = new System.Drawing.Point(36, 385);
            this.agregarnuevoarticulo.Name = "agregarnuevoarticulo";
            this.agregarnuevoarticulo.Size = new System.Drawing.Size(112, 32);
            this.agregarnuevoarticulo.TabIndex = 8;
            this.agregarnuevoarticulo.Text = " Aceptar";
            this.agregarnuevoarticulo.UseVisualStyleBackColor = false;
            this.agregarnuevoarticulo.Click += new System.EventHandler(this.agregarnuevoarticulo_Click);
            // 
            // imagenAgregar
            // 
            this.imagenAgregar.Location = new System.Drawing.Point(207, 153);
            this.imagenAgregar.Name = "imagenAgregar";
            this.imagenAgregar.Size = new System.Drawing.Size(151, 169);
            this.imagenAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenAgregar.TabIndex = 15;
            this.imagenAgregar.TabStop = false;
            // 
            // textoCodigo
            // 
            this.textoCodigo.AutoSize = true;
            this.textoCodigo.Location = new System.Drawing.Point(37, 142);
            this.textoCodigo.Name = "textoCodigo";
            this.textoCodigo.Size = new System.Drawing.Size(40, 13);
            this.textoCodigo.TabIndex = 18;
            this.textoCodigo.Text = "Codigo";
            // 
            // barracodigo
            // 
            this.barracodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barracodigo.Location = new System.Drawing.Point(85, 135);
            this.barracodigo.Name = "barracodigo";
            this.barracodigo.Size = new System.Drawing.Size(103, 20);
            this.barracodigo.TabIndex = 1;
            // 
            // FormularioAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 467);
            this.Controls.Add(this.barracodigo);
            this.Controls.Add(this.textoCodigo);
            this.Controls.Add(this.cancelarnuevoarticulo);
            this.Controls.Add(this.agregarnuevoarticulo);
            this.Controls.Add(this.imagenAgregar);
            this.Controls.Add(this.barramarca);
            this.Controls.Add(this.barracategoria);
            this.Controls.Add(this.textoimagen);
            this.Controls.Add(this.barraimagen);
            this.Controls.Add(this.barradescripcion);
            this.Controls.Add(this.barraprecio);
            this.Controls.Add(this.barranombre);
            this.Controls.Add(this.botondescripcion);
            this.Controls.Add(this.botonprecio);
            this.Controls.Add(this.botonmarca);
            this.Controls.Add(this.botoncategoria);
            this.Controls.Add(this.botonombre);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(386, 506);
            this.MinimumSize = new System.Drawing.Size(386, 506);
            this.Name = "FormularioAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar/Modificar";
            this.Load += new System.EventHandler(this.FormularioAgregar_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label botonombre;
        private System.Windows.Forms.Label botoncategoria;
        private System.Windows.Forms.Label botonmarca;
        private System.Windows.Forms.Label botonprecio;
        private System.Windows.Forms.Label botondescripcion;
        private System.Windows.Forms.TextBox barranombre;
        private System.Windows.Forms.TextBox barraprecio;
        private System.Windows.Forms.TextBox barradescripcion;
        private System.Windows.Forms.TextBox barraimagen;
        private System.Windows.Forms.Label textoimagen;
        private System.Windows.Forms.ComboBox barracategoria;
        private System.Windows.Forms.ComboBox barramarca;
        private System.Windows.Forms.PictureBox imagenAgregar;
        private System.Windows.Forms.Button agregarnuevoarticulo;
        private System.Windows.Forms.Button cancelarnuevoarticulo;
        private System.Windows.Forms.Label textoCodigo;
        private System.Windows.Forms.TextBox barracodigo;
    }
}