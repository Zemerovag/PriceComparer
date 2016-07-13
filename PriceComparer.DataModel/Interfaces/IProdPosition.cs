namespace PriceComparer.DataModel.Interfaces
{
    public interface IProdPosition
    {
        IProduct Product { get; set; }
        IProductSource ProdSource { get; set; }
        int Count { get; }
    }
}
