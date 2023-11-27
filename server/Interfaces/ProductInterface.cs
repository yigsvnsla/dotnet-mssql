namespace Server.Interfaces.ProductsInterface
{
    public interface IProduct
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public bool SoldOut { get; set;}
    }
}
