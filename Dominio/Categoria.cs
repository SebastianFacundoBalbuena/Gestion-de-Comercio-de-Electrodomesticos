using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        // Atributo
        private int id;
        private string categoria;

        // Metodo

        public string Categorias
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public override string ToString()
        {
            return categoria;
        }
    }
}
