using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;

namespace Etherify.LightWallet.ViewModels
{
	public class MainMenuPageViewModel : EtherifyBaseViewModel
	{
		public DelegateCommand AccountsCommand { get; set; }
		public DelegateCommand SettingsCommand { get; set; }

		public MenuItem[] MenuItems { get; set; }

		public MainMenuPageViewModel (INavigationService navigationService) : base(navigationService)
		{
			// Assemble an array of NamedColor objects.
			MenuItems = new MenuItem[2];
			MenuItems [0] = new MenuItem { Index = 0, Text = "Accounts" };
			MenuItems [1] = new MenuItem { Index = 1, Text = "Settings" };


			//_nextCommand = new DelegateCommand (() => _navigationService.NavigateAsync (typeof(ConnectingEthereumPage).Name));
		}
	}

	public class MenuItem
	{
		public int Index { get; set; }
		public string Text { get; set; }
	}
}
