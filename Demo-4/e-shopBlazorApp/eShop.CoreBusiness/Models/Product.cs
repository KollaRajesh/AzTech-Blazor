using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.CoreBusiness.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Maker { get; set; }
        public string img { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<int> Ratings { get; set; }
    }
}
