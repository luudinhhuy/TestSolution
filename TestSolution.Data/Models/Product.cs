using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSolution.Commons.Enums;

namespace TestSolution.Models
{
    public class Product
    {
        public int Id { get; set; }
       
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModifile { get; set; }
        public bool? status { get; set; }
        public List<ProductTranslation> productTranslations { get; set; }
        public List<ProductInCategory> productInCategories { get; set; }
        public List<Image> images { get; set; }
    }
}
