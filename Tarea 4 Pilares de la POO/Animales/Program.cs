using System;

namespace Animales
{

    public class Program
    {
        static void Main(string[] arg)
        {
            BaseDatos BaseA = new BaseDatos();

            string Opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("     Wiki de Animales    ");
                Console.WriteLine("----------------------------");
                Console.WriteLine("");
                Console.WriteLine("1. Animales Mamiferos");
                Console.WriteLine("2. Animales Aereos");
                Console.WriteLine("3. Animales Acuaticos");
                Console.WriteLine("0. Salir del Programa");
                Console.WriteLine("");
                Opcion = Console.ReadLine();

                switch (Opcion)
                {
                    case "1":
                        BaseA.FuncionMamiferos();
                        break;

                    case "2":
                        BaseA.FuncionAves();
                        break;
                    
                    case "3":
                        BaseA.FuncionAcuatica();
                        break;    
                }    

                if ( Opcion == "0")
                {
                    break;
                }


            }
        }
    }
}