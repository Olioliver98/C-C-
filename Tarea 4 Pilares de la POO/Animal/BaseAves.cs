
public class BaseAves: Base
{
    public string Color { get; set; }

    public string Tamano { get; set; }

    public string Accion { get; set; }

    void AccionAnimal()
    {
        Console.WriteLine("Las aves" + Accion );

    }
    
    public BaseAves(string especie, string clase, string habitat, string color, string tamano, string accion)
    {
       
        Especie = especie;
        Clase = clase;
        Habitat = habitat;
        Color = color;
        Tamano = tamano;
        Accion = accion;
    }



}