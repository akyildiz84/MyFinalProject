using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        //class ın içinde ama tüm metotların dışında tanımlama global değişken, naming convention "_*" ile isimlendirilir
        List<Product> _products;
        //ctor constructor bellekte referans aldığı zaman çalışacak blok
        public InMemoryProductDal() //ctrl+space categoryid falan onları otomatik getiriyor
        {

            //oracle, sql server, postgres, mongodb den veri geliyomuş gibi smile ediyoruz
            _products = new List<Product> {
                new Product{ProductId=1,CaregoryId=1,ProductName="Bardak",UnitPrice=15,UnitInStock=15},
                new Product{ProductId=2,CaregoryId=1,ProductName="Kamera",UnitPrice=500,UnitInStock=3},
                new Product{ProductId=3,CaregoryId=2,ProductName="Telefon",UnitPrice=1500,UnitInStock=2},
                new Product{ProductId=4,CaregoryId=2,ProductName="Klavye",UnitPrice=150,UnitInStock=65},
                new Product{ProductId=5,CaregoryId=2,ProductName="Fare",UnitPrice=85,UnitInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query - LINQ olmasaydı listeyi tek tek dolaşmamız gerekiyor
            //Lambda "p"=>
            //SingeOrDefault da olur first ve FirstOrDefault da olur
            //Product productToDelete = null;
            //foreach (var p in _products)
            //{
                //if (product.ProductId==product.ProductId)
                //{
                    //productToDelete = p;
                //}

            //}                               //bu bir metot | takma isim ver  |  kuralı da buraya yaz
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId ==product.ProductId);


            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün Id'sine sahip olan listedeki ürünü bul ve güncelle, sil, birşey yap mantığı
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CaregoryId = product.CaregoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {                                                   //&& ile yeni koşullar ekleyebilirsin
            return _products.Where(p => p.CaregoryId == categoryId).ToList();
        }
    }
}
