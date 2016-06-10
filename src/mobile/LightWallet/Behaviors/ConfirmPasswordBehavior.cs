using System;
using Xamarin.Forms;

namespace Etherify.LightWallet.Behaviors
{
	public class ConfirmPasswordBehavior : Behavior<Entry>
	{
		static readonly BindablePropertyKey IsValidPropertyKey = BindableProperty.CreateReadOnly("IsValid", typeof(bool), typeof(ConfirmPasswordBehavior), false);
		public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

		public static readonly BindableProperty CompareToEntryProperty = BindableProperty.Create("CompareToEntry", typeof(Entry), typeof(ConfirmPasswordBehavior), null);

		public Entry CompareToEntry
		{
			get { return (Entry)base.GetValue(CompareToEntryProperty); }
			set { base.SetValue(CompareToEntryProperty, value); }
		}
		public bool IsValid
		{
			get { return (bool)base.GetValue(IsValidProperty); }
			private set { base.SetValue(IsValidPropertyKey, value); }
		}
		protected override void OnAttachedTo(Entry bindable)
		{
			bindable.TextChanged += HandleTextChanged;
			base.OnAttachedTo(bindable);
		}
		protected override void OnDetachingFrom(Entry bindable)
		{
			bindable.TextChanged -= HandleTextChanged;
			base.OnDetachingFrom(bindable);
		}
		void HandleTextChanged(object sender, TextChangedEventArgs e)
		{
			var password = CompareToEntry.Text;
			var confirmPassword = e.NewTextValue;

			if (string.IsNullOrEmpty(password)) {
				IsValid = false;
			}
			else {
				IsValid = password.Equals (confirmPassword);
			}
		}
	}

}

