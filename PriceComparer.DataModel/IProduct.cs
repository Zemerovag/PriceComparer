using System.Collections.Generic;

namespace PriceComparer.DataModel
{
    public interface IProduct
    {
        string Name { get; set; }
        List<IProductSource> ProductSources { get; set; }
    }
}
