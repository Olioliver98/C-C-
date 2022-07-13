using System;

namespace Propiedades
{
    class program
    {

        static void Main(string[] arg)
        {
            //Instancia
            Alumno a = new Alumno();
            a.Id = 1;
            a.PrimerNombre = "Juan";
            a.SegundoNombre = "Perez";

            Console.WriteLine("Hello, World!");

        }

    }



}