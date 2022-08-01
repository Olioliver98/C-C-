
public class BaseMamifero: Base //Hereda de BaseAnimal
{
    public int CantPatas { get; set; }

    void Caminar()
    {
        Console.WriteLine("El mamifero camina con " + CantPatas + " patas");
    }

    // Constructor
    public BaseMamifero(string especie, string clase, string habitat, int cantpatas)
    {
       
        Especie = especie;
        Clase = clase;
        Habitat = habitat;
        CantPatas = cantpatas;
    }

}