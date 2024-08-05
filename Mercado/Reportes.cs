using Controllers;
using DataBase;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Mercado
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        public List<string> CargarDesplegableAños()
        {
            Controler control = new Controler();
            List<RegistroDeVentas> registros = new List<RegistroDeVentas>();
            registros = control.Registro();


            //cargar desplegable de año :
            List<string> Año = new List<string>();

            foreach (var item in registros)
            {
                string años = item.Fecha.Substring(6, 4);
                Año.Add(años);

            }

            List<string> AñosOrdenados = Año.Distinct().Select(int.Parse).OrderByDescending(x => x).Select(x => x.ToString()).ToList();

            return AñosOrdenados;

        }

   
        private void Reportes_Load(object sender, EventArgs e)
        {

            //cargar desplegable de año y PrecioTotal:
            desplegableaños.DataSource = CargarDesplegableAños();
            
            

       
        }



        private void timerreportes_Tick(object sender, EventArgs e)
        {
            horareportes.Text = DateTime.Now.ToString("HH:mm");
            fechareportes.Text = DateTime.Now.ToLongDateString();
        }


        // Reportes por año/mes
        private void desplegableaños_SelectedValueChanged(object sender, EventArgs e)
        {
            List<string> ReportesAños = CargarDesplegableAños();
            Controler control = new Controler();
            List<RegistroDeVentas> registrosXAño = new List<RegistroDeVentas>();
            List<decimal> PrecioXmes = new List<decimal>();


            try
            {

                for (int x = 0; x < ReportesAños.Count; x++)
                {
                    if (desplegableaños.Text == ReportesAños[x].ToString())
                    {
                        string año = "-" + ReportesAños[x].ToString() + "";
                        List<RegistroDeVentas> registros = new List<RegistroDeVentas>();
                        List<RegistroDeVentas> ListaOrdenada = new List<RegistroDeVentas>();
                        registros = control.Registro().FindAll(i => i.Fecha.Contains(año));
                        registrosXAño = registros;
                        ListaOrdenada = registros.OrderBy(r => DateTime.ParseExact(r.Fecha, "dd-MM-yyyy", null).Month).ToList();

                        
                        for (int a = 0; a < 12; a++)
                        {
                            PrecioXmes.Add(0);
                        }


                        for (int i = 0; i < ListaOrdenada.Count; i++)
                        {
                            if (registros[i].Fecha.Contains("-01-"))
                                PrecioXmes[0] += registros[i].Precio;
                            if (registros[i].Fecha.Contains("-02-"))
                                PrecioXmes[1] += registros[i].Precio;
                            if (registros[i].Fecha.Contains("-03-"))
                                PrecioXmes[2] += registros[i].Precio;
                            if (registros[i].Fecha.Contains("-04-"))
                                PrecioXmes[3] += registros[i].Precio;
                            if (registros[i].Fecha.Contains("-05-"))
                                PrecioXmes[4] += registros[i].Precio;
                            if (registros[i].Fecha.Contains("-06-"))
                                PrecioXmes[5] += registros[i].Precio;
                            if (registros[i].Fecha.Contains("-07-"))
                                PrecioXmes[6] += registros[i].Precio;
                            if (registros[i].Fecha.Contains("-08-"))
                                PrecioXmes[7] += registros[i].Precio;
                            if (registros[i].Fecha.Contains("-09-"))
                                PrecioXmes[8] += registros[i].Precio;
                            if (registros[i].Fecha.Contains("-10-"))
                                PrecioXmes[9] += registros[i].Precio;
                            if (registros[i].Fecha.Contains("-11-"))
                                PrecioXmes[10] += registros[i].Precio;
                            if (registros[i].Fecha.Contains("-12-"))
                                PrecioXmes[11] += registros[i].Precio;


                        }




                    }
                }



                chartVentas.Series.Clear();

                Series serieMensual = new Series()
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true
                };

                

                string[] nombresMeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
                Color[] coloresMeses = {
                Color.Red, Color.Orange, Color.DarkKhaki, Color.Green, Color.Blue,
                Color.Indigo, Color.Violet, Color.DeepPink, Color.Cyan, Color.Magenta,
                Color.Brown, Color.Gray
            };
                for (int i = 0; i < 12; i++)
                {

                    serieMensual.Points.AddXY(nombresMeses[i], PrecioXmes[i]);
                    serieMensual.Points[i].Color = coloresMeses[i];
                }
                chartVentas.Series.Add(serieMensual);

                chartVentas.ChartAreas[0].AxisY.Minimum = 0;
                chartVentas.ChartAreas[0].AxisY.Maximum = (double)PrecioXmes.Max() + 1000;

                leyendaPanel.Controls.Clear();
                for (int i = 0; i < 12; i++)
                {
                    Label etiquetaMes = new Label
                    {
                        Text = nombresMeses[i],
                        ForeColor = coloresMeses[i],
                        AutoSize = true,
                        Padding = new Padding(5),
                        Font = new Font("Arial", 8, FontStyle.Bold)
                    };

                    leyendaPanel.Controls.Add(etiquetaMes);
                }


                // Cargar registro x año
                if (registrosXAño.Count != 0)
                {
                    panelreportes.DataSource = registrosXAño;
                    panelreportes.Columns["ID"].Visible = false;
                    panelreportes.Columns["Codigo"].Visible = false;
                    panelreportes.Columns["Cantidad"].Visible = false;
                    panelreportes.Columns["Precio"].Visible = false;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error : " + ex);
            }


           
        }
    }
}
