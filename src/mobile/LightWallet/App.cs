using System;

using Xamarin.Forms;
using Etherify.LightWallet.Views;
using Prism.Unity;

using System.Reflection;
using System.Resources;

namespace Etherify.LightWallet
{
	//Inherited of PrismApplication as defined in the App.xaml
	public partial class App
	{
		#region implemented abstract members of PrismApplicationBase

		protected override void OnInitialized ()
		{
			var x = new Button ();
			if (Device.OS != TargetPlatform.WinPhone) {
				DependencyService.Get<ILocalize> ().SetLocale ();
			}

			NavigationService.NavigateAsync (typeof(FirstAccessPage).Name);

			//NavigationService.NavigateAsync ("FirstAccessPage/CreateNewWalletPage/ShowWalletMasterKeyPage/WelcomeNewWalletPage");
			//NavigationService.NavigateAsync ("FirstAccessPage/CreateNewWalletPage");


			//used to jump to some page (development)
			//NavigationService.NavigateAsync ("MainMenuPage/AccountsNavigationPage/AccountsPage");
			//NavigationService.NavigateAsync ("MainMenuPage/SettingsNavigationPage/SettingsPage");
		}

		protected override void RegisterTypes ()
		{
			Container.RegisterTypeForNavigation<FirstAccessPage> ();

			Container.RegisterTypeForNavigation<CreateNewWalletPage> ();
			Container.RegisterTypeForNavigation<ShowWalletMasterKeyPage> ();
			Container.RegisterTypeForNavigation<WelcomeNewWalletPage> ();

			Container.RegisterTypeForNavigation<ConnectingEthereumPage> ();
			Container.RegisterTypeForNavigation<RecoveryHDWalletPage> ();
			Container.RegisterTypeForNavigation<WelcomeRecoveryWalletPage> ();

			Container.RegisterTypeForNavigation<MainMenuPage> ();

			Container.RegisterTypeForNavigation<AccountsNavigationPage> ();
			Container.RegisterTypeForNavigation<AccountsPage> ();
			Container.RegisterTypeForNavigation<SearchExistentAccountsPage> ();

			Container.RegisterTypeForNavigation<SettingsNavigationPage> ();
			Container.RegisterTypeForNavigation<SettingsPage> ();
		}

		#endregion

	}
}

