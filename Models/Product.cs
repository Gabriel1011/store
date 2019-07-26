using System;

namespace Store.Models
{
    public class Product
    {
        public static object Add { get; internal set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }       
    }
}