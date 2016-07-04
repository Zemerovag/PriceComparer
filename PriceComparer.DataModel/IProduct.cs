using System.Collections.ObjectModel;

namespace PriceComparer.DataModel
{
    public interface IProduct
    {
        string Name { get; set; }
        ObservableCollection<IProductSource> ProductSources { get; set; }
    }
}
