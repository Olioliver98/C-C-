using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Datos Datoo = new Datos();

            string Opcion = "";

            Console.WriteLine("     Este programa muestra los Animales y sus caracteristicas");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Escoja sobre que animal desea informacion");
            Console.WriteLine("1. Animales Mamiferos");
            Console.WriteLine("2. Animales Volares");
            Console.WriteLine("3. Animales Acuaticos");
            Console.WriteLine();
            Opcion = Console.ReadLine();

            switch (Opcion)
            {
                case "3":   
                Datoo.AnimalesAcuaticos();
                 break;
                



            }







        }




    }



}