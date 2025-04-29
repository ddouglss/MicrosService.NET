using System.ComponentModel.DataAnnotations;

namespace GeekShopping.Web.Models
{
    public class ProductModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
        [Range(1, 100)]
        public int Count { get; set; } = 1;

        public string SubstringName()
        { 
            if (string.IsNullOrEmpty(Name)) return "";
            return Name.Length > 24 ? $"{ Name.Substring (0, 21)} ..." : Name;
           
        }
        public string SubstringDescription()
        { 
            if (string.IsNullOrEmpty(Description)) return Description;
            return Description.Length > 355 ? $"{Description.Substring(0, 352)} ..." : Description;
   
        }
    }
}
