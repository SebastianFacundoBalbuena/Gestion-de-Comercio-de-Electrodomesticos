using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado
{
    public partial class VerDetalles : Form
    {

        private Articulos articulo;
        public VerDetalles()
        {
            InitializeComponent();
        }

        public VerDetalles(Articulos articulo)
        {
            this.articulo = articulo;
            InitializeComponent();
        }


        // Carga los datos del art en la lista
        private void VerDetalles_Load(object sender, EventArgs e)
        {
            try
            {

                
                paneldetalles.Items.Add("Codigo : " + articulo.Codigo);
                paneldetalles.Items.Add("Nombre : " + articulo.Nombre);
                paneldetalles.Items.Add("Marca : " + articulo.Marca);
                paneldetalles.Items.Add("Categoria : " + articulo.Categoria);
                paneldetalles.Items.Add("Descripcion : " + articulo.Descripcion);
                paneldetalles.Items.Add("Precio : " + articulo.Precio);

                if(articulo.Imagen != null && articulo.Imagen != "")
                {
                     imagendetalle.Load(articulo.Imagen);
                }
                else
                {
                    imagendetalle.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSi6dicyRXDD9U9eeuelNPyB8lh-dImHhiEvQ&s");
                }
                
            }
            catch (Exception ex)
            {
                imagendetalle.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSi6dicyRXDD9U9eeuelNPyB8lh-dImHhiEvQ&s");
                MessageBox.Show("Error de imagen ");
            }


            
        }


        // Quita la seleccion en la lista
        private void paneldetalles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            e.Item.Selected = false;
        }
    }


}
