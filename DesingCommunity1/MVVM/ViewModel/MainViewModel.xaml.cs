using DesingCommunity1.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesingCommunity1.MVVM.ViewModel
{
	/// <summary>
	/// Interaction logic for MainViewModel.xaml
	/// </summary>
	public partial class MainViewModel : ObservableObject
	{
		public RelayCommand HomeViewCommande { get; set; }
		public RelayCommand AcceuilViewCommand { get; set; }
		public HomeViewModel HomeVM { get; set; }
		public AcceuilViewModel AcceuilVM { get; set; }

		private object _currentView;

		public object CurrentView
		{
			get { return _currentView; }
			set
			{
				_currentView = value;
				OnPropertyChanged("CurrentView");
			}
		}

		public MainViewModel()
		{
			HomeVM = new HomeViewModel();
			AcceuilVM = new AcceuilViewModel();


			CurrentView = HomeVM;

			HomeViewCommand = new RelayCommand(o => { CurrentView = HomeVM; });

			AcceuilViewCommand = new RelayCommand(o =>
			{
				CurrentView = AcceuilVM;

			});
		}
	}
}