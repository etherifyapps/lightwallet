using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;
using Prism.Services;

namespace Etherify.LightWallet.ViewModels
{
	public class ConnectingEthereumPageViewModel : EtherifyViewModelWithBack
	{
		public DelegateCommand NextCommand { get; set; }

		public ConnectingEthereumPageViewModel (INavigationService navigationService, IPageDialogService dialogService) 
			: base(navigationService, dialogService)
		{
			NextCommand = new DelegateCommand (() => _navigationService.NavigateAsync (typeof(RecoveryHDWalletPage).Name));
		}
	}
}
