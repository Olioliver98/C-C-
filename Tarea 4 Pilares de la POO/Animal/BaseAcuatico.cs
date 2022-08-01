
public class BaseAcuatico: Base
{

    public int CantAletas { get; set; }

    public BaseAcuatico(string especie, string clase, string habitat, int cantaletas)
    {
        Especie = especie;
        Clase = clase;
        Habitat = habitat;
        CantAletas = cantaletas;
    }
    
}