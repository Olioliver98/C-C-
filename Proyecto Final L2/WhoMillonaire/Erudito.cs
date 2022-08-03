

public class Erudito

{
    
    public int NumeroPreg { get; set; }
    public string HacerPreguntas { get; set; }
    public string MostrarRespuesta { get; set; }



    public Erudito(int numeropreg, string hacerpreguntas, string mostrarespuesta)
    {
        NumeroPreg = numeropreg;
        HacerPreguntas = hacerpreguntas; 
        MostrarRespuesta = mostrarespuesta;
        
       
    }
}