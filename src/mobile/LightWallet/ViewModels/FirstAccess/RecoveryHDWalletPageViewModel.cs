using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;
using Prism.Services;

namespace Etherify.LightWallet.ViewModels
{
	public class RecoveryHDWalletPageViewModel : EtherifyBaseViewModel
	{
		public DelegateCommand RecoveryNowCommand { get; set; }
		public DelegateCommand CancelCommand { get; set; }

		public RecoveryHDWalletPageViewModel (INavigationService navigationService, IPageDialogService dialogService) 
			: base(navigationService, dialogService)
		{
			RecoveryNowCommand = new DelegateCommand (() => _navigationService.NavigateAsync (typeof(WelcomeRecoveryWalletPage).Name));
			CancelCommand = new DelegateCommand (() => _navigationService.NavigateAsync (typeof(FirstAccessPage).Name));
		}
	}
}

