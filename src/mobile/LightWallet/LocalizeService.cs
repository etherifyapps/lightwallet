using System;
using System.Reflection;
using System.Diagnostics;
using System.Resources;
using System.Threading;
using System.Globalization;
using Xamarin.Forms;

// https://developer.xamarin.com/guides/xamarin-forms/advanced/localization/

namespace Etherify.LightWallet
{
	public interface ILocalize
	{
		CultureInfo GetCurrentCultureInfo ();

		void SetLocale ();
	}

	public static class LocalizeService
	{
		static readonly CultureInfo ci;

		static LocalizeService () 
		{
			ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo ();
		}

		public static string GetString(string key)
		{
			ResourceManager resourceManager;

			if (ci.Name == "pt-BR") {
				resourceManager = new ResourceManager("Etherify.LightWallet.AppResources.pt_BR", typeof(App).GetTypeInfo().Assembly);
			} 
			//default language is EN
			else {
				resourceManager = new ResourceManager("Etherify.LightWallet.AppResources", typeof(App).GetTypeInfo().Assembly);
			}

			var result = resourceManager.GetString (key);

			//if result is null, return key (help developers to fix the problem)
			return result ?? key;
		}
	}
}

