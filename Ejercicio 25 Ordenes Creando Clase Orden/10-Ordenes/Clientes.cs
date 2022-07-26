public class Clientes: Personas
{

    public double Saldo { get; set; }
    public Clientes (int codigo, string nombre, string telefono, double saldo)
    {
        Codigo = codigo;
        Nombre = nombre;
        Telefono = telefono;
        Saldo = saldo;
    }

}