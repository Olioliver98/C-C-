public class Vendedor: Persona
{
    public string CodigoVendedor { get; set; }


    public Vendedor(int codigo, string nombre, string codigovendedor)
    {
       Codigo = codigo;
       Nombre = nombre;
       CodigoVendedor = codigovendedor; 
    }

}