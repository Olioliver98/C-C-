
using System;

namespace Funciocnes
{
    class program
    {
        static void Main(string[] arg)
        {
            Alumno a = new Alumno(1, "Juan", "Perez");
            Alumno b = new Alumno(2, "Maria", "Martinez");

            a.inactivarAlumno();

            Console.WriteLine(a.nombrecompleto());
            Console.WriteLine(b.nombrecompleto());

            a.activarAlumno();

            Console.WriteLine("");

            Console.WriteLine(a.nombrecompleto());
            Console.WriteLine(b.nombrecompleto());
        }

    }



}