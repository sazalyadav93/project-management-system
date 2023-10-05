namespace ProductManagementSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string code { get; set; }
        public int Quantity { get; set; }
        public decimal price { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public int SubCategoryId { get; set; }
        public virtual ProductSubCategory ProductSubCategory { get; set; }

    }
}
