using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel
{
    public interface ISupplier
    {
        string Name { get; set; }
        string Script { get; set; }
    }
}
