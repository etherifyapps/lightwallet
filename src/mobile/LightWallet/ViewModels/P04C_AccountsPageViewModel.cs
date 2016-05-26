using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;

namespace Etherify.LightWallet.ViewModels
{
	public class AccountsPageViewModel : EtherifyBaseViewModel
	{
		public DelegateCommand SearchExistentAccountsCommand { get; set; }

		public AccountsPageViewModel (INavigationService navigationService) : base(navigationService)
		{
			SearchExistentAccountsCommand = new DelegateCommand (() => _navigationService.NavigateAsync (typeof(SearchExistentAccountsPage).Name));
		}
	}
}
