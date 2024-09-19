using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioCine
{
    public class Actor
    {
        public string Nombre { get; set; }
        public Actor(string nombre)
        {
            Nombre = nombre;
        }
        public string ToString()
        {
            return Nombre;
        }
    }
}
