using System;
using System.Collections.Generic;

public class BaseDatos
{
    public List<AniMamifero> ListaMamiferos { get; set; }

    public List<AniAves> ListaAves { get; set; }

    public List<AniAcuaticos> ListaAcuatica { get; set; }
    

    //Instanciando las listas de animales
    public BaseDatos()
    {
        ListaMamiferos = new List<AniMamifero>();
        CargarAniMamifero();

        ListaAves = new List<AniAves>();
        CargarAniAve();

        ListaAcuatica = new List<AniAcuaticos>();
        CargarAniAcuaticos();

        
    }


// ----------------------------------------------Parametros----------------------------------------------
    // Agregando animales a la lista de mamferos
    private void CargarAniMamifero()
    {
        // Los parametros son: Nombre -- Habitat  -- Alimeto -- Color

        AniMamifero Mamifero_1 = new AniMamifero("Mono ", "La Selva ", "Bananas", "Cafe" );
        ListaMamiferos.Add(Mamifero_1);

        AniMamifero Mamifero_2 = new AniMamifero("Vaca", "Granja ", "Pasto", "Blanco con negro");
        ListaMamiferos.Add(Mamifero_2);

        AniMamifero Mamifero_3 = new AniMamifero("Leon", "Africa", "Carne", "Amarillo");
        ListaMamiferos.Add(Mamifero_3);
    }

    private void CargarAniAve()
    {
        // Los parametro son: Nombre -- Habitat -- Alimento -- Especie --  Accion
        AniAves Ave_1 = new AniAves("Tucan", "Selvas Tropicales", "Frutas", "Huevipara", "Vuelan alto");
        ListaAves.Add(Ave_1);

        AniAves Ave_2 = new AniAves("Colibri", "Honduras", "Nectar", "Huevipara", "Vuela muy rapido");
        ListaAves.Add(Ave_2);

        AniAves Ave_3 = new AniAves("Cisne", "Asia Central", "Peces, ranas e insectos", "Huevipara", "Migran a Europa Central");
        ListaAves.Add(Ave_3);
        
    }

    private void CargarAniAcuaticos()
    {
        // Los parametro son: Nombre -- Habitat -- Alimento -- Personalidad -- Observacion

        AniAcuaticos Acua_1 = new AniAcuaticos("Delfine", "Por todos los oceanos", "Sardinas", "Juguetones / Agresivos", "Se tienen registros de ser el unico animal que conoce la diversion entre su especie y matan por diversion");
        ListaAcuatica.Add(Acua_1);
        AniAcuaticos Acua_2 = new AniAcuaticos("Orcas", "Por todos los oceanos", "Arrenques, entre otro peces", "Agresiva y territorial", "Se les conoce como asesinas por naturaleza");
        ListaAcuatica.Add(Acua_2);
        AniAcuaticos Acua_3 = new AniAcuaticos("Pez Betta", "Oceanos Tropicales", "Insectos y larvas", "Timida", "Les gusta los ambientes con plantas cuevas y espacios para explorar");
        ListaAcuatica.Add(Acua_3);

    }


    //----------------------------------------------Funciones-------------------------------------------

    public void FuncionMamiferos()
    {
        Console.Clear();
        Console.WriteLine("     Lista de Mamiferos  ");
        Console.WriteLine("----------------------------");
        Console.WriteLine("");

        foreach (var AniMamifero in ListaMamiferos)
        {
            Console.WriteLine("Nombre:  " + AniMamifero.Nombre);
            Console.WriteLine("Habitat: " + AniMamifero.Habitat);
            Console.WriteLine("Alimeto: " + AniMamifero.Alimento);
            Console.WriteLine("Color:   " + AniMamifero.Color);
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
        }

        Console.ReadLine();
    }

    public void FuncionAves()
    {
        Console.Clear();
        Console.WriteLine("     Lista de Aves  ");
        Console.WriteLine("----------------------------");
        Console.WriteLine("");

        foreach (var AniAves in ListaAves)
        {
            Console.WriteLine("Nombre:  " + AniAves.Nombre);
            Console.WriteLine("Habitat: " + AniAves.Habitat);
            Console.WriteLine("Alimeto: " + AniAves.Alimento);
            Console.WriteLine("Especie: " + AniAves.Especie);
            Console.WriteLine("Accion:  " + AniAves.Accion);
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
        }

        Console.ReadLine();
    }

    public void FuncionAcuatica()
    {
        Console.Clear();
        Console.WriteLine("     Lista Acuatica  ");
        Console.WriteLine("----------------------------");
        Console.WriteLine("");

        foreach (var AniAcuaticos in ListaAcuatica)
        {
            Console.WriteLine("Nombre:        " + AniAcuaticos.Nombre);
            Console.WriteLine("Habitat:       " + AniAcuaticos.Habitat);
            Console.WriteLine("Alimeto:       " + AniAcuaticos.Alimento);
            Console.WriteLine("Personalida:   " + AniAcuaticos.Personalidad);
            Console.WriteLine("Observaciones: " + AniAcuaticos.Observacion);
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("");
        }

        Console.ReadLine();
    }



}