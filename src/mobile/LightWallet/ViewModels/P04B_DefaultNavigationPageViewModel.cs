using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;

namespace Etherify.LightWallet.ViewModels
{
	public class DefaultNavigationPageViewModel : EtherifyBaseViewModel
	{
		//public DelegateCommand NextCommand { get; set; }

		public DefaultNavigationPageViewModel (INavigationService navigationService) : base(navigationService)
		{
			//NextCommand = new DelegateCommand (() => _navigationService.NavigateAsync (typeof(ShowWalletMasterKeyPage).Name));
		}
	}
}
