using System;

namespace Millonaire
{
    public class Program
    {

        static void Main(string[] arg)
        {
            Datos Preguntas = new Datos();
            Console.Clear();
            string Name = "";
            string Dificultad = "";

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                             ¡ Q U I E N   Q U I E R E   S E R   M I L L O N A R I O !");
            Console.WriteLine("_____________________________________________________________________________________________________________________");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                        Participante ingresa tu nombre");
            Name = Console.ReadLine();
            Console.WriteLine("");
          
            
            

            while (true)
            {    
                Console.Clear();     
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n");
                Console.WriteLine("Bienvenido " + Name + "!");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("SELECCIONA LA DIFICULTAD PARA COMENZAR");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("1. Conocedor");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("2. Erudito");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("0. Huir de aqui");
                Console.ForegroundColor = ConsoleColor.White;
                Dificultad = Console.ReadLine();
                

                /*Valor = Console.ReadLine(); // Captura el valor en tipo string

                El valor tipo string de la variable Valor se convierte en tipo int y se almacena 
                en la variable Dificulta declarada de tipo int

                Dificultad = Convert.ToInt32(Valor);

                Dificultad al ser de tipo int no tiene problema al ser comparada con otravarible de
                tipo int tambien*/

                switch (Dificultad) 
                {
                    case "1":
                        Preguntas.DifiConocedor();
                        
                        break;
                        
                    case "2":
                       Preguntas.DifiErudito();
                        break;

                    default:
                        break;
                } 

                if (Dificultad == "0" )
                {
                    break;
                }  
            }
        }
    }
}