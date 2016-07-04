using System.Collections.ObjectModel;

namespace PriceComparer.DataModel
{
    public interface IProdPositionSet
    {
        ObservableCollection<IProdPosition> ProductPositions { get; set; }
    }
}
