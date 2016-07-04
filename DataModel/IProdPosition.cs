using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel
{
    public interface IProdPosition
    {
        IProduct Product { get; set; }
        ISupplier Supplier { get; set; }
        int Count { get; }
    }
}
