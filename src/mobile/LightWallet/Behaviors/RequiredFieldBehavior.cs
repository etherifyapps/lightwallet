using System;
using Xamarin.Forms;

namespace Etherify.LightWallet.Behaviors
{
	public class RequiredFieldBehavior: Behavior<Entry>
	{
		static readonly BindablePropertyKey IsValidPropertyKey = 
			BindableProperty.CreateReadOnly("IsValid", typeof(bool), typeof(RequiredFieldBehavior), false);
		
		static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

		public bool IsValid
		{
			get { return (bool)base.GetValue(IsValidProperty); }
			private set { base.SetValue(IsValidPropertyKey, value); }
		}

		protected override void OnAttachedTo(Entry bindable)
		{
			bindable.Unfocused += HandleFocusChanged;
			base.OnAttachedTo(bindable);
		}
		protected override void OnDetachingFrom(Entry bindable)
		{
			bindable.Unfocused -= HandleFocusChanged;
			base.OnDetachingFrom(bindable);
		}
		void HandleFocusChanged(object sender, FocusEventArgs e)
		{
			IsValid = !string.IsNullOrEmpty (((Entry)sender).Text);
		}
	}
}

