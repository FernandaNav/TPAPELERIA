using System;
using System.Collections.Generic;
using TPAPELERIA;

public class Inventario
{
    private List<Producto> productos;
    private int contadorID;

    public Inventario()
    {
        productos = new List<Producto>();
        contadorID = 1; 
    }

    public void AgregarProducto(string nombre, int cantidad, decimal precio, DateTime fechaVencimiento)
    {
        Producto producto = new Producto
        {
            Id = contadorID++,
            Nombre = nombre,
            Cantidad = cantidad,
            Precio = precio,
            FechaVencimiento = fechaVencimiento
        };

        productos.Add(producto);
    }

    public List<Producto> ObtenerProductos()
    {
        return productos;
    }

    public Producto ObtenerProductoPorId(int id)
    {
        return productos.Find(p => p.Id == id);
    }

    public void RegistrarVenta(int idProducto, int cantidadVenta)
    {
        Producto producto = ObtenerProductoPorId(idProducto);

        if (producto == null)
        {
            throw new Exception("Producto no encontrado");
        }

        if (producto.Cantidad >= cantidadVenta)
        {
            producto.Cantidad -= cantidadVenta; 
        }
        else
        {
            throw new Exception("Cantidad insuficiente en inventario");
        }
    }
}

