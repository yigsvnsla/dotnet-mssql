
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Server.Interfaces.ProductsInterface;

namespace Server.Models.ProductModel
{
    public class ProductModel : IProduct
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        [DefaultValue(false)]
        public bool SoldOut { get; set; }
    }
}
