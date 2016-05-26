using System;

using Xamarin.Forms;
using Etherify.LightWallet.Views;
using Prism.Unity;

namespace Etherify.LightWallet
{
	public class App : PrismApplication
	{
		#region implemented abstract members of PrismApplicationBase

		protected override void OnInitialized ()
		{
			//NavigationService.NavigateAsync ("FirstAccessPage");

			NavigationService.NavigateAsync ("MainMenuPage/DefaultNavigationPage/AccountsPage");
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
			Container.RegisterTypeForNavigation<DefaultNavigationPage> ();

			Container.RegisterTypeForNavigation<AccountsPage> ();
			Container.RegisterTypeForNavigation<SearchExistentAccountsPage> ();


			Container.RegisterTypeForNavigation<SettingsPage> ();
		}

		#endregion

	}
}

