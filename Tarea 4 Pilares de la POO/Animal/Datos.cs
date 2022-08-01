using System;

using System.Collections.Generic;

public class Datos
{
    public List<BaseAcuatico> AniAcuatico { get; set; }

    public Datos()
    {
        AniAcuatico = new List<BaseAcuatico>();
        Lista();

    }

    private void Lista()
    {
        BaseAcuatico Acua1 = new BaseAcuatico ("Acuatica", "Pez", "Mar", 3);
        AniAcuatico.Add(Acua1);

    }

    public void AnimalesAcaticos()
    {
        Console.Clear();
        Console.WriteLine("     Animales Acuaticos");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("");

        foreach (var BaseAcuatico in AniAcuatico)
        {
            Console.WriteLine( BaseAcuatico.Especie + "|" +  BaseAcuatico.Clase + "|" +  BaseAcuatico.Habitat + "|" +  BaseAcuatico.CantAletas);
            
        }
        
        Console.ReadLine();

    }









}