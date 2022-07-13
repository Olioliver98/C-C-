// Esto es una Plantilla 

public class Alumno
{

    //Estas son propiedades.
    public int Id { get; set; }

    public string PrimerNombre  { get; set; }
    
    public string SegundoNombre { get; set; }

    //Constructor: Este debe llevar el mismo nombre de la propiedad.
    public Alumno()
    {
        Id = 1;
    }

    public Alumno(int id)
    {
        Id = id;
    }

    public Alumno(string PrimerNombre, string SegundoNombre)
    {
        PrimerNombre = PrimerNombre;
        SegundoNombre = SegundoNombre;

    }


}
