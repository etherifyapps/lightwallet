using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;

namespace Etherify.LightWallet.ViewModels
{
	//https://www.syntaxismyui.com/xamarin-forms-masterdetail-page-navigation-recipe/

	public class AppMenuItem
	{
		public int Index { get; set; }
		public string Text { get; set; }
	}

	public class MainMenuPageViewModel : EtherifyBaseViewModel
	{
		public DelegateCommand MenuItemSelectedCommand { get; set; }

		public DelegateCommand AccountsCommand { get; set; }
		public DelegateCommand SettingsCommand { get; set; }

		public AppMenuItem[] MenuItems { get; set; }

		public MainMenuPageViewModel (INavigationService navigationService) : base(navigationService)
		{
			MenuItems = new AppMenuItem[2];
			MenuItems [0] = new AppMenuItem { Index = 0, Text = "Accounts" };
			MenuItems [1] = new AppMenuItem { Index = 1, Text = "Settings" };

			/*
			MenuItemSelectedCommand = new DelegateCommand ((sender, args) =>
				{
					var menuItem = args.SelectedItem as MenuItem;

					switch (menuItem.Index) 
					{
					case 0: 
						RootPage.Detail = new NavigationPage(new AccountsPage()) 
						{
							BarBackgroundColor = AppStyle.BackgroundColor,
							BarTextColor = Color.White
						};
						RootPage.IsPresented = false;
						break;
					case 1:
						RootPage.Detail = new NavigationPage(new ProfilePage()) 
						{
							BarBackgroundColor = AppStyle.BackgroundColor,
							BarTextColor = Color.White
						};
						RootPage.IsPresented = false;
						break;
					case 2:
						RootPage.IsPresented = false;
						Logout();
						break;
					}

					return;
				}			
			);
			*/
		}

		/*
		public void MenuItemSelected() {
		{
			var menuItem = args.SelectedItem as MenuItem;

			switch (menuItem.Index) 
			{
				case 0: 
					RootPage.Detail = new NavigationPage(new AccountsPage()) 
					{
						BarBackgroundColor = AppStyle.BackgroundColor,
						BarTextColor = Color.White
					};
					RootPage.IsPresented = false;
					break;
				case 1:
					RootPage.Detail = new NavigationPage(new ProfilePage()) 
					{
						BarBackgroundColor = AppStyle.BackgroundColor,
						BarTextColor = Color.White
					};
					RootPage.IsPresented = false;
					break;
				case 2:
					RootPage.IsPresented = false;
					Logout();
					break;
			}

			return;
		}
				*/
	}
}

