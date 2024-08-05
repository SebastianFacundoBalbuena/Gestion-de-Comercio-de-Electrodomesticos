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

namespace Mercado
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }



        // te lleva a la ventana productos
        private void botonproductos_Click(object sender, EventArgs e)
        {
            Formulario2 formulario2 = new Formulario2();
            formulario2.ShowDialog();
        }


        // te muestra hora/fecha
        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString("HH:mm");
            fecha.Text = DateTime.Now.ToLongDateString();   
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonventas_Click(object sender, EventArgs e)
        {
            RegistroVentas registro = new RegistroVentas();
            registro.ShowDialog();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.ShowDialog();
        }
    }
}
