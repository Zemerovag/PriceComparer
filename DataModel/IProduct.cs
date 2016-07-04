using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DataModel
{
    public interface IProduct
    {
        string Name { get; set; }
        ObservableCollection<IProductSource> ProductSources { get; set; }
    }
}
