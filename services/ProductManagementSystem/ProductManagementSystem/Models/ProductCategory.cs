using System.ComponentModel.DataAnnotations;

namespace ProductManagementSystem.Models
{
    public class ProductCategory
    {
        [Key]
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public virtual ICollection<ProductSubCategory> SubCategories { get; set; }

    }
}
