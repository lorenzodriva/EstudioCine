using EstudioCine;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Actor actor1 = new Actor("Ricardo Darin");
        Actor actor2 = new Actor("Guillermo Francella");
        Actor actor3 = new Actor("Adrian Suar");
        Actor actor4 = new Actor("Dario Grandinetti");
        Actor actor5 = new Actor("Adam Sandler");
        List<Actor> listaActores = new List<Actor>();
        listaActores.Add(actor1);
        listaActores.Add(actor4);

        Director director1 = new Director("Damian Szifron");
        Director director2 = new Director("Cristopher Nolan");
        List<Director> listaDirectores = new List<Director>()
        { 
            new Director("James Cameron"),
            new Director("Steven Spielberg")
        };

        Pelicula pelicula1 = new Pelicula("Relatos Salvajes", Genero.Drama, "21/8/2014", director1 , listaActores );
        pelicula1.MostrarDetalles();


    }
}