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
			NavigationService.NavigateAsync (typeof(FirstAccessPage).Name);
		}

		protected override void RegisterTypes ()
		{
			Container.RegisterTypeForNavigation<FirstAccessPage> ();
			Container.RegisterTypeForNavigation<ConnectingEthereumPage> ();
			Container.RegisterTypeForNavigation<CreateNewWalletPage> ();
		}

		#endregion

	}
}

