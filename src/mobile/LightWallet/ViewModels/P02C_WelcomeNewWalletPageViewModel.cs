using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;

namespace Etherify.LightWallet.ViewModels
{
	public class WelcomeNewWalletPageViewModel : EtherifyBaseViewModel
	{
		public DelegateCommand OkCommand { get; set; }

		public WelcomeNewWalletPageViewModel (INavigationService navigationService) : base(navigationService)
		{
			OkCommand = new DelegateCommand (() => 
				_navigationService.NavigateAsync ("MainMenuPage/DefaultNavigationPage/AccountsPage"));

		}
	}
}

