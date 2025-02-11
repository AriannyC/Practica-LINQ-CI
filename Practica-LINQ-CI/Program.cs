﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_LINQ_CI
{
    public class Program
    {
        static void Main(string[] args)
        {


            List<Producto> lst = new List<Producto>
            {
                new Producto  { Id = 1, Nombre = "Laptop Dell", Descripcion = "Laptop de 15 pulgadas",
                    Precio = 850.99m, Stock = 7, Categoria = "Electrónica", FechaCreacion = DateTime.Now },
    new Producto { Id = 2, Nombre = "Mouse Logitech", Descripcion = "Mouse inalámbrico",
        Precio = 25.50m, Stock = 50, Categoria = "Accesorios", FechaCreacion = DateTime.Now },
    new Producto { Id = 3, Nombre = "Teclado Mecánico", Descripcion = "Teclado mecánico RGB",
        Precio = 75.00m, Stock = 30, Categoria = "Accesorios", FechaCreacion = DateTime.Now },
    new Producto { Id = 4, Nombre = "Monitor Samsung", Descripcion = "Monitor 24 pulgadas Full HD",
        Precio = 150.75m, Stock = 20, Categoria = "Electrónica", FechaCreacion = DateTime.Now },

    new Producto { Id = 5, Nombre = "Monitor Samsungn", Descripcion = "Monitor 24 pulgadas Full HD",
        Precio = 150.75m, Stock = 20, Categoria = "General", FechaCreacion = DateTime.Now },
    new Producto { Id = 6, Nombre = "Tablet Lenovo", Descripcion = "Tablet 10 pulgadas PANTALLA", Precio = 180.00m, Stock = 25, Categoria = "Electrónica", FechaCreacion = DateTime.Now },
    new Producto { Id = 7, Nombre = "Audífonos Sony", Descripcion = "Audífonos con cancelación de ruido", Precio = 220.00m, Stock = 12, Categoria = "Audio", FechaCreacion = DateTime.Now },
    new Producto { Id = 8, Nombre = "Cámara Canon", Descripcion = "Cámara profesional", Precio = 1200.00m, Stock = 8, Categoria = "Fotografía", FechaCreacion = DateTime.Now },
    new Producto { Id = 9, Nombre = "Silla Gamer", Descripcion = "Silla ergonómica para gaming", Precio = 199.99m, Stock = 18, Categoria = "Muebles", FechaCreacion = DateTime.Now },
    new Producto { Id = 10, Nombre = "Disco Duro Externo", Descripcion = "Disco duro 1TB", Precio = 89.99m, Stock = 35, Categoria = "Almacenamiento", FechaCreacion = DateTime.Now },
    new Producto { Id = 11, Nombre = "Router TP-Link", Descripcion = "Router inalámbrico Wi-Fi 6", Precio = 110.50m, Stock = 22, Categoria = "Redes", FechaCreacion = DateTime.Now },
    new Producto { Id = 12, Nombre = "Smartwatch Apple", Descripcion = "Apple Watch Series 7", Precio = 399.00m, Stock = 14, Categoria = "Wearables", FechaCreacion = DateTime.Now },
    new Producto{ Id = 13, Nombre = "Impresora Epson", Descripcion = "Impresora multifuncional", Precio = 250.99m, Stock = 11, Categoria = "Oficina", FechaCreacion = DateTime.Now },
    new Producto{ Id = 14, Nombre = "Auriculares JBL", Descripcion = "Auriculares Bluetooth", Precio = 59.99m, Stock = 40, Categoria = "Audio", FechaCreacion = DateTime.Now },
    new Producto{ Id = 15, Nombre = "Power Bank Xiaomi", Descripcion = "Cargador portátil 20000mAh", Precio = 35.99m, Stock = 28, Categoria = "Accesorios", FechaCreacion = DateTime.Now },
    new Producto{ Id = 16, Nombre = "Tarjeta Gráfica Nvidia", Descripcion = "RTX 3060 Ti", Precio = 550.00m, Stock = 7, Categoria = "Hardware", FechaCreacion = DateTime.Now },
        new Producto{ Id = 17, Nombre = "Iphone pro max", Descripcion = "RTX 3060 Ti", Precio = 550.00m, Stock = 7, Categoria = "Hardware", FechaCreacion = DateTime.Now }


            };

            #region 1. Obtener todos los productos de la lista.



            #endregion


            // 2. Obtener los nombres de todos los productos.





            #region 3. Obtener los productos cuyo precio sea mayor a 500.

            //var may = lst.First(p => p.Precio > 500);
            //Console.WriteLine($" {may.Nombre} | {may.Precio}");
            #endregion

            #region 4. Obtener los productos con stock menor a 10.

            //var men = lst.First(p => p.Stock < 10);
            //Console.WriteLine($" {men.Nombre} | {men.Stock}");

            #endregion
            // 5. Obtener los productos de la categoría "Electrónica".
            #region 6. Obtener los productos cuyo nombre comience con la letra 'L'.
            //var let = lst.Where(x => x.Nombre.StartsWith("L"));

            //foreach (var s in let)
            //    Console.WriteLine(s.Nombre);
            #endregion


            #region 7. Obtener los productos cuyo precio esté entre 100 y 500.
            //var men = lst.Where(p => p.Precio >= 100 && p.Precio <= 500);

            //Console.WriteLine("Productos con precio entre 100 y 500:");
            //foreach (var producto in men)
            //{
            //    Console.WriteLine($"{producto.Nombre} | {producto.Precio}");
            //}
            #endregion

            #region 8. Obtener los productos ordenados por precio ascendente.
            //var ascen = lst.OrderBy(x => x.Precio);

            //foreach(var item in lst)
            //    Console.WriteLine(item.Precio);
            #endregion

            #region 9. Obtener los productos ordenados por precio descendente.
            //var descen = lst.OrderByDescending(x => x.Precio);

            //foreach (var item in lst)
            //    Console.WriteLine(item.Precio);
            #endregion

            #region 10. Obtener los productos ordenados por nombre en orden alfabético.
            //var orden = lst.OrderBy(x => x.Nombre);
            //foreach (var item in orden)
            //{
            //    Console.WriteLine(item.Nombre);

            //}
            #endregion

            #region 11. Obtener los productos ordenados por stock de mayor a menor.
            //var mn = lst.OrderByDescending(x => x.Stock);

            //foreach (var item in mn )
            //    Console.WriteLine(item.Stock);
            #endregion

            // 12. Obtener los primeros 5 productos más caros.
            // 13. Obtener los 10 productos con menor stock.
            // 14. Obtener la cantidad total de productos en la lista.
            #region 15. Obtener la suma de todos los precios de los productos.

            //decimal res= lst.Sum(p=> p.Precio);
            //Console.WriteLine(res);
            #endregion
            // 16. Obtener el precio promedio de los productos.
            #region 17. Obtener el producto más caro.
            //var mas= lst.Max(P=>P.Precio);
            //Console.WriteLine(mas);
            #endregion
            #region 18. Obtener el producto más barato.
            //var mn = lst.Min(P => P.Precio);
            //Console.WriteLine(mn);
            #endregion
            #region 19. Verificar si hay algún producto con precio mayor a 1000.
            //var men = lst.Where(p => p.Precio > 1000 );

            //foreach (var producto in men)

            //    Console.WriteLine($"{producto.Nombre} | {producto.Precio}");
            #endregion

            #region  20. Verificar si todos los productos tienen stock mayor a 5.

            //bool ver = lst.All(x => x.Stock > 5);
            //foreach (var item in lst)
            //    Console.WriteLine(item.Stock);
            #endregion
            // 21. Contar cuántos productos hay en la categoría "Audio".
            // 22. Agrupar los productos por categoría.
            // 23. Obtener la categoría con más productos.
            // 24. Obtener el stock total de todos los productos.
            // 25. Obtener el producto con el nombre más largo.
            // 26. Obtener el producto con la descripción más corta.
            #region  27. Filtrar los productos cuya descripción contenga la palabra "pantalla".
            //var let = lst.Where(x => x.Descripcion.ToLower().Contains("pantalla"));

            //foreach (var s in let)
            //    Console.WriteLine(s.Descripcion);

            #endregion
            // 28. Obtener el promedio de stock de los productos de la categoría "Almacenamiento".
            // 29. Obtener los productos creados en una fecha específica (20/12/2022).
            #region 30. Obtener los productos cuya ID sea par.

            //var par= from r in lst where r.Id % 2==0 select r;

            //foreach (var item in par)
            //    Console.WriteLine(item.Id);
            #endregion

            #region  31. Obtener los productos cuya ID sea impar.
            //var par = from r in lst where r.Id % 2 != 0 select r;

            //foreach (var item in par)
            //    Console.WriteLine(item.Id);
            #endregion
            // 32. Obtener los productos cuyo precio tenga un decimal mayor a .50.


            // 33. Obtener los productos cuyo nombre tenga más de 10 caracteres.
            // 34. Obtener los productos cuyo stock sea un número primo.
            #region 35. Obtener los productos cuyo nombre contenga la palabra "Pro".
            //var let = lst.Where(x => x.Nombre.ToLower().Contains("pro")); 

            //foreach (var s in let)
            //{
            //    Console.WriteLine(s.Nombre);
            //}

            #endregion

            #region 36. Obtener los productos cuyo stock sea un múltiplo de 5.

            //var mult= from n in lst where n.Stock % 5== 0 select n;

            //foreach (var n in mult)
            //    Console.WriteLine(n.Stock);
            #endregion
            // 37. Obtener los productos que tengan una descripción con más de 20 caracteres.
            // 38. Obtener los productos cuyo precio sea un número redondo (sin decimales).
            // 39. Obtener los productos que tengan exactamente dos palabras en su nombre.
            #region 40. Obtener la cantidad de productos que no pertenecen a la categoría "General".

            //var gene = (from n in lst where n.Categoria != "General" select n).ToList();
            //int cantidadProductos = gene.Count();
            //Console.WriteLine(cantidadProductos);



            //foreach (var c in gene)
            //    Console.WriteLine(c.Nombre);
            #endregion



          

            Console.ReadLine();

        }
        

       
           

        
    }
}
