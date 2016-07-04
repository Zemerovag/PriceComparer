using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel
{
    public interface IProductSource
    {
        ISupplier Supplier { get; set; }
        string Link { get; set; }
        double Price { get; set; }
    }
}
