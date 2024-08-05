using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    public class Articulos
    {
        // Atributos 

        private int id;
        private string codigo;
        private string nombre;
        private string descripcion;
        private string imagen;
        private decimal precio;
        private Categoria categoria;
        private Marca marca;

        // constructor

        public Articulos(Categoria categoria, Marca marca)
        {
            this.categoria = categoria;
            this.marca = marca;
        }


        // Metodos 


        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Categoria
        {
            get { return categoria.Categorias; }
        }

        public string Marca
        {
            get { return marca.Marcas; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }

        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }

        }
        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }

        }



    }
}
