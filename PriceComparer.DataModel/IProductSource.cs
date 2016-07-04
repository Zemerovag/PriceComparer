namespace PriceComparer.DataModel
{
    public interface IProductSource
    {
        ISupplier Supplier { get; set; }
        string Link { get; set; }
        double Price { get; set; }
    }
}
