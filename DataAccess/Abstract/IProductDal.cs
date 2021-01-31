using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
//Dal demek, Data Access Layer Veri Erişim(Verişim de olabilir :) ) Katmanı. | Dependencies bağımlılıklar
//Ampulden referans ekleme işe yaramıyorsa, sağ tıklayıp Add>Project Reference tan bunun için Entities, hepsini seçersen Circler Depency miydi neydi, sonsuz bağımlılık demekmiş. Katmanlar kafayı yiyor
//Referans vermeden using yazsan da işe yaramıyormuş. Referans olacak ki, ondan sonra ekleyeceksin
//Farklı methodlar kullanılan katmanlarda klasörlemeden faydalan
namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAllByCategory(int categoryId);

    }
}
