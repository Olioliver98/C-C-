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

            Alumno b = new Alumno();
            b.Id = 2;
            b.PrimerNombre = "Maria";
            b.SegundoNombre = "Martinez";

            Alumno c = new Alumno(3);
            c.PrimerNombre = "Pedro";
            

            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);

        }

    }



}