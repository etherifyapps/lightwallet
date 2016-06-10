using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;
using Prism.Services;

namespace Etherify.LightWallet.ViewModels
{
	public class AccountsPageViewModel : EtherifyBaseViewModel
	{
		public DelegateCommand SearchExistentAccountsCommand { get; set; }

		public AccountsPageViewModel (INavigationService navigationService, IPageDialogService dialogService) 
			: base(navigationService, dialogService)
		{
			SearchExistentAccountsCommand = new DelegateCommand (() => _navigationService.NavigateAsync (typeof(SearchExistentAccountsPage).Name));
		}
	}
}
