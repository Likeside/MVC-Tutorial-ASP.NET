using System.Collections.Generic;

namespace MVC_Tutorial.Models
{
    public class Product
    {
        public string Title { get; set; }
        
        public decimal Price { get; set; }
        
        public int Id { get; }

        public Product(List<Product> products)
        {
            products.Add(this);
            this.Id = products.Count;
            
        }
    }
}