using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;

namespace Etherify.LightWallet.ViewModels
{
	public class ShowWalletMasterKeyPageViewModel : EtherifyViewModelWithBack
	{
		public DelegateCommand CreateWalletCommand { get; set; }

		public ShowWalletMasterKeyPageViewModel (INavigationService navigationService) : base(navigationService)
		{
			CreateWalletCommand = new DelegateCommand (() => _navigationService.NavigateAsync (typeof(WelcomeNewWalletPage).Name));
		}
	}
}

