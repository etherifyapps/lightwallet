using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;
using Prism.Services;

namespace Etherify.LightWallet.ViewModels
{
	public class ShowWalletMasterKeyPageViewModel : EtherifyViewModelWithBack, INavigationAware
	{
		public DelegateCommand CreateWalletCommand { get; set; }
		internal string _password;

		public ShowWalletMasterKeyPageViewModel (INavigationService navigationService, IPageDialogService dialogService) 
			: base(navigationService, dialogService)
		{
			CreateWalletCommand = new DelegateCommand (() => _navigationService.NavigateAsync (typeof(WelcomeNewWalletPage).Name));
		}


		#region INavigationAware implementation

		public override void OnNavigatedFrom (NavigationParameters parameters)
		{
			base.OnNavigatedFrom (parameters);
		}

		public override void OnNavigatedTo (NavigationParameters parameters)
		{
			base.OnNavigatedTo (parameters);

			if (!parameters.ContainsKey ("password"))
				throw new Exception ("password parameter required for ShowWalletMasterKeyPage");

			_password = parameters ["password"].ToString();

			_dialogService.DisplayAlert ("Debug", "password = " + _password, "Ok");
		}

		#endregion



	}
}

