using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSolution.Commons.Enums;

namespace TestSolution.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModifile { get; set; }
        public Status status { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
    }
}
