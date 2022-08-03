using System;
using System.Collections.Generic;

public class Datos
{
    public List<Conocedor> ListaConocedor { get; set;}

    public List<Erudito> ListaErudito { get; set; }

    // Intanciando las listas
    public Datos()
    {
        ListaConocedor = new List<Conocedor>();
        CargarPreguntas();

        ListaErudito = new List<Erudito>();
        CargarPreguntasErudito();

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

    public void CargarPreguntasErudito()
    {
        Erudito Pregu_1 = new Erudito (1 , "¿De qué murió el compositor Chopin?", "Tuberculosis");
        ListaErudito.Add(Pregu_1);

        Erudito Pregu_2 = new Erudito(2, "¿Qué santo fundó la Abadía de Montecasino?", "Benedicto");
        ListaErudito.Add(Pregu_2);

        Erudito Pregu_3 = new Erudito(3, "El mercader veneciano Marco Polo fue oficial en la corte de________?", "Kumiai Khan");
        ListaErudito.Add(Pregu_3);
        
        Erudito Pregu_4 = new Erudito(4, "La gente que tiene una reacción física importante hacia el arte hermoso, ¿qué tipo de síndrome sufre?", "Stendhal");
        ListaErudito.Add(Pregu_4);

        Erudito Pregu_5 = new Erudito(5, " ¿Quién fue el primer hombre en viajar dos veces al espacio?", "Gus Grissom");
        ListaErudito.Add(Pregu_5);

        Erudito Pregu_6 = new Erudito(6, "En 1718, ¿qué pirata murió en una batalla en la costa del lugar ahora conocido como Carolina del Norte?", "Barbanegra");
        ListaErudito.Add(Pregu_6);

        Erudito Pregu_7 = new Erudito(7, "Si un día decidieras sembrar semillas de Quercus robur. ¿Qué crecería?", "Arbol");
        ListaErudito.Add(Pregu_7);


    }

    //----------------------------------------------Funciones-------------------------------------------


    /// ARREGLAR LO DE LOS COMODINES PARA QUE NO SE CIERRE SI SE SELECCIONA 2
    public void DifiConocedor()
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

                //Si tiene comodin procede con esto
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
                Console.WriteLine("---------------------------------------------------------------------");
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

//-------------------------------------------------------------------------------------

    public void DifiErudito()
    {   
        //Variables
        int MostrarRespEru = 3;
        string ComodEru = "";
        int PuntuacionEru = 0;
        string RespuestaEru = "";
        int ConteoPremioEru = 0;
        int PremioEru = 0;
        int EndGameEru = 0;
        int EndEru = 1;

        Console.Clear();
        Console.WriteLine("¿ Te consideras un Erudito ?");
        Console.WriteLine("");
        Console.WriteLine("¡ Demuestralo !");
        Console.WriteLine("");
        Console.WriteLine("----------------------------------------------------------------------------------");

        foreach (var Erudito in ListaErudito)
        {
            Console.WriteLine("PREGUNTA: " + Erudito.NumeroPreg );
            Console.WriteLine(Erudito.HacerPreguntas);
            Console.WriteLine("");

            Console.WriteLine("Desea usar un comodin? 1. Si 2. No");
            ComodEru = Console.ReadLine();

            // Si el usuario ingresa 1 se inicia el condicional
            if (ComodEru == "1")
            {
                //Si no tiene comodin muestra esto
                if (MostrarRespEru == 0)
                {
                    Console.WriteLine("No tiene comodines disponibles");
                    Console.WriteLine("");
                }

                //Si tiene comodin procede con esto
                if (MostrarRespEru == 1 | MostrarRespEru == 2 | MostrarRespEru == 3)
                {
                    MostrarRespEru = MostrarRespEru - 1;
                    Console.WriteLine("La respuesta es: " + Erudito.MostrarRespuesta);
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la respuesta mostrata anteriormente");
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("Ingrese su respuesta");
            RespuestaEru = Console.ReadLine();

            if (RespuestaEru == Erudito.MostrarRespuesta)
            {
                Console.WriteLine("Respuesta Correcta");
                PuntuacionEru = PuntuacionEru + 20;
                ConteoPremioEru = PuntuacionEru * 100;
                PremioEru = PremioEru + ConteoPremioEru;
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("");
            }
            
            // Si la respuesta es incorrecta se hace verdadea la linea 235 y se cumple la condicional EndGame
            if (RespuestaEru != Erudito.MostrarRespuesta)
            {
                EndGameEru = EndGameEru + 1;
                Console.WriteLine("Respuesta Incorrecta");
                Console.WriteLine("");
                Console.WriteLine("La Respuesta Correcta es: " + Erudito.MostrarRespuesta);
                Console.WriteLine("");
                Console.ReadLine();
                break;
                
            }
        }

        if (EndGameEru == EndEru)
        {
            Console.WriteLine("Game over!");
            Console.WriteLine("Has Perdido todo!");
            Console.ReadLine();
        }

        else
        {
            Console.WriteLine("¡Has Ganado!");
            Console.WriteLine("");
            Console.WriteLine("Puntuacion Final: " + PuntuacionEru);
            Console.WriteLine("Dinero en efectivo ganado: $" + PremioEru);
            Console.ReadLine();
        }
         
    }
}

    

    