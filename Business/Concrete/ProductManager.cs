using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {

            //İş kodları, bir iş sınıfı başla sınıfları new lemez
            //InMemoryProductDal ınMemoryProductDal = new InMemoryProductDal();
            //Yetkisi var mı? If lar kısmı

            return _productDal.GetAll();
        }
    }
}
