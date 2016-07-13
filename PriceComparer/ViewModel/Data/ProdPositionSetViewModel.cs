using System.Collections.ObjectModel;
using System.Windows.Media;

namespace PriceComparer.ViewModel.Data
{
    public class ProdPositionSetViewModel : ViewModelBase
    {
        public ProdPositionSetViewModel(string name) : this(name, Colors.Green)
        {
        }

        public ProdPositionSetViewModel(string name, Color tileColor)
        {
            _name = name;
            _tileColor = tileColor;
            _productPositions = new ObservableCollection<ProdPositionViewModel>();
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetValueAndRaisePropertyChangedEvent(ref _name, value); }
        }

        private Color _tileColor;
        public Color TileColor
        {
            get { return _tileColor; }
            set { SetValueAndRaisePropertyChangedEvent(ref _tileColor, value); }
        }

        private ObservableCollection<ProdPositionViewModel> _productPositions;
        public ObservableCollection<ProdPositionViewModel> ProductPositions
        {
            get { return _productPositions; }
            set { SetValueAndRaisePropertyChangedEvent(ref _productPositions, value); }
        }
    }
}
