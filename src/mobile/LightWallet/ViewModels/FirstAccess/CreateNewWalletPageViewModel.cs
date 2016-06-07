using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;

namespace Etherify.LightWallet.ViewModels
{
	public class CreateNewWalletPageViewModel : EtherifyViewModelWithBack
	{
		public DelegateCommand NextCommand { get; set; }

		public string Title { 
			get { 
				return LocalizeService.GetString ("CreateNewWalletPage_Title"); 
			}
		}

		public CreateNewWalletPageViewModel (INavigationService navigationService) : base(navigationService)
		{
			NextCommand = new DelegateCommand (() => _navigationService.NavigateAsync (typeof(ShowWalletMasterKeyPage).Name));
		}
	}
}

