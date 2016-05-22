using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;

namespace Etherify.LightWallet.ViewModels
{
	public class FirstAccessPageViewModel : EtherifyBaseViewModel
	{
		public DelegateCommand CreateNewWalletCommand { get; set; }
		public DelegateCommand RecoveryMyWalletCommand { get; set; }

		public FirstAccessPageViewModel (INavigationService navigationService) : base(navigationService)
		{
			CreateNewWalletCommand = new DelegateCommand (() => {
				var task = _navigationService.NavigateAsync (typeof(CreateNewWalletPage).Name);
				task.Wait();
			});

			RecoveryMyWalletCommand = new DelegateCommand (() => {
				_navigationService.NavigateAsync (typeof(ConnectingEthereumPage).Name);
			});
			
		}

		/*
		public override void OnNavigatedFrom (NavigationParameters parameters)
		{
			base.OnNavigatedFrom (parameters);

			//do something
		}

		public override void OnNavigatedTo (NavigationParameters parameters)
		{
			base.OnNavigatedTo (parameters);

			//do something
		}
		*/

	}
}

