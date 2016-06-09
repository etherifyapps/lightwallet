using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace Etherify.LightWallet.Base.ViewModels
{
	public class EtherifyBaseViewModel : BindableBase, INavigationAware
	{
		public INavigationService _navigationService;

		//public static bool setRandomBackgroundColorsToDebug = true;
		public static bool setRandomBackgroundColorsToDebug = false;
		internal static int _nextDebugColorId;

		public string DebugOnlyColor {
			
			get {

				if (!setRandomBackgroundColorsToDebug) {
					//TODO: put to work the: 
					//return Application.Current.Resources["lightPrimaryColor"].ToString();
					return "#D1C4E9";
				}

				//return a random color (actually rouding robing over a list)
			
				//TODO: refactor adding an array of collors
				_nextDebugColorId++;

				if (_nextDebugColorId > 3)
					_nextDebugColorId = 1;
				
				if (_nextDebugColorId == 1)
					return "Fuchsia";

				if (_nextDebugColorId == 2)
					return "Aqua";

				return "Lime";
			}
		}

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

