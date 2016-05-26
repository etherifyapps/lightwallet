using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;

namespace Etherify.LightWallet.Base.ViewModels
{
	public class EtherifyBaseViewModel : BindableBase, INavigationAware
	{
		public INavigationService _navigationService;

		public static string BASE_NAVIGATION_URI = "MainMenuPage/DefaultNavigationPage/";

		public EtherifyBaseViewModel (INavigationService navigationService)
		{
			_navigationService = navigationService;
		}

		#region INavigationAware implementation

		public virtual void OnNavigatedFrom (NavigationParameters parameters)
		{
		}

		public virtual void OnNavigatedTo (NavigationParameters parameters)
		{
		}

		#endregion
	}

}

