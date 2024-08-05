using Controllers;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercado;
using System.Runtime.InteropServices;


namespace Mercado
{
    public partial class FormularioAgregar : Form
    {

        // Nos ayudara a saber si un art se modifica o se agrega
        // dependiendo de si tiene o no id
        private Articulos articulo = null;
        public FormularioAgregar()
        {
            InitializeComponent();
        }

        
        // Si recibe un art, hay art para Modificar 
        public FormularioAgregar(Articulos articulo)
        {
            this.articulo = articulo; 
            InitializeComponent();
            
        }

        private void cancelarnuevoarticulo_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Agregar Articulo/ Modificar art
        private void agregarnuevoarticulo_Click(object sender, EventArgs e)
        {
            Controler control = new Controler();

            Categoria categoria = new Categoria();
            Marca marca = new Marca();

            try
            {

                // Si es null, sera metodo agregar, caso contrario sera Modificar
                if (articulo == null)
                    articulo = new Articulos(categoria, marca);


                   // Validaciones
                   if (!(barranombre.Text == "" || barracodigo.Text == "" || barraprecio.Text == ""))
                   {

                    articulo.Codigo = barracodigo.Text.ToString();
                    articulo.Nombre = barranombre.Text;
                    articulo.Precio = decimal.Parse(barraprecio.Text);
                    articulo.Descripcion = barradescripcion.Text;
                    articulo.Imagen = barraimagen.Text;
                    categoria.Id = ((Categoria)barracategoria.SelectedItem).Id;
                    marca.Id = ((Marca)barramarca.SelectedItem).Id;

                      if (articulo.Id != 0)
                      {
                        control.Modificar(articulo, categoria, marca);
                        MessageBox.Show("Modificado exitosamente!");
                        
                      }
                      else
                      {
                        control.Agregar(articulo, categoria, marca);
                        MessageBox.Show("Agregado exitosamente!");
                      }

                    Close();

                    }
                    else
                    {
                        // Validacion agregado
                    if (this.articulo.Id == 0)
                    {

                        FormularioAgregar agregar = new FormularioAgregar();
                        Close();

                        if (barranombre.Text == "")
                            agregar.barranombre.BackColor = Color.IndianRed;
                        if (barracodigo.Text == "")
                            agregar.barracodigo.BackColor = Color.IndianRed;
                        if (barraprecio.Text == "")
                            agregar.barraprecio.BackColor = Color.IndianRed;

                        if (barranombre.Text == "" && barracodigo.Text == "" && barraprecio.Text == "")
                        {
                            agregar.barranombre.BackColor = Color.IndianRed;
                            agregar.barracodigo.BackColor = Color.IndianRed;
                            agregar.barraprecio.BackColor = Color.IndianRed;

                        }


                        agregar.barracodigo.Text = barracodigo.Text;
                        agregar.barranombre.Text = barranombre.Text;
                        agregar.barraimagen.Text = barraimagen.Text;
                        agregar.barraprecio.Text = barraprecio.Text;
                        agregar.barradescripcion.Text = barradescripcion.Text;




                        agregar.ShowDialog();


                    }
                      //Validacion Modificar
                    else if(articulo.Id != 0)
                    {
                        FormularioAgregar agregar = new FormularioAgregar(articulo);
                        Close();

                        if (barranombre.Text == "")
                            agregar.barranombre.BackColor = Color.IndianRed;
                        if (barracodigo.Text == "")
                            agregar.barracodigo.BackColor = Color.IndianRed;
                        if (barraprecio.Text == "")
                            agregar.barraprecio.BackColor = Color.IndianRed;

                        if (barranombre.Text == "" && barracodigo.Text == "" && barraprecio.Text == "")
                        {
                            agregar.barranombre.BackColor = Color.IndianRed;
                            agregar.barracodigo.BackColor = Color.IndianRed;
                            agregar.barraprecio.BackColor = Color.IndianRed;

                        }







                        agregar.ShowDialog();
                    }


                }


            }
            catch (Exception)
            {

                MessageBox.Show("Solo numeros sin coma : ( , )");
            } 


        }
         

        // Mostrar datos en las barras Categoria, Marca y en general
        private void FormularioAgregar_Load(object sender, EventArgs e)
        {
            Controler control = new Controler();
            Formulario2 formilario = new Formulario2();
            List<Categoria> categoria = control.CategoriaLista();   
            List<Marca> marca = control.MarcaListar();


           
            barracategoria.DataSource = categoria;

            barramarca.DataSource = marca;


            //Mostra datos si se ha marcado la opcion MODIFICAR
            if(this.articulo != null)
            {

                try
                {
                barracodigo.Text = articulo.Codigo;
                barranombre.Text = articulo.Nombre;
                barradescripcion.Text = articulo.Descripcion;
                if (articulo.Imagen != "")
                {
                    imagenAgregar.Load(articulo.Imagen);
                }
                else
                {
                    imagenAgregar.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSi6dicyRXDD9U9eeuelNPyB8lh-dImHhiEvQ&s");
                }
                barraimagen.Text = articulo.Imagen;
                barraprecio.Text = articulo.Precio.ToString("0.##");
                barracategoria.Text = articulo.Categoria;
                barramarca.Text = articulo.Marca;
                }
                catch (Exception )
                {

                    imagenAgregar.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSi6dicyRXDD9U9eeuelNPyB8lh-dImHhiEvQ&s");
                    MessageBox.Show("Error al cargar imagen");
                }

            }
            
            
        }


        //mostrar imagen 
        private void barraimagen_Leave(object sender, EventArgs e)
        {
            try
            {
                
                imagenAgregar.Load(barraimagen.Text);
            }
            catch (Exception)
            {

                imagenAgregar.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSi6dicyRXDD9U9eeuelNPyB8lh-dImHhiEvQ&s");
            }
        }


    }
}
