using System.Collections.Generic;

namespace PriceComparer.DataModel.Interfaces
{
    public interface IProduct
    {
        string Name { get; set; }
        List<IProductSource> ProductSources { get; set; }
    }
}
