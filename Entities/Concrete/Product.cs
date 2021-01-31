using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
//internal sadece Entities erişebilir demektir. short nortwind de int in bir küçüğü
namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CaregoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
