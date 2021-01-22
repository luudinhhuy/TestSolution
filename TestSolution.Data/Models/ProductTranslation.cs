﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSolution.Models
{
    public class ProductTranslation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string  SeoDescription { get; set; }
        public string  Title { get; set; }
        public string  SeoTitle { get; set; }
        public int productId { get; set; }
        public Product product { get; set; }
        public string languageId { get; set; }
        public Language language { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModifile { get; set; }

    }
}
