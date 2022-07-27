using System;
public class Orden
{
    public int Codigo { get; set; }

    public DateTime Fecha { get; set; }

    public string NumerodeOrden { get; set; }

    public Clientes Cliente { get; set; }

    public Vendedor Vendedor { get; set; }

    public Orden(int codigo, DateTime fecha, string numerodeorden, Clientes cliente, Vendedor vendedor)
    {
        Codigo = codigo;
        Fecha = fecha;
        Cliente = cliente;
        Vendedor = vendedor;
    }
}