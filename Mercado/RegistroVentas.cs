using Controllers;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado
{
    public partial class RegistroVentas : Form
    {
        private Articulos art = null;
        public RegistroVentas()
        {
           
            InitializeComponent();
        }







        // carga el desplegable con los datos

        private void CargarLista() 
        {
            try
            {
                Controler control = new Controler();
                List<Articulos> articulos = new List<Articulos>();


                articulos = control.listar();
                listadesplegableventas.DataSource = null;
                listadesplegableventas.DataSource = articulos;
                listadesplegableventas.DisplayMember = "Nombre";

                this.art = articulos.Find(x => x.Nombre.ToUpper() == listadesplegableventas.Text.ToUpper());
                if (this.art != null)
                    labelprecio.Text = this.art.Precio.ToString();



                List<RegistroDeVentas> registro = new List<RegistroDeVentas>();
                registro = control.Registro();
                panelregistro.DataSource = null;
                panelregistro.DataSource = registro;
                panelregistro.Columns["ID"].Visible = false;
                panelregistro.Columns["Precio"].HeaderText = "Precio Total";
                panelregistro.Columns["Fecha"].HeaderText = "Fecha de venta";

                if (barracantidad.Text == "")
                    barracantidad.Text = "1";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error: " +  ex);
            }
        }
        private void RegistroVentas_Load(object sender, EventArgs e)
        {

            CargarLista();

            // desplegable de buscar registro x
            
            desplegablebuscarregistro.Items.Add("  Mes");
            desplegablebuscarregistro.Items.Add("  Año");
            desplegablebuscarregistro.Items.Add(" Dia-Mes-Año ");
            desplegablebuscarregistro.Text = desplegablebuscarregistro.Items[2].ToString();




        }

        // carga el desplegable con los datos a buscar...
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            Controler control = new Controler();
            List<Articulos> articulo;




            try
            {
                if (listadesplegableventas.Text != "")
                {
                    articulo = control.listar().FindAll(x => x.Nombre.ToUpper().Contains(listadesplegableventas.Text.ToUpper()) || x.Codigo.ToUpper() == listadesplegableventas.Text.ToUpper());

                  
                    listadesplegableventas.DataSource = null;
                    listadesplegableventas.DataSource = articulo;
                    listadesplegableventas.DroppedDown = true;
                    listadesplegableventas.DisplayMember = "Nombre";

                    
                    this.art = articulo.Find(x => x.Nombre.ToUpper() == listadesplegableventas.Text.ToUpper());

                    if(this.art != null)
                    labelprecio.Text = this.art.Precio.ToString();

                    


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error : " + ex);
            }


            
        }


        // Colocar precio del art al seleccionar uno
        private void listadesplegableventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controler controler = new Controler();
            this.art = controler.listar().Find(x => x.Nombre == listadesplegableventas.Text);
            try
            {
                if(this.art != null)
                {
                  
                   decimal precio = this.art.Precio;
                    
                   labelprecio.Text = precio.ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error : " + ex);
            }
            

        }


        // Calcular el precio x cantidad
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {


                if(this.art != null)
                {

                    decimal precio = this.art.Precio;

                    string cantidad = barracantidad.Text;

                    if (barracantidad.Text != "")
                    {
                        decimal resultado = precio * decimal.Parse(cantidad);
                        labelprecio.Text = resultado.ToString();
                    }
                    else if(barracantidad.Text == "" || barracantidad.Text == null)
                    {

                        labelprecio.Text = precio.ToString();

                    }
                }

            }
            catch (Exception ex)
            {


                MessageBox.Show("Hubo un error : " + ex);
            }




        }


        private void cancelarnuevoarticulo_Click(object sender, EventArgs e)
        {
            Close();
        }


        //agregar registro: 
        private void agregarnuevoarticulo_Click(object sender, EventArgs e)
        {
            Controler control = new Controler();
            RegistroDeVentas newRegistro = new RegistroDeVentas();


            try
            {

                   
                    newRegistro.Producto = this.art.Nombre;
                    newRegistro.Codigo = this.art.Codigo;
                    
                    if(barracantidad.Text != "")
                    {
                       newRegistro.Cantidad = int.Parse(barracantidad.Text);
                    }
                    else
                    {
                       newRegistro.Cantidad = 1;
                    }
                    
                    DateTime fecha = DateTime.Parse(labelFecha.Text);
                   newRegistro.Fecha = fecha.ToString("yyyy-MM-dd");
                   newRegistro.Precio = decimal.Parse(labelprecio.Text);

                    control.Nuevoregistro(newRegistro);
                MessageBox.Show("¡Agregado exitosamente!");
                barracantidad.Text = "1";
                    CargarLista();

                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error : " + ex);
            }


        }
         

        //eliminar registro
        private void botoneliminarregistro_Click(object sender, EventArgs e)
        {
            Controler control = new Controler();

            RegistroDeVentas articulo;
            try
            {


                if( panelregistro.CurrentRow != null)
                {

                    DialogResult resultado = MessageBox.Show("Desea eliminar este articulo ?", "Eliminar", MessageBoxButtons.YesNo);
                    if (resultado != DialogResult.No)
                    {


                        articulo = (RegistroDeVentas)panelregistro.CurrentRow.DataBoundItem;

                        if (articulo != null)
                        {
                            control.EliminarRegistro(articulo.ID);
                            MessageBox.Show("¡Eliminado exitosamente!");
                            CargarLista();
                        }


                    }

                }
                else
                {
                    MessageBox.Show("No hay un elemento seleccionado...");
                }
 
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        //Buscar productos x fecha de venta
        private void botonbuscarregistro_Click(object sender, EventArgs e)
        {
            try
            {
                Controler control = new Controler();
                List<RegistroDeVentas> oldRegistros = new List<RegistroDeVentas>();
                List<RegistroDeVentas> newregistros = new List<RegistroDeVentas>();

                oldRegistros = control.Registro();

                if (desplegablebuscarregistro.Text == " Dia-Mes-Año ")
                {

                    foreach (var item in oldRegistros)
                    {
                        if (item.Fecha.ToString() == barrabuscarregistro.Text.ToString())
                        {
                            newregistros.Add(item);
                        }
                    }

                } else if(desplegablebuscarregistro.Text == "  Mes")
                {
                    foreach (var item in oldRegistros)
                    {
                        string mes = "-"+barrabuscarregistro.Text+"-";
                        if (item.Fecha.ToString().Contains(mes))
                        {
                            newregistros.Add(item);
                        }
                    }
                }else if(desplegablebuscarregistro.Text == "  Año")
                {
                    foreach (var item in oldRegistros)
                    {
                        string año = "-" + barrabuscarregistro.Text + "";
                        if (item.Fecha.ToString().Contains(año))
                        {
                            newregistros.Add(item);
                        }
                    }
                }



                if(newregistros.Count != 0)
                {
                    MessageBox.Show("¡Registros actualizados!");
                   panelregistro.DataSource = newregistros;
                }
                else
                {
                    MessageBox.Show("No se han encontrado REGISTROS o el formato ingresado no es VALIDO");
                    barrabuscarregistro.Text = "";
                    CargarLista();
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error : " + ex);
            }
        }

        // evento barra vacia de buscar registros
        private void barrabuscarregistro_TextChanged(object sender, EventArgs e)
        {
            Controler control = new Controler();
            if (barrabuscarregistro.Text == "")
                panelregistro.DataSource = control.Registro();
        }

        // boton refresh art en registros
        private void button1_Click(object sender, EventArgs e)
        {
            CargarLista(); 
        }

        private void timerregistros_Tick(object sender, EventArgs e)
        {
            horaregistros.Text = DateTime.Now.ToString("HH:mm");
            labelFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");


        }


    }
}
