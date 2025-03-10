﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Practica_LINQ_CI
{
    public class Program
    {
        static void Main(string[] args)
        {


            List<Producto> lst = new List<Producto>
            {
               new Producto { Id = 1, Nombre = "Laptop Dell", Descripcion = "Laptop de 15 pulgadas", Precio = 850.99m, Stock = 7, Categoria = "Electrónica", FechaCreacion = new DateTime(2022, 12, 1) },
new Producto { Id = 2, Nombre = "Mouse Logitech", Descripcion = "Mouse inalámbrico", Precio = 25.50m, Stock = 50, Categoria = "Accesorios", FechaCreacion = new DateTime(2022, 12, 5) },
new Producto { Id = 3, Nombre = "Teclado Mecánico", Descripcion = "Teclado mecánico RGB", Precio = 75.00m, Stock = 30, Categoria = "Accesorios", FechaCreacion = new DateTime(2022, 12, 10) },
new Producto { Id = 4, Nombre = "Monitor Samsung", Descripcion = "Monitor 24 pulgadas Full HD", Precio = 150.75m, Stock = 20, Categoria = "Electrónica", FechaCreacion = new DateTime(2022, 12, 15) },

new Producto { Id = 5, Nombre = "Monitor Samsungn", Descripcion = "Monitor 24 pulgadas Full HD", Precio = 150.75m, Stock = 20, Categoria = "General", FechaCreacion = new DateTime(2022, 12, 18) },
new Producto { Id = 6, Nombre = "Tablet Lenovo", Descripcion = "Tablet 10 pulgadas PANTALLA", Precio = 180.00m, Stock = 25, Categoria = "Electrónica", FechaCreacion = new DateTime(2022, 12, 20) },
new Producto { Id = 7, Nombre = "Audífonos Sony", Descripcion = "Audífonos con cancelación de ruido", Precio = 220.00m, Stock = 12, Categoria = "Audio", FechaCreacion = new DateTime(2022, 12, 22) },
new Producto { Id = 8, Nombre = "Cámara Canon", Descripcion = "Cámara profesional", Precio = 1200.00m, Stock = 8, Categoria = "Fotografía", FechaCreacion = new DateTime(2022, 12, 25) },
new Producto { Id = 9, Nombre = "Silla Gamer", Descripcion = "Silla ergonómica para gaming", Precio = 199.99m, Stock = 18, Categoria = "Muebles", FechaCreacion = new DateTime(2022, 12, 30) },
new Producto { Id = 10, Nombre = "Disco Duro Externo", Descripcion = "Disco duro 1TB", Precio = 89.99m, Stock = 35, Categoria = "Almacenamiento", FechaCreacion = new DateTime(2023, 1, 2) },
new Producto { Id = 11, Nombre = "Router TP-Link", Descripcion = "Router inalámbrico Wi-Fi 6", Precio = 110.50m, Stock = 22, Categoria = "Redes", FechaCreacion = new DateTime(2023, 1, 5) },
new Producto { Id = 12, Nombre = "Smartwatch Apple", Descripcion = "Apple Watch Series 7", Precio = 399.00m, Stock = 14, Categoria = "Wearables", FechaCreacion = new DateTime(2023, 1, 10) },
new Producto { Id = 13, Nombre = "Impresora Epson", Descripcion = "Impresora multifuncional", Precio = 250.99m, Stock = 11, Categoria = "Oficina", FechaCreacion = new DateTime(2023, 1, 12) },
new Producto { Id = 14, Nombre = "Auriculares JBL", Descripcion = "Auriculares Bluetooth", Precio = 59.99m, Stock = 40, Categoria = "Audio", FechaCreacion = new DateTime(2023, 1, 15) },
new Producto { Id = 15, Nombre = "Power Bank Xiaomi", Descripcion = "Cargador portátil 20000mAh", Precio = 35.99m, Stock = 28, Categoria = "Accesorios", FechaCreacion = new DateTime(2023, 1, 20) },
new Producto { Id = 16, Nombre = "Tarjeta Gráfica Nvidia", Descripcion = "RTX 3060 Ti", Precio = 550.00m, Stock = 7, Categoria = "Hardware", FechaCreacion = new DateTime(2023, 1, 25) },
new Producto { Id = 17, Nombre = "Iphone pro max", Descripcion = "RTX 3060 Ti", Precio = 550.00m, Stock = 7, Categoria = "Hardware", FechaCreacion = new DateTime(2023, 2, 1) },
        new Producto { Id = 18, Nombre = "Impresora HP", Descripcion = "Impresora multifuncional láser", Precio = 189.99m, Stock = 15, Categoria = "Oficina", FechaCreacion = new DateTime(2023, 2, 5) },
new Producto { Id = 19, Nombre = "Altavoces Bose", Descripcion = "Altavoces Bluetooth", Precio = 300.00m, Stock = 10, Categoria = "Audio", FechaCreacion = new DateTime(2023, 2, 7) },
new Producto { Id = 20, Nombre = "Silla Ergonómica", Descripcion = "Silla ergonómica ajustable", Precio = 120.00m, Stock = 50, Categoria = "Muebles", FechaCreacion = new DateTime(2023, 2, 10) },
new Producto { Id = 21, Nombre = "Cámara Sony", Descripcion = "Cámara compacta digital", Precio = 450.00m, Stock = 5, Categoria = "Fotografía", FechaCreacion = new DateTime(2023, 2, 12) },
new Producto { Id = 22, Nombre = "Laptop HP", Descripcion = "Laptop de 14 pulgadas con Intel Core i5", Precio = 700.00m, Stock = 30, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 2, 15) },
new Producto { Id = 23, Nombre = "Monitor LG", Descripcion = "Monitor 27 pulgadas 4K", Precio = 250.00m, Stock = 20, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 2, 18) },
new Producto { Id = 24, Nombre = "Teclado Logitech", Descripcion = "Teclado mecánico con retroiluminación", Precio = 85.00m, Stock = 40, Categoria = "Accesorios", FechaCreacion = new DateTime(2023, 2, 20) },
new Producto { Id = 25, Nombre = "Ratón Razer", Descripcion = "Ratón gaming con 16K DPI", Precio = 70.00m, Stock = 50, Categoria = "Accesorios", FechaCreacion = new DateTime(2023, 2, 22) },
new Producto { Id = 26, Nombre = "Smartphone Samsung", Descripcion = "Samsung Galaxy S21 5G", Precio = 999.99m, Stock = 10, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 2, 24) },
new Producto { Id = 27, Nombre = "Cargador inalámbrico", Descripcion = "Cargador inalámbrico para móviles", Precio = 29.99m, Stock = 100, Categoria = "Accesorios", FechaCreacion = new DateTime(2023, 3, 1) },
new Producto { Id = 28, Nombre = "Auriculares Beats", Descripcion = "Auriculares inalámbricos con cancelación de ruido", Precio = 250.00m, Stock = 15, Categoria = "Audio", FechaCreacion = new DateTime(2023, 3, 5) },
new Producto { Id = 29, Nombre = "Router Netgear", Descripcion = "Router Wi-Fi 6 de alto rendimiento", Precio = 130.00m, Stock = 25, Categoria = "Redes", FechaCreacion = new DateTime(2023, 3, 8) },
new Producto { Id = 30, Nombre = "Tablet Samsung", Descripcion = "Tablet Samsung Galaxy Tab S7", Precio = 499.00m, Stock = 30, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 3, 10) },
new Producto { Id = 31, Nombre = "Power Bank Anker", Descripcion = "Cargador portátil 20000mAh", Precio = 45.00m, Stock = 40, Categoria = "Accesorios", FechaCreacion = new DateTime(2023, 3, 12) },
new Producto { Id = 32, Nombre = "Smartwatch Samsung", Descripcion = "Galaxy Watch 4", Precio = 250.00m, Stock = 25, Categoria = "Wearables", FechaCreacion = new DateTime(2023, 3, 15) },
new Producto { Id = 33, Nombre = "Cámara de seguridad", Descripcion = "Cámara de vigilancia 4K", Precio = 180.00m, Stock = 15, Categoria = "Seguridad", FechaCreacion = new DateTime(2023, 3, 17) },
new Producto { Id = 34, Nombre = "Impresora 3D", Descripcion = "Impresora 3D para hogar", Precio = 350.00m, Stock = 7, Categoria = "Oficina", FechaCreacion = new DateTime(2023, 3, 20) },
new Producto { Id = 35, Nombre = "Silla Gamer DXRacer", Descripcion = "Silla gamer ergonómica", Precio = 450.00m, Stock = 12, Categoria = "Muebles", FechaCreacion = new DateTime(2023, 3, 22) },
new Producto { Id = 36, Nombre = "Cámara GoPro", Descripcion = "Cámara deportiva resistente al agua", Precio = 300.00m, Stock = 10, Categoria = "Fotografía", FechaCreacion = new DateTime(2023, 3, 24) },
new Producto { Id = 37, Nombre = "Monitor Acer", Descripcion = "Monitor curvo de 27 pulgadas", Precio = 220.00m, Stock = 20, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 3, 26) },
new Producto { Id = 38, Nombre = "Ratón Corsair", Descripcion = "Ratón para gaming con RGB", Precio = 50.00m, Stock = 40, Categoria = "Accesorios", FechaCreacion = new DateTime(2023, 3, 28) },
new Producto { Id = 39, Nombre = "Laptop Asus", Descripcion = "Laptop gamer con Intel Core i7", Precio = 999.00m, Stock = 15, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 4, 1) },
new Producto { Id = 40, Nombre = "Cargador Solar", Descripcion = "Cargador solar para dispositivos móviles", Precio = 40.00m, Stock = 50, Categoria = "Accesorios", FechaCreacion = new DateTime(2023, 4, 3) },
new Producto { Id = 41, Nombre = "Teclado Razer", Descripcion = "Teclado mecánico gaming", Precio = 100.00m, Stock = 30, Categoria = "Accesorios", FechaCreacion = new DateTime(2023, 4, 5) },
new Producto { Id = 42, Nombre = "Router Asus", Descripcion = "Router Wi-Fi 6 de gama alta", Precio = 120.00m, Stock = 20, Categoria = "Redes", FechaCreacion = new DateTime(2023, 4, 8) },
new Producto { Id = 43, Nombre = "Smartphone Xiaomi", Descripcion = "Xiaomi Redmi Note 10", Precio = 200.00m, Stock = 15, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 4, 10) },
new Producto { Id = 44, Nombre = "Auriculares Bose QC35", Descripcion = "Auriculares Bluetooth con cancelación de ruido", Precio = 350.00m, Stock = 10, Categoria = "Audio", FechaCreacion = new DateTime(2023, 4, 12) },
new Producto { Id = 45, Nombre = "Impresora Brother", Descripcion = "Impresora láser multifuncional", Precio = 220.00m, Stock = 18, Categoria = "Oficina", FechaCreacion = new DateTime(2023, 4, 14) },
new Producto { Id = 46, Nombre = "Silla Gamer Noblechairs", Descripcion = "Silla ergonómica premium para gaming", Precio = 550.00m, Stock = 5, Categoria = "Muebles", FechaCreacion = new DateTime(2023, 4, 16) },
new Producto { Id = 47, Nombre = "Cámara Nikon", Descripcion = "Cámara DSLR profesional", Precio = 1300.00m, Stock = 8, Categoria = "Fotografía", FechaCreacion = new DateTime(2023, 4, 18) },
new Producto { Id = 48, Nombre = "Monitor Dell", Descripcion = "Monitor 27 pulgadas Full HD", Precio = 180.00m, Stock = 25, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 4, 20) },
new Producto { Id = 49, Nombre = "Ratón Logitech G", Descripcion = "Ratón gaming con 12 botones programables", Precio = 60.00m, Stock = 50, Categoria = "Accesorios", FechaCreacion = new DateTime(2023, 4, 22) },
new Producto { Id = 50, Nombre = "Laptop MSI", Descripcion = "Laptop gamer con RTX 3070", Precio = 1500.00m, Stock = 10, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 4, 25) }




            };

            #region 1. Obtener todos los productos de la lista.
            //var obt = lst.ToList();

            //foreach ( var item in obt )
            //    Console.WriteLine($"{item.Id} | {item.Nombre} | {item.Descripcion}| {item.Precio}| {item.Categoria} | {item.FechaCreacion} | {item.Stock}" );


            #endregion


            #region  2. Obtener los nombres de todos los productos.

            //var obt = lst.Select(X=>X.Nombre);

            //foreach (var item in obt)
            //    Console.WriteLine(item);
            #endregion


            #region 3. Obtener los productos cuyo precio sea mayor a 500.

            //var may = lst.First(p => p.Precio > 500);
            //Console.WriteLine($" {may.Nombre} | {may.Precio}");
            #endregion

            #region 4. Obtener los productos con stock menor a 10.

            //var men = lst.First(p => p.Stock < 10);
            //Console.WriteLine($" {men.Nombre} | {men.Stock}");

            #endregion
            #region // 5. Obtener los productos de la categoría "Electrónica".

            //var dt = lst.Where(i=> i.Categoria == "Electrónica").ToList();
            //foreach(var item in dt)
            //    Console.WriteLine(item.Nombre);
            #endregion


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

            #region// 12. Obtener los primeros 5 productos más caros.
            //var obt = lst.OrderByDescending(X => X.Precio).Take(5);
            //foreach (var item in obt)
            //    Console.WriteLine(item.Precio);
            #endregion

            #region // 13. Obtener los 10 productos con menor stock.
            //var ascen = lst.OrderBy(x => x.Stock).Take(10);

            //foreach (var item in ascen)
            //    Console.WriteLine(item.Stock);
            #endregion

            #region // 14. Obtener la cantidad total de productos en la lista.



            #endregion
            #region 15. Obtener la suma de todos los precios de los productos.

            //decimal res= lst.Sum(p=> p.Precio);
            //Console.WriteLine(res);
            #endregion
            #region // 16. Obtener el precio promedio de los productos.

            //var prom = lst.Average(x => x.Precio);

            //    Console.WriteLine(prom);
            #endregion
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
            #region // 21. Contar cuántos productos hay en la categoría "Audio".
            //var cat=lst.Count(x=>x.Categoria=="Audio");
            //Console.WriteLine(cat);
            #endregion
            #region // 22. Agrupar los productos por categoría.

            //var agru = from i in lst group i by new { i.Categoria } into total select total;

            //foreach (var item in agru)
            //    Console.WriteLine($"{item.Key} ");
            #endregion


            #region // 23. Obtener la categoría con más productos.
            //var agru = from i in lst
            //           group i by new { i.Categoria } into total
            //           select new
            //           {

            //               categoria = total.Key.Categoria,
            //               quant = total.Count(),




            //           };

            //foreach (var item in agru)
            //    Console.WriteLine($" {item.categoria}  | {item.quant}");
            #endregion


            #region // 24. Obtener el stock total de todos los productos.
            //var tal =lst.Sum(x => x.Stock);
            //Console.WriteLine(tal);
            #endregion
            #region // 25. Obtener el producto con el nombre más largo.
            //var lar= lst.OrderByDescending(x=> x.Nombre.Length).First();
            //Console.WriteLine(lar.Nombre);

            #endregion
            #region // 26. Obtener el producto con la descripción más corta.
            //var lar = lst.OrderBy(x => x.Nombre.Length).First();
            //Console.WriteLine(lar.Nombre);
            #endregion
            #region  27. Filtrar los productos cuya descripción contenga la palabra "pantalla".
            //var let = lst.Where(x => x.Descripcion.ToLower().Contains("pantalla"));

            //foreach (var s in let)
            //    Console.WriteLine(s.Descripcion);

            #endregion
            #region // 28. Obtener el promedio de stock de los productos de la categoría "Almacenamiento".

            //var ne = lst.Where(x => x.Categoria == "Almacenamiento").Average(x=>x.Stock);
            //Console.WriteLine(ne);
            #endregion


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
            #region  // 32. Obtener los productos cuyo precio tenga un decimal mayor a .50.

            //var de = from i in lst where i.Precio % 1 > 0.50m select i;

            //foreach (var dc2 in de)
            //    Console.WriteLine($"{dc2.Nombre}| {dc2.Precio}");
            #endregion

            #region // 33. Obtener los productos cuyo nombre tenga más de 10 caracteres.
            //var car = lst.Where(X => X.Nombre.Length > 10);
            //foreach(var item in car)
            //    Console.WriteLine(item.Nombre);
            #endregion

            // 34. Obtener los productos cuyo stock sea un número primo.
            ////var sr = from i in lst where i.Stock > 1 && i.Stock % 2 != 0 select i;

            ////foreach ( var s in sr )
            ////    Console.WriteLine( s.Stock );

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
            #region // 37. Obtener los productos que tengan una descripción con más de 20 caracteres.
            //var lar = lst.Where(x => x.Descripcion.Length > 20);

            //foreach(var x in lar)
            //    Console.WriteLine(x.Descripcion);
            #endregion

            #region  // 38. Obtener los productos cuyo precio sea un número redondo (sin decimales).
            //var de = lst.Where(x => x.Precio % 1 == 0);

            //foreach(var x in de)
            //    Console.WriteLine(x.Precio);
            #endregion
            #region // 39. Obtener los productos que tengan exactamente dos palabras en su nombre.
            //var dv = from i in lst where i.Nombre.Split(' ').Length == 2 select i;

            //foreach ( var v in dv )
            //    Console.WriteLine( v.Nombre );
            #endregion
            #region 40. Obtener la cantidad de productos que no pertenecen a la categoría "General".

            //var ge = lst.Count(x => x.Categoria != "General");
            //Console.WriteLine(ge);
            #endregion





            Console.ReadLine();

        }
        

       
           

        
    }
}
