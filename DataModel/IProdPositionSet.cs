using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DataModel
{
    public interface IProdPositionSet
    {
        ObservableCollection<IProdPosition> ProductPositions { get; set; }
    }
}
