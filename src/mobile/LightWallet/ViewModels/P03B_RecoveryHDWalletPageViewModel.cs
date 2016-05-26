using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;

namespace Etherify.LightWallet.ViewModels
{
	public class RecoveryHDWalletPageViewModel : EtherifyBaseViewModel
	{
		public DelegateCommand RecoveryNowCommand { get; set; }
		public DelegateCommand CancelCommand { get; set; }

		public RecoveryHDWalletPageViewModel (INavigationService navigationService) : base(navigationService)
		{
			RecoveryNowCommand = new DelegateCommand (() => _navigationService.NavigateAsync (typeof(WelcomeRecoveryWalletPage).Name));
			CancelCommand = new DelegateCommand (() => _navigationService.NavigateAsync (typeof(FirstAccessPage).Name));
		}
	}
}

