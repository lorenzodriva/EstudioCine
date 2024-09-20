using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioCine
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public Genero Genero {  get; set; }
        public string FechaEstreno { get; set; }
        public List<Director> Directores { get; set; }
        public List<Actor> Reparto { get; set; }

        public Pelicula(string titulo, Genero genero, string fechaEstreno, Director director, List<Actor> reparto)
        {
            Titulo = titulo;
            Genero = genero;
            FechaEstreno = fechaEstreno;
            Director = director;
            Reparto = reparto;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Titulo: {Titulo} - Genero: {Genero} - Fecha de Estreno: {FechaEstreno} - Director: {Director.Nombre}\nReparto -----------------");
            foreach (Actor actor in Reparto)
            {
                Console.WriteLine( actor.ToString() );
            }
        }
    }
}
