using System;
using System.Collections.Generic;



public class DatosdePrueba
{
    public List<Producto> ListadeProductos { get; set; }
    
    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProducto();
    }

    private void cargarProducto()
    {
        Producto p1 = new Producto(1, "Mouse", 250);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2, "Teclado", 350);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3, "Monitor", 4000);
        ListadeProductos.Add(p3);
    }


    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("==================");
        Console.WriteLine("");

        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }

        Console.ReadLine();

    }
}