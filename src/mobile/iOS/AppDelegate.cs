using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Etherify.LightWallet.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			// Code for starting up the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
			#endif

			//TODO: check if this can be done in forms using styles
			//UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.Default, false);

			LoadApplication (new App () as Xamarin.Forms.Application);

			return base.FinishedLaunching (app, options);
		}
	}
}

