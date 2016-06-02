using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Etherify.LightWallet.Base.ViewModels;
using Etherify.LightWallet.Views;

namespace Etherify.LightWallet.ViewModels
{
	public class SettingsPageViewModel : EtherifyBaseViewModel
	{
		//public DelegateCommand OkCommand { get; set; }

		public SettingsPageViewModel (INavigationService navigationService) : base(navigationService)
		{
			//OkCommand = new DelegateCommand (() => _navigationService.NavigateAsync (typeof(MainMenuPage).Name));
		}
	}
}
