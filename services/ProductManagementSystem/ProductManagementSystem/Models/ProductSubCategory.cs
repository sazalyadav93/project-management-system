using System.ComponentModel.DataAnnotations;

namespace ProductManagementSystem.Models
{
    public class ProductSubCategory
    {
        [Key]
        public int SubCategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
