using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class RegistroDeVentas
    {
        // atributos

        private int id;
        private string codigo;
        private string producto;
        private int cantidad;
        private string fecha;
        private decimal precio;

        // metodos

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
