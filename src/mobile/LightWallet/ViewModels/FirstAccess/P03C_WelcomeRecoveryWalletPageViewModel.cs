using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;

namespace Etherify.LightWallet.ViewModels
{
	public class WelcomeRecoveryWalletPageViewModel : EtherifyBaseViewModel
	{
		public DelegateCommand OkCommand { get; set; }

		public WelcomeRecoveryWalletPageViewModel (INavigationService navigationService) : base(navigationService)
		{
			//TODO Go to the P07A_SearchExistentAccountsPage and start the scan

			OkCommand = new DelegateCommand (() => 
				_navigationService.NavigateAsync ("MainMenuPage/DefaultNavigationPage/AccountsPage"));
		}
	}
}

