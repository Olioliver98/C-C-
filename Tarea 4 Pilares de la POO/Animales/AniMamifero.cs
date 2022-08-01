public class AniMamifero : AnimalBase
{
    public string Color{ get; set; }

    public AniMamifero(string nombre, string habitat, string alimento, string color)
    {
       Nombre = nombre;
       Habitat = habitat;
       Alimento = alimento;
       Color = color;
    }
}