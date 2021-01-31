using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
//using işaretleme, adres tanımlama gibi birşey. aynı isimde farklı class varsa çarşı pazar karışmasın diye

namespace Entities.Concrete
{
    //Çıplak Class kalmasın ÇCK. Class eğer inheritance ya da interface implementasyonu almıyorsa problem çıkabilir, ayık ol
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
