
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using DataBase;
using Dominio;



namespace Mercado
{
    public partial class Formulario2 : Form
    {
        List<Articulos>ListaElectronica = new List<Articulos>();
        public Formulario2()
        {
            InitializeComponent();
        }



        // metodo carga de articulos al iniciar programa
        private void Formulario2_Load(object sender, EventArgs e)
        {
            CargarFormulario();

            
        }


        // metodo de carga de articulos 
        private void CargarFormulario() 
        {
            Controler controler = new Controler();
            ListaElectronica = controler.listar();
            panelformulario2.DataSource = ListaElectronica;
            panelformulario2.Columns["Imagen"].Visible = false;
            panelformulario2.Columns["id"].Visible = false;
           
            fotos.Load(ListaElectronica[0].Imagen);
        }


        // Carga la imagen del articulo en el formulario
        private void panelformulario2_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                if(panelformulario2.CurrentRow != null)
                {
                Articulos seleccionado = (Articulos)panelformulario2.CurrentRow.DataBoundItem;
                fotos.Load(seleccionado.Imagen);
                }

            }
            catch (Exception )
            {

                fotos.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSi6dicyRXDD9U9eeuelNPyB8lh-dImHhiEvQ&s");
            }
        }


        //Metodo mostrar pantalla de agregado de art
        private void botonagregar_Click(object sender, EventArgs e)
        {
            FormularioAgregar newFor = new FormularioAgregar(); 
            newFor.ShowDialog();
            barrabusqueda.Text = "";
            CargarFormulario();
        }


        // metodo eliminar art
        private void botoneliminar_Click(object sender, EventArgs e)
        {
            Controler control = new Controler();   
            
            if(panelformulario2.CurrentRow != null && panelformulario2.CurrentRow.DataBoundItem != null)
            {
               Articulos articulo = (Articulos)panelformulario2.CurrentRow.DataBoundItem;

                try
                {
                    DialogResult respuesta = MessageBox.Show("Desea eliminar el articulo ?", "Eliminar", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        control.Eliminar(articulo.Id);
                        barrabusqueda.Text = "";
                        CargarFormulario();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hubo un error : " + ex + " Contactese con el desarrollador.");
                }
            }
            else
            {
                MessageBox.Show("No hay ningun elemento seleccionado para eliminar");
            }
            


            
        }


        // metodo modificar art
        private void botonmodificar_Click(object sender, EventArgs e)
        {
            Controler control = new Controler();
            if(panelformulario2.CurrentRow != null && panelformulario2.CurrentRow.DataBoundItem != null)
            {

            Articulos articulo = (Articulos)panelformulario2.CurrentRow.DataBoundItem;

            try
            {
                FormularioAgregar Modifica = new FormularioAgregar(articulo);
                Modifica.ShowDialog();
                barrabusqueda.Text = "";
                CargarFormulario();
 
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

            }
            else
            {
                MessageBox.Show("No hay ningun elemento seleccionado para modificar");
            }



        }



        // Mostrar hora/fecha
        private void timer2_Tick(object sender, EventArgs e)
        {
            hora2.Text = DateTime.Now.ToString("hh:mm");
            fecha2.Text = DateTime.Now.ToLongDateString();
        }


        // Metodo filtrar datos escritos por el usuario en barra busqueda
        private void barrabusqueda_TextChanged(object sender, EventArgs e)
        {
            Controler control = new Controler();
            List<Articulos> listaFiltrada;
            


            if(busqueda.Text != "")
            {
                listaFiltrada = control.listar().FindAll(x => x.Nombre.ToUpper().Contains(barrabusqueda.Text.ToUpper()) || x.Categoria.ToUpper() == barrabusqueda.Text.ToUpper() || x.Marca.ToUpper() == barrabusqueda.Text.ToUpper() || x.Codigo.ToUpper() == barrabusqueda.Text.ToUpper());

                panelformulario2.DataSource = null;
                panelformulario2.DataSource = listaFiltrada;
                panelformulario2.Columns["Imagen"].Visible = false;
                panelformulario2.Columns["Id"].Visible = false;
                
                
            }
            else
            {
                panelformulario2.DataSource = null;
                panelformulario2.DataSource = control.listar();
                panelformulario2.Columns["Imagen"].Visible = false;
                panelformulario2.Columns["Id"].Visible = false;
                
            }



        }


        // Metodo seleccion de art y mostrar detalles
        private void botondetalle_Click(object sender, EventArgs e)
        {

            try
            {
                if(panelformulario2.CurrentRow != null && panelformulario2.CurrentRow.DataBoundItem != null)
                {
                    Articulos art = (Articulos)panelformulario2.CurrentRow.DataBoundItem;
                    VerDetalles detalle = new VerDetalles(art);
                    detalle.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Asegurese de seleccionar un articulo... (>)");
                }


            
            }
            catch (Exception ex)
            {

                throw ex;
            }


            
        }
    }
}
