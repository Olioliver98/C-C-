public class AniAcuaticos: AnimalBase
{
    public string Personalidad { get; set; }

    public string Observacion { get; set; }



    public AniAcuaticos(string nombre, string habitat, string alimento, string personalidad, string observacion)
    {
        Nombre = nombre;
        Habitat = habitat;
        Alimento = alimento;
        Personalidad = personalidad;
        Observacion = observacion;
    } 
}