namespace PriceComparer.DataModel
{
    public interface IProdPosition
    {
        IProduct Product { get; set; }
        ISupplier Supplier { get; set; }
        int Count { get; }
    }
}
