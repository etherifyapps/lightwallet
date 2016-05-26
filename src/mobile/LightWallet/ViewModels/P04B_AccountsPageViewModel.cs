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
		//public DelegateCommand OkCommand { get; set; }

		public AccountsPageViewModel (INavigationService navigationService) : base(navigationService)
		{
			//OkCommand = new DelegateCommand (() => _navigationService.NavigateAsync (typeof(MainMenuPage).Name));
		}
	}
}
