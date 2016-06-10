using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;
using Prism.Services;

namespace Etherify.LightWallet.ViewModels
{
	public class AccountsNavigationPageViewModel : EtherifyBaseViewModel
	{
		public AccountsNavigationPageViewModel (INavigationService navigationService, IPageDialogService dialogService) 
			: base(navigationService, dialogService)
		{
		}
	}
}
