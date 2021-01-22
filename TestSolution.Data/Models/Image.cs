using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSolution.Commons.Enums;

namespace TestSolution.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string ImagePath { get; set; }
        public long fileSize { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModifile { get; set; }
        public bool? Status { get; set; }
        public int productId { get; set; }
        public Product product { get; set; }
    }
}
