namespace Mercado
{
    partial class VerDetalles
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.detalles = new System.Windows.Forms.Label();
            this.paneldetalles = new System.Windows.Forms.ListView();
            this.imagendetalle = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagendetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.detalles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 63);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mercado.Properties.Resources.icons8_formularios_de_google_301;
            this.pictureBox1.Location = new System.Drawing.Point(217, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // detalles
            // 
            this.detalles.AutoSize = true;
            this.detalles.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalles.ForeColor = System.Drawing.Color.White;
            this.detalles.Location = new System.Drawing.Point(265, 18);
            this.detalles.Name = "detalles";
            this.detalles.Size = new System.Drawing.Size(116, 28);
            this.detalles.TabIndex = 13;
            this.detalles.Text = "Detalles";
            // 
            // paneldetalles
            // 
            this.paneldetalles.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneldetalles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.paneldetalles.HideSelection = false;
            this.paneldetalles.Location = new System.Drawing.Point(12, 95);
            this.paneldetalles.MultiSelect = false;
            this.paneldetalles.Name = "paneldetalles";
            this.paneldetalles.Size = new System.Drawing.Size(354, 228);
            this.paneldetalles.TabIndex = 3;
            this.paneldetalles.TabStop = false;
            this.paneldetalles.UseCompatibleStateImageBehavior = false;
            this.paneldetalles.View = System.Windows.Forms.View.Tile;
            this.paneldetalles.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.paneldetalles_ItemSelectionChanged);
            // 
            // imagendetalle
            // 
            this.imagendetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagendetalle.Location = new System.Drawing.Point(385, 123);
            this.imagendetalle.Name = "imagendetalle";
            this.imagendetalle.Size = new System.Drawing.Size(214, 184);
            this.imagendetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagendetalle.TabIndex = 1;
            this.imagendetalle.TabStop = false;
            // 
            // VerDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 346);
            this.Controls.Add(this.paneldetalles);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imagendetalle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.VerDetalles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagendetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox imagendetalle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView paneldetalles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label detalles;
    }
}