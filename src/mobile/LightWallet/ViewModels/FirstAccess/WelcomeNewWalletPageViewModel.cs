using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;
using Prism.Services;

namespace Etherify.LightWallet.ViewModels
{
	public class WelcomeNewWalletPageViewModel : EtherifyBaseViewModel
	{
		public DelegateCommand OkCommand { get; set; }

		public WelcomeNewWalletPageViewModel (INavigationService navigationService, IPageDialogService dialogService) 
			: base(navigationService, dialogService)
		{
			OkCommand = new DelegateCommand (() => 
				_navigationService.NavigateAsync ("MainMenuPage/AccountsNavigationPage/AccountsPage"));
		}
	}
}

