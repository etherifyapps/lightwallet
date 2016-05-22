using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;

namespace Etherify.LightWallet.ViewModels
{
	public class ConnectingEthereumPageViewModel : EtherifyViewModelWithBack
	{
		public DelegateCommand NextCommand { get; set; }

		public ConnectingEthereumPageViewModel (INavigationService navigationService) : base(navigationService)
		{
			//_nextCommand = new DelegateCommand (() => _navigationService.NavigateAsync (typeof(ConnectingEthereumPage).Name));
		}
	}
}
