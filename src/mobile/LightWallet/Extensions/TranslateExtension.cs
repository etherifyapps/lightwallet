using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using System.Resources;
using System.Globalization;
using System.Reflection;

namespace Etherify.LightWallet.Extensions
{
	// You exclude the 'Extension' suffix when using in Xaml markup
	[ContentProperty ("Text")]
	public class TranslateExtension : IMarkupExtension
	{
		public string Text { get; set; }

		public object ProvideValue (IServiceProvider serviceProvider)
		{
			if (Text == null)
				return "";

			var translation = LocalizeService.GetString (Text) ?? Text; 

			return translation;
		}
	}
}

