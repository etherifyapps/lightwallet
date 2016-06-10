using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;
using Prism.Services;
using Etherify.LightWallet.Helpers;

namespace Etherify.LightWallet.ViewModels
{
	public class CreateNewWalletPageViewModel : EtherifyViewModelWithBack
	{
		public DelegateCommand NextCommand { get; set; }

		public string Password { get; set; }
		public string ConfirmPassword { get; set; }

		public string Title { 
			get { 
				return LocalizeService.GetString ("CreateNewWalletPage_Title"); 
			}
		}

		public CreateNewWalletPageViewModel (INavigationService navigationService, IPageDialogService dialogService) 
			: base(navigationService, dialogService)
		{
			NextCommand = new DelegateCommand (() => {
				var helper = new PasswordValidationHelper ();

				if (helper.IsValid(Password, ConfirmPassword)) {
					_navigationService.NavigateAsync (typeof(ShowWalletMasterKeyPage).Name + "?password=" + Password);
				}
				else {
					_dialogService.DisplayAlert("Warning", helper.ValidationError, "Ok");
				}
			});
		}
	}
}

