using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace authproject.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public string pic { get; set; }
        public string size { get; set; }
        public int stock { get; set; }
        public int category { get; set; }

        public Product(int id, string name, double price, string pic, string size, int stock, int category)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.pic = pic;
            this.size = size;
            this.stock = stock;
            this.category = category;
        }
    }


}