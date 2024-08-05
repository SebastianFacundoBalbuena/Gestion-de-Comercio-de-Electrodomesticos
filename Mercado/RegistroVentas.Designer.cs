namespace Mercado
{
    partial class RegistroVentas
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelareaventas = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelprecio = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.listadesplegableventas = new System.Windows.Forms.ComboBox();
            this.barracantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelregistro = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.barrabuscarregistro = new System.Windows.Forms.TextBox();
            this.botonbuscarregistro = new System.Windows.Forms.Button();
            this.desplegablebuscarregistro = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botoneliminarregistro = new System.Windows.Forms.Button();
            this.cancelarnuevoarticulo = new System.Windows.Forms.Button();
            this.agregarnuevoarticulo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelFecha = new System.Windows.Forms.Label();
            this.horaregistros = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timerregistros = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelareaventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelregistro)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(91)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(519, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 41);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Mercado.Properties.Resources.icons8_inversión_30;
            this.pictureBox1.Location = new System.Drawing.Point(70, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Ventas";
            // 
            // panelareaventas
            // 
            this.panelareaventas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelareaventas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelareaventas.Controls.Add(this.button1);
            this.panelareaventas.Controls.Add(this.label6);
            this.panelareaventas.Controls.Add(this.labelprecio);
            this.panelareaventas.Controls.Add(this.botonBuscar);
            this.panelareaventas.Controls.Add(this.listadesplegableventas);
            this.panelareaventas.Controls.Add(this.barracantidad);
            this.panelareaventas.Controls.Add(this.label5);
            this.panelareaventas.Controls.Add(this.label4);
            this.panelareaventas.Controls.Add(this.label3);
            this.panelareaventas.Location = new System.Drawing.Point(352, 147);
            this.panelareaventas.Name = "panelareaventas";
            this.panelareaventas.Size = new System.Drawing.Size(633, 110);
            this.panelareaventas.TabIndex = 1;
            this.panelareaventas.Tag = "ss";
            // 
            // button1
            // 
            this.button1.Image = global::Mercado.Properties.Resources.icons8_actualizar_14;
            this.button1.Location = new System.Drawing.Point(304, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 21);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(451, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "AR$";
            // 
            // labelprecio
            // 
            this.labelprecio.AutoSize = true;
            this.labelprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprecio.Location = new System.Drawing.Point(487, 50);
            this.labelprecio.Name = "labelprecio";
            this.labelprecio.Size = new System.Drawing.Size(52, 18);
            this.labelprecio.TabIndex = 6;
            this.labelprecio.Text = "label6";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(339, 10);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(72, 21);
            this.botonBuscar.TabIndex = 5;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // listadesplegableventas
            // 
            this.listadesplegableventas.FormattingEnabled = true;
            this.listadesplegableventas.Location = new System.Drawing.Point(148, 9);
            this.listadesplegableventas.Name = "listadesplegableventas";
            this.listadesplegableventas.Size = new System.Drawing.Size(150, 21);
            this.listadesplegableventas.TabIndex = 4;
            this.listadesplegableventas.SelectedIndexChanged += new System.EventHandler(this.listadesplegableventas_SelectedIndexChanged);
            // 
            // barracantidad
            // 
            this.barracantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barracantidad.Location = new System.Drawing.Point(90, 50);
            this.barracantidad.Name = "barracantidad";
            this.barracantidad.Size = new System.Drawing.Size(67, 20);
            this.barracantidad.TabIndex = 3;
            this.barracantidad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Precio Total :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cantidad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Producto / Codigo :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Area de ventas";
            // 
            // panelregistro
            // 
            this.panelregistro.AllowUserToDeleteRows = false;
            this.panelregistro.AllowUserToResizeColumns = false;
            this.panelregistro.AllowUserToResizeRows = false;
            this.panelregistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelregistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.panelregistro.BackgroundColor = System.Drawing.Color.MintCream;
            this.panelregistro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelregistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panelregistro.Location = new System.Drawing.Point(352, 349);
            this.panelregistro.MultiSelect = false;
            this.panelregistro.Name = "panelregistro";
            this.panelregistro.ReadOnly = true;
            this.panelregistro.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.panelregistro.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.panelregistro.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(91)))));
            this.panelregistro.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.panelregistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.panelregistro.Size = new System.Drawing.Size(761, 238);
            this.panelregistro.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Buscar Registros por :";
            // 
            // barrabuscarregistro
            // 
            this.barrabuscarregistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barrabuscarregistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barrabuscarregistro.Location = new System.Drawing.Point(363, 17);
            this.barrabuscarregistro.Name = "barrabuscarregistro";
            this.barrabuscarregistro.Size = new System.Drawing.Size(162, 20);
            this.barrabuscarregistro.TabIndex = 15;
            this.barrabuscarregistro.TextChanged += new System.EventHandler(this.barrabuscarregistro_TextChanged);
            // 
            // botonbuscarregistro
            // 
            this.botonbuscarregistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonbuscarregistro.Location = new System.Drawing.Point(531, 17);
            this.botonbuscarregistro.Name = "botonbuscarregistro";
            this.botonbuscarregistro.Size = new System.Drawing.Size(92, 22);
            this.botonbuscarregistro.TabIndex = 16;
            this.botonbuscarregistro.Text = "Buscar";
            this.botonbuscarregistro.UseVisualStyleBackColor = true;
            this.botonbuscarregistro.Click += new System.EventHandler(this.botonbuscarregistro_Click);
            // 
            // desplegablebuscarregistro
            // 
            this.desplegablebuscarregistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.desplegablebuscarregistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.desplegablebuscarregistro.FormattingEnabled = true;
            this.desplegablebuscarregistro.Location = new System.Drawing.Point(252, 17);
            this.desplegablebuscarregistro.Name = "desplegablebuscarregistro";
            this.desplegablebuscarregistro.Size = new System.Drawing.Size(100, 21);
            this.desplegablebuscarregistro.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.desplegablebuscarregistro);
            this.panel2.Controls.Add(this.barrabuscarregistro);
            this.panel2.Controls.Add(this.botonbuscarregistro);
            this.panel2.Location = new System.Drawing.Point(352, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 57);
            this.panel2.TabIndex = 18;
            // 
            // botoneliminarregistro
            // 
            this.botoneliminarregistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botoneliminarregistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(91)))));
            this.botoneliminarregistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botoneliminarregistro.FlatAppearance.BorderSize = 0;
            this.botoneliminarregistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(91)))));
            this.botoneliminarregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoneliminarregistro.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoneliminarregistro.ForeColor = System.Drawing.Color.White;
            this.botoneliminarregistro.Image = global::Mercado.Properties.Resources.icons8_eliminar_papelera_20;
            this.botoneliminarregistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botoneliminarregistro.Location = new System.Drawing.Point(1003, 190);
            this.botoneliminarregistro.Name = "botoneliminarregistro";
            this.botoneliminarregistro.Size = new System.Drawing.Size(110, 28);
            this.botoneliminarregistro.TabIndex = 13;
            this.botoneliminarregistro.Text = "  Eliminar";
            this.botoneliminarregistro.UseVisualStyleBackColor = false;
            this.botoneliminarregistro.Click += new System.EventHandler(this.botoneliminarregistro_Click);
            // 
            // cancelarnuevoarticulo
            // 
            this.cancelarnuevoarticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelarnuevoarticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(91)))));
            this.cancelarnuevoarticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarnuevoarticulo.FlatAppearance.BorderSize = 0;
            this.cancelarnuevoarticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(91)))));
            this.cancelarnuevoarticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarnuevoarticulo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarnuevoarticulo.ForeColor = System.Drawing.Color.White;
            this.cancelarnuevoarticulo.Image = global::Mercado.Properties.Resources.icons8_multiplicar_20;
            this.cancelarnuevoarticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarnuevoarticulo.Location = new System.Drawing.Point(1003, 229);
            this.cancelarnuevoarticulo.Name = "cancelarnuevoarticulo";
            this.cancelarnuevoarticulo.Size = new System.Drawing.Size(110, 28);
            this.cancelarnuevoarticulo.TabIndex = 10;
            this.cancelarnuevoarticulo.Text = "  Cancelar";
            this.cancelarnuevoarticulo.UseVisualStyleBackColor = false;
            this.cancelarnuevoarticulo.Click += new System.EventHandler(this.cancelarnuevoarticulo_Click);
            // 
            // agregarnuevoarticulo
            // 
            this.agregarnuevoarticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.agregarnuevoarticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(91)))));
            this.agregarnuevoarticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarnuevoarticulo.FlatAppearance.BorderSize = 0;
            this.agregarnuevoarticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(91)))));
            this.agregarnuevoarticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarnuevoarticulo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarnuevoarticulo.ForeColor = System.Drawing.Color.White;
            this.agregarnuevoarticulo.Image = global::Mercado.Properties.Resources.icons8_más_20;
            this.agregarnuevoarticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarnuevoarticulo.Location = new System.Drawing.Point(1003, 147);
            this.agregarnuevoarticulo.Name = "agregarnuevoarticulo";
            this.agregarnuevoarticulo.Size = new System.Drawing.Size(110, 28);
            this.agregarnuevoarticulo.TabIndex = 9;
            this.agregarnuevoarticulo.Text = " Agregar";
            this.agregarnuevoarticulo.UseVisualStyleBackColor = false;
            this.agregarnuevoarticulo.Click += new System.EventHandler(this.agregarnuevoarticulo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(91)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.labelFecha);
            this.panel3.Controls.Add(this.horaregistros);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 601);
            this.panel3.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(23, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha actual :";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(91)))));
            this.panel4.Location = new System.Drawing.Point(15, 562);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 4);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(91)))));
            this.panel5.Location = new System.Drawing.Point(15, 447);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 4);
            this.panel5.TabIndex = 9;
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFecha.Location = new System.Drawing.Point(157, 523);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(60, 24);
            this.labelFecha.TabIndex = 12;
            this.labelFecha.Text = "label8";
            // 
            // horaregistros
            // 
            this.horaregistros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.horaregistros.AutoSize = true;
            this.horaregistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaregistros.ForeColor = System.Drawing.SystemColors.Control;
            this.horaregistros.Location = new System.Drawing.Point(84, 471);
            this.horaregistros.Name = "horaregistros";
            this.horaregistros.Size = new System.Drawing.Size(100, 37);
            this.horaregistros.TabIndex = 7;
            this.horaregistros.Text = "label1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::Mercado.Properties.Resources.Captura_de_pantalla_2024_07_23_190807_Photoroom;
            this.pictureBox3.Location = new System.Drawing.Point(0, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(276, 226);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // timerregistros
            // 
            this.timerregistros.Enabled = true;
            this.timerregistros.Tick += new System.EventHandler(this.timerregistros_Tick);
            // 
            // RegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 601);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.botoneliminarregistro);
            this.Controls.Add(this.cancelarnuevoarticulo);
            this.Controls.Add(this.agregarnuevoarticulo);
            this.Controls.Add(this.panelregistro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelareaventas);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1189, 640);
            this.Name = "RegistroVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroVentas";
            this.Load += new System.EventHandler(this.RegistroVentas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelareaventas.ResumeLayout(false);
            this.panelareaventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelregistro)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelareaventas;
        private System.Windows.Forms.TextBox barracantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listadesplegableventas;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Label labelprecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView panelregistro;
        private System.Windows.Forms.Button agregarnuevoarticulo;
        private System.Windows.Forms.Button cancelarnuevoarticulo;
        private System.Windows.Forms.Button botoneliminarregistro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox barrabuscarregistro;
        private System.Windows.Forms.Button botonbuscarregistro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox desplegablebuscarregistro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label horaregistros;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timerregistros;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label7;
    }
}