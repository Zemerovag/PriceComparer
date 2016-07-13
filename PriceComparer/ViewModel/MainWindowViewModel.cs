using System.Collections.ObjectModel;
using System.Windows.Input;
using PriceComparer.ViewModel.Data;

namespace PriceComparer.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<ProdPositionSetViewModel> _prodPositionSets;
        public ObservableCollection<ProdPositionSetViewModel> ProdPositionSets
        {
            get { return _prodPositionSets; }
            set { SetValueAndRaisePropertyChangedEvent(ref _prodPositionSets, value); }
        }

        private ProdPositionSetViewModel _selectedProdPositionSet;
        public ProdPositionSetViewModel SelectedProdPositionSet
        {
            get { return _selectedProdPositionSet; }
            set { SetValueAndRaisePropertyChangedEvent(ref _selectedProdPositionSet, value); }
        }

        public MainWindowViewModel()
        {
            //TODO: change when the loading will be added
            _prodPositionSets = new ObservableCollection<ProdPositionSetViewModel>();
            _selectedProdPositionSet = null;
        }

        #region Commands

        private ICommand _addProdPositionSetCommand;
        public ICommand AddProdPositionSetCommand
        {
            get { return _addProdPositionSetCommand ?? (_addProdPositionSetCommand = new RelayCommand(x => AddProdPositionSet())); }
        }

        private void AddProdPositionSet()
        {
            var newProdPositionSet = new ProdPositionSetViewModel("New ProductPositionSet");
            ProdPositionSets.Add(newProdPositionSet);
            SelectedProdPositionSet = newProdPositionSet;
        }

        private ICommand _deleteProdPositionSetCommand;
        public ICommand DeleteProdPositionSetCommand
        {
            get { return _deleteProdPositionSetCommand ?? (_deleteProdPositionSetCommand = new RelayCommand(x => DeleteProdPositionSet())); }
        }

        private void DeleteProdPositionSet()
        {
            if (SelectedProdPositionSet != null)
            {
                //TODO: add the MessageBox with yes/no options
                var index = ProdPositionSets.IndexOf(SelectedProdPositionSet);
                ProdPositionSets.Remove(SelectedProdPositionSet);
                if (index > ProdPositionSets.Count - 1)
                {
                    index = ProdPositionSets.Count - 1;
                }

                SelectedProdPositionSet = (index >= 0) ? ProdPositionSets[index] : null;
            }
        }

        #endregion

    }
}
