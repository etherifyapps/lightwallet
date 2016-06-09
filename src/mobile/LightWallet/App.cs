using System;

using Xamarin.Forms;
using Etherify.LightWallet.Views;
using Prism.Unity;

using System.Reflection;
using System.Resources;
using Etherify.LightWallet.Base.ViewModels;

namespace Etherify.LightWallet
{
	//Inherited of PrismApplication as defined in the App.xaml
	public partial class App
	{
		#region implemented abstract members of PrismApplicationBase

		protected override void OnInitialized ()
		{
			if (System.Diagnostics.Debugger.IsAttached)
			{
				//used to visual test the area of each view
				//EtherifyBaseViewModel.setRandomBackgroundColorsToDebug = true;
			}

			if (Device.OS != TargetPlatform.WinPhone) {
				DependencyService.Get<ILocalize> ().SetLocale ();
			}

			NavigationService.NavigateAsync (typeof(FirstAccessPage).Name);


			//used to jump to some page (development)
			//NavigationService.NavigateAsync ("FirstAccessPage/CreateNewWalletPage");
			//NavigationService.NavigateAsync ("FirstAccessPage/CreateNewWalletPage/ShowWalletMasterKeyPage/WelcomeNewWalletPage");
			//NavigationService.NavigateAsync ("MainMenuPage/AccountsNavigationPage/AccountsPage");
			//NavigationService.NavigateAsync ("MainMenuPage/SettingsNavigationPage/SettingsPage");
		}

		protected override void RegisterTypes ()
		{
			Container.RegisterTypeForNavigation<FirstAccessPage> ();
			Container.RegisterTypeForNavigation<TermsOfServicePage> ();

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

