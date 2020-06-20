using MonWPF.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonWPF.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        private ListeEleveViewModel _listeEleveViewModel;

        #region Constructors
        public MainWindowViewModel()
        {
            ListeEleveViewModel = new ListeEleveViewModel();
        }
        #endregion

        #region Properties
        public ListeEleveViewModel ListeEleveViewModel
        {
            get { return _listeEleveViewModel; }
            set { _listeEleveViewModel = value; }
        }
        #endregion
    }
}
