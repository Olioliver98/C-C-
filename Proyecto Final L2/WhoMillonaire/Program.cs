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

            Console.WriteLine("             ¡ QUIEN QUIERE SER MILLONARIO !");
            Console.WriteLine("");
            Console.WriteLine("Participante ingresa tu nombre");
            Name = Console.ReadLine();
            Console.WriteLine("");
          
            
            

            while (true)
            {    
                Console.Clear();     
                Console.WriteLine("Bienvenido " + Name + "!");
                Console.WriteLine("Selecciona la dificultad para comenzar");
                Console.WriteLine("");
                Console.WriteLine("1. Conocedor");
                Console.WriteLine("2. Erudito");
                Console.WriteLine("0. Salir");
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