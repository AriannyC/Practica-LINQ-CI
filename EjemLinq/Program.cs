using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjemLinq
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<productos> lst = new List<productos>
            {
                new productos  { Id = 1, Nombre = "Laptop Dell", Descripcion = "Laptop de 15 pulgadas",
                    Precio = 850.99m, Stock = 10, Categoria = "Electrónica", FechaCreacion = DateTime.Now },
    new productos { Id = 2, Nombre = "Mouse Logitech", Descripcion = "Mouse inalámbrico",
        Precio = 25.50m, Stock = 50, Categoria = "Accesorios", FechaCreacion = DateTime.Now },
    new productos { Id = 3, Nombre = "Teclado Mecánico", Descripcion = "Teclado mecánico RGB",
        Precio = 75.00m, Stock = 30, Categoria = "Accesorios", FechaCreacion = DateTime.Now },
    new productos { Id = 4, Nombre = "Monitor Samsung", Descripcion = "Monitor 24 pulgadas Full HD", 
        Precio = 150.75m, Stock = 20, Categoria = "Electrónica", FechaCreacion = DateTime.Now }
            };



            //var nema = lst.Where(p => p.Nombre.Contains("M"));
            //Console.WriteLine(nema.Nombre);

            //IEnumerable<productos> lst2 = from p in lst where p.Nombre.ToLower().Contains("m") select p;

            //foreach (productos p in lst2)
            //    Console.WriteLine(p.Nombre);


            //var res= lst.Where(p=> p.Stock % 2 == 0);

            //foreach(var item in res)
            //    Console.WriteLine(item.Stock);


            
            var tdp= lst.ToList();

            foreach (var item in tdp)
                Console.WriteLine(item.Nombre);


            
            

            //IEnumerable<productos> lst2 = from p in lst where p.Precio % 2 == 0 select p;

            //foreach (productos p in lst2)
            //    Console.WriteLine(p.Precio);


            Console.ReadLine();
        }
    }
}
