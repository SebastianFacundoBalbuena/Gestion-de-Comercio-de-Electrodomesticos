using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {

        // Atributos
        private int id;
        private string marca;

        // Metodo

        public string Marcas
        {
            get { return marca; }
            set { marca = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public override string ToString()
        {
            return marca;
        }
    }
}
