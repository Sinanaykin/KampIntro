using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
   public  class ProductManager
    {
        public void Add(Product product)//Ürün ekliceksek ürün göndermeliyiz.Product türünde  bir product göndermeliyiz int id gibi.
                                        //ilk Product ı yazmak yerine teker teker int Id,string ProductName ... gibi özelliklerin hepsini yzabiliriz
                                        // ama Encapsulation  kullanımı olarak hepsi Product altında toplanmış bu yüzden Product yolluyoruz direk
        {
            Console.WriteLine(product.ProductName + "eklendi");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi");
        }
     }
}
