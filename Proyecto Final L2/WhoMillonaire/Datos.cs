using System;
using System.Collections.Generic;

public class Datos
{
    public List<Conocedor> ListaConocedor { get; set;}

    // Intanciando las listas
    public Datos()
    {
        ListaConocedor = new List<Conocedor>();
        CargarPreguntas();

    }

// --------------------------PARAMETROS--------------------------------------

    private void CargarPreguntas()
    {
        Conocedor Preg_1 = new Conocedor("¿Cual es la capital de Honduras?", "Tegucigalpa");
        ListaConocedor.Add(Preg_1);

        Conocedor Preg_2 = new Conocedor("¿Cual es el lugar de origen del whisky escocés?", "Escocia");
        ListaConocedor.Add(Preg_2);

        Conocedor Preg_3 = new Conocedor("En los hoteles elegantes, ¿qué snack suele dejarse sobre las almohadas?", "Chocolate");
        ListaConocedor.Add(Preg_3);

        Conocedor Preg_4 = new Conocedor("Según el viejo dicho, ¿el amor por el _____ es la raíz de todos los males?", "Dinero");
        ListaConocedor.Add(Preg_4);
        
        Conocedor Preg_5 = new Conocedor("¿Qué parte importante de la topografía de Estados Unidos comprende aproximadamente un 20% del agua dulce de la Tierra?" , "Lagos");
        ListaConocedor.Add(Preg_5);

        Conocedor Preg_6 = new Conocedor("En el típico chiste, ¿qué viene antes de que alguien conteste:¿Quién es?", "Toc-toc");
        ListaConocedor.Add(Preg_6);

        Conocedor Preg_7 = new Conocedor("¿Qué planta es el símbolo nacional de Irlanda?", "Trebol");
        ListaConocedor.Add(Preg_7);
    }

    //----------------------------------------------Funciones-------------------------------------------


    /// ARREGLAR LO DE LOS COMODINES PARA QUE NO SE CIERRE SI SE SELECCIONA 2
    public void DefiConocedor()
    {   
        //Variables
        int MostrarResp = 3;
        string Comod = "";
        int Puntuacion = 0;
        string Respuesta = "";
        int ConteoPremio = 0;
        int Premio = 0;
        string EndGame = "";
        string End = "";

        Console.Clear();
        Console.WriteLine("         ¿Has escogido Conocedor?");
        Console.WriteLine("");
        Console.WriteLine("         ¡Averiguemos si lo eres!");
        Console.WriteLine("");
        Console.WriteLine("---------------------------------------------");

        foreach (var Conocedor in ListaConocedor)
        {
            Console.WriteLine("PREGUNTA: " );
            Console.WriteLine(Conocedor.Preguntas);
            Console.WriteLine("");

            Console.WriteLine("Desea usar un comodin? 1. Si 2. No");
            Comod = Console.ReadLine();

             // Si el usuario ingresa 1 se inicia el condicional
            if (Comod == "1")
            {
                //Si no tiene comodin muestra esto
                if (MostrarResp == 0)
                {
                    Console.WriteLine("No tiene comodines disponibles");
                    Console.WriteLine("");
                }

                //Si tiene comodin proede con esto
                if (MostrarResp == 1 | MostrarResp == 2 | MostrarResp == 3)
                {
                    MostrarResp = MostrarResp - 1;
                    Console.WriteLine("La respuesta es: " + Conocedor.MostRespuesta);
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la respuesta mostrata anteriormente");
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("Ingrese su respuesta");
            Respuesta = Console.ReadLine();

            if (Respuesta == Conocedor.MostRespuesta)
            {
                Console.WriteLine("Respuesta Correcta");
                Puntuacion = Puntuacion + 10;
                ConteoPremio = Puntuacion * 50;
                Premio = Premio + ConteoPremio;
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("");
            }
            
            // Si la respuesta es incorrecta se hace verdadea la linea 111 y se cumple la condicional EndGame
            if (Respuesta != Conocedor.MostRespuesta)
            {
                EndGame = End;
                Console.WriteLine("Respuesta Incorrecta");
                Console.WriteLine("");
                Console.WriteLine("La Respuesta Correcta es: " + Conocedor.MostRespuesta);
                Console.WriteLine("");
                Console.ReadLine();
                break;
            }
        }

        if (EndGame == End)
        {
            Console.WriteLine("Game over!");
            Console.WriteLine("Has Perdido todo!");
            Console.ReadLine();

        }

        else
        {
            Console.WriteLine("¡Has Ganado!");
            Console.WriteLine("");
            Console.WriteLine("Puntuacion Final: " + Puntuacion);
            Console.WriteLine("Dinero en efectivo ganado: $" + Premio);
            Console.ReadLine();
        } 
    }               
}

