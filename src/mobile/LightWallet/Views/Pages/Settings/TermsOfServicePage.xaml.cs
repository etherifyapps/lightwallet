using System;
using System.Collections.Generic;
using Etherify.LightWallet.Services;
using Xamarin.Forms;
using XLabs.Forms.Controls;


namespace Etherify.LightWallet.Views
{
	
	public partial class TermsOfServicePage : ContentPage
	{
		HybridWebView webView;
		Label header;

		public TermsOfServicePage ()
		{
			
			InitializeComponent ();


			header = new Label
			{
				Text = "WebView Javascript Test",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center
			};


			var serializer = new XLabs.Serialization.JsonNET.JsonSerializer();

			webView = new HybridWebView(serializer)
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				IsVisible = true
			};


			var button1 = new Button { Text = "Call JavaScript Directly" };
			button1.Clicked += OnCallJavaScriptButton1Clicked;

			var button2 = new Button { Text = "Call JavaScript using EtherifyService" };
			button2.Clicked += OnCallJavaScriptButton2Clicked;


			// Accomodate iPhone status bar.
			var padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);


			//TODO: Crashing in the android simulator because of https://code.google.com/p/android/issues/detail?id=189040

			this.Padding = padding;
			this.Content = new StackLayout
			{
				BackgroundColor = Color.Red,
				Children = {
					header,

					button1,
					button2,
					webView

				}
			};
		}

		void OnCallJavaScriptButton1Clicked(object sender, EventArgs e)
		{
			webView.CallJsFunction("Etherify.Eth.createRandom12Words", "");
		}

		void OnCallJavaScriptButton2Clicked(object sender, EventArgs e)
		{
			EtherifyService.API.CreateRandom12Words(r => this.DisplayAlert("Etherify", r.random12Words, "OK"));
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			//this.webView.LoadFromContent("HTML/index.html");
			this.webView.LoadFromContent("HTML/webwallet-example.html");
			this.webView.IsVisible = true;

			EtherifyService.Initialize(new EtherifyServiceProviderJsImpl(webView), "http://hookedethereum:8545");
		}

	}
}

