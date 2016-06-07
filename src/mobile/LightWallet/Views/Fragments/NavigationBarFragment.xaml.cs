using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Etherify.LightWallet.Views
{
	public partial class NavigationBarFragment : StackLayout
	{
		public string Title { get; set; }

		public NavigationBarFragment ()
		{
			InitializeComponent ();
		}
	}
}

