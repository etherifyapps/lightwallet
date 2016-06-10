using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;
using Xamarin.Forms;
using Prism.Services;

namespace Etherify.LightWallet.ViewModels
{
	public class FirstAccessPageViewModel : EtherifyBaseViewModel
	{
		public DelegateCommand CreateNewWalletCommand { get; set; }
		public DelegateCommand RecoveryMyWalletCommand { get; set; }
		public DelegateCommand OpenTermsOfServiceCommand { get; set; }
		public DelegateCommand OpenGithubCommand { get; set; }


		public FirstAccessPageViewModel (INavigationService navigationService, IPageDialogService dialogService) 
			: base(navigationService, dialogService)
		{
			CreateNewWalletCommand = new DelegateCommand (() => {
				_navigationService.NavigateAsync (typeof(CreateNewWalletPage).Name);
			});

			RecoveryMyWalletCommand = new DelegateCommand (() => {
				_navigationService.NavigateAsync (typeof(ConnectingEthereumPage).Name);
			});

			OpenTermsOfServiceCommand = new DelegateCommand (() => {
				_navigationService.NavigateAsync (typeof(TermsOfServicePage).Name, useModalNavigation:true);
			});

			OpenGithubCommand = new DelegateCommand (() => {
				Device.OpenUri(new Uri("https://github.com/etherifyapps/lightwallet"));
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

