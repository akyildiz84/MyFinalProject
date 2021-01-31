using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {                                                             //InMemory çalışıcam, demek
            //ProductManager productManger = new ProductManager(new InMemoryProductDal());
            ProductManager productManger = new ProductManager(new EfProductDal());

            foreach (var product in productManger.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }




            
        }
    }
}
