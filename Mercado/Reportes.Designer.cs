namespace Mercado
{
    partial class Reportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.leyendaPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.desplegableaños = new System.Windows.Forms.ComboBox();
            this.panelreportes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.fechareportes = new System.Windows.Forms.Label();
            this.horareportes = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timerreportes = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).BeginInit();
            this.panel2.SuspendLayout();
            this.leyendaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelreportes)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(546, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 43);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Mercado.Properties.Resources.icons8_ventas_totales_25;
            this.pictureBox1.Location = new System.Drawing.Point(65, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes de Ventas";
            // 
            // chartVentas
            // 
            this.chartVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartVentas.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartVentas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVentas.Legends.Add(legend1);
            this.chartVentas.Location = new System.Drawing.Point(3, 3);
            this.chartVentas.Name = "chartVentas";
            this.chartVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chartVentas.Size = new System.Drawing.Size(602, 398);
            this.chartVentas.TabIndex = 2;
            this.chartVentas.Text = "chart1";
            title1.Name = "Ventas";
            this.chartVentas.Titles.Add(title1);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.leyendaPanel);
            this.panel2.Controls.Add(this.chartVentas);
            this.panel2.Location = new System.Drawing.Point(304, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 408);
            this.panel2.TabIndex = 3;
            // 
            // leyendaPanel
            // 
            this.leyendaPanel.Controls.Add(this.flowLayoutPanel2);
            this.leyendaPanel.Location = new System.Drawing.Point(503, 26);
            this.leyendaPanel.Name = "leyendaPanel";
            this.leyendaPanel.Size = new System.Drawing.Size(89, 296);
            this.leyendaPanel.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(59, 8);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtrar por año :";
            // 
            // desplegableaños
            // 
            this.desplegableaños.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.desplegableaños.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.desplegableaños.FormattingEnabled = true;
            this.desplegableaños.Location = new System.Drawing.Point(122, 9);
            this.desplegableaños.Name = "desplegableaños";
            this.desplegableaños.Size = new System.Drawing.Size(82, 21);
            this.desplegableaños.TabIndex = 5;
            this.desplegableaños.SelectedValueChanged += new System.EventHandler(this.desplegableaños_SelectedValueChanged);
            // 
            // panelreportes
            // 
            this.panelreportes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelreportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.panelreportes.BackgroundColor = System.Drawing.Color.MintCream;
            this.panelreportes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelreportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panelreportes.Location = new System.Drawing.Point(922, 163);
            this.panelreportes.Name = "panelreportes";
            this.panelreportes.ReadOnly = true;
            this.panelreportes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.panelreportes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.panelreportes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(91)))));
            this.panelreportes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.panelreportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.panelreportes.Size = new System.Drawing.Size(367, 403);
            this.panelreportes.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(921, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Detalles :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(91)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.fechareportes);
            this.panel3.Controls.Add(this.horareportes);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 608);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(91)))));
            this.panel4.Location = new System.Drawing.Point(12, 575);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 4);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(91)))));
            this.panel5.Location = new System.Drawing.Point(12, 460);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 4);
            this.panel5.TabIndex = 9;
            // 
            // fechareportes
            // 
            this.fechareportes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fechareportes.AutoSize = true;
            this.fechareportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechareportes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fechareportes.Location = new System.Drawing.Point(24, 546);
            this.fechareportes.Name = "fechareportes";
            this.fechareportes.Size = new System.Drawing.Size(51, 20);
            this.fechareportes.TabIndex = 12;
            this.fechareportes.Text = "label8";
            // 
            // horareportes
            // 
            this.horareportes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.horareportes.AutoSize = true;
            this.horareportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horareportes.ForeColor = System.Drawing.SystemColors.Control;
            this.horareportes.Location = new System.Drawing.Point(81, 484);
            this.horareportes.Name = "horareportes";
            this.horareportes.Size = new System.Drawing.Size(100, 37);
            this.horareportes.TabIndex = 7;
            this.horareportes.Text = "label1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::Mercado.Properties.Resources.Captura_de_pantalla_2024_07_23_190807_Photoroom;
            this.pictureBox3.Location = new System.Drawing.Point(2, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(276, 226);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // timerreportes
            // 
            this.timerreportes.Enabled = true;
            this.timerreportes.Tick += new System.EventHandler(this.timerreportes_Tick);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.desplegableaños);
            this.panel6.Location = new System.Drawing.Point(304, 109);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(214, 39);
            this.panel6.TabIndex = 21;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 608);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelreportes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1314, 597);
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.leyendaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelreportes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox desplegableaños;
        private System.Windows.Forms.DataGridView panelreportes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label fechareportes;
        private System.Windows.Forms.Label horareportes;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timerreportes;
        private System.Windows.Forms.FlowLayoutPanel leyendaPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
    }
}