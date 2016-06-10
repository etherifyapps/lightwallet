using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;
using Prism.Services;

namespace Etherify.LightWallet.Base.ViewModels
{
	public class EtherifyBaseViewModel : BindableBase, INavigationAware
	{
		public INavigationService _navigationService;
		public IPageDialogService _dialogService;

		public static bool setRandomBackgroundColorsToDebug = false;
		internal static string[] _colors;
		internal static int _lastDebugColorId = 0;

		static EtherifyBaseViewModel() {
			_colors = new string[] {
				"Fuchsia",
				"Aqua",
				"Lime",
				"Red",
				"Blue",
				"Teal",
			};
		}

		public string DebugOnlyColor {
			
			get {

				if (!setRandomBackgroundColorsToDebug) {
					//TODO: put the following line to work (I don't know why but Resources is null): 
					//return Application.Current.Resources["lightPrimaryColor"].ToString();

					return "#D1C4E9"; //hotfix (temporary)
				}

				var color = _colors [_lastDebugColorId];

				_lastDebugColorId++;
				if (_lastDebugColorId >= _colors.Length)
					_lastDebugColorId = 0;

				return color;
			}
		}

		public static string BASE_NAVIGATION_URI = "MainMenuPage/DefaultNavigationPage/";

		public EtherifyBaseViewModel (INavigationService navigationService, IPageDialogService dialogService)
		{
			_navigationService = navigationService;
			_dialogService = dialogService;
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

