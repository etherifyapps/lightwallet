using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;

namespace Etherify.LightWallet.ViewModels
{
	public class AccountsNavigationPageViewModel : EtherifyBaseViewModel
	{
		public AccountsNavigationPageViewModel (INavigationService navigationService) : base(navigationService)
		{
		}
	}
}
