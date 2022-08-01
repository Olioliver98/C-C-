public class AniAves: AnimalBase
{
    public string Especie { get; set; }
    public string Accion { get; set; }


    public AniAves(string nombre, string habitat, string alimento, string especie, string accion)
    {
       Nombre = nombre;
       Habitat = habitat;
       Alimento = alimento;
       Especie = especie;
       Accion = accion;
    }

}