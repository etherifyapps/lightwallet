using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;
using Xamarin.Forms;

namespace Etherify.LightWallet.ViewModels
{
	//https://www.syntaxismyui.com/xamarin-forms-masterdetail-page-navigation-recipe/

	public class AppMenuItem 
	{
		public string Title { get; set; }
		public string IconSource { get; set; }
		public string DestinationPageId { get; set; }
	}

	public class MainMenuPageViewModel : EtherifyBaseViewModel
	{
		public DelegateCommand AccountsCommand { get; set; }
		public DelegateCommand SettingsCommand { get; set; }

		public AppMenuItem[] MenuItemsSource { get; set; }

		private  AppMenuItem _menuItemSelected;
		public AppMenuItem MenuItemSelected {
			get {
				return _menuItemSelected;
			}
			set {
				if (_menuItemSelected != value) {
					_menuItemSelected = value;

					this._navigationService.NavigateAsync (_menuItemSelected.DestinationPageId);
				}
			}
		}


		public MainMenuPageViewModel (INavigationService navigationService) : base(navigationService)
		{
			MenuItemsSource = new AppMenuItem[2];
			MenuItemsSource [0] = new AppMenuItem () { 
				Title = "Accounts", 
				//IconSource = "accounts.png", 
				DestinationPageId = typeof(AccountsPage).Name
			};

			MenuItemsSource [1] = new AppMenuItem () { 
				Title = "Settings", 
				//IconSource = "settings.png", 
				DestinationPageId = typeof(WelcomeNewWalletPage).Name
			};
		}

	}
}

