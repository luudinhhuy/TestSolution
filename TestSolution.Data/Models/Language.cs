using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSolution.Models
{
    public class Language
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<ProductTranslation> productTranslations { get; set; }
    }
}
