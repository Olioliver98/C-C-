
using System;

namespace Funciocnes
{
    class program
    {
        static void Main(string[] arg)
        {
            Alumno a = new Alumno(1, "Juan", "Perez");
            Console.WriteLine(a.nombrecompleto());
        }

    }



}