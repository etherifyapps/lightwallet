using System;
using Xamarin.Forms;
using Etherify.LightWallet.Helpers;

namespace Etherify.LightWallet.Behaviors
{
	public class PasswordValidationBehavior: Behavior<Entry>
	{
		static readonly BindablePropertyKey IsValidPropertyKey = 
			BindableProperty.CreateReadOnly("IsValid", typeof(bool), typeof(RequiredFieldBehavior), false);
		static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

		public bool IsValid
		{
			get { return (bool)base.GetValue(IsValidProperty); }
			private set { base.SetValue(IsValidPropertyKey, value); }
		}


		static readonly BindablePropertyKey ValidationErrorPropertyKey = 
			BindableProperty.CreateReadOnly( "ValidationError", typeof(string), typeof(RequiredFieldBehavior), "");
		static readonly BindableProperty ValidationErrorProperty = ValidationErrorPropertyKey.BindableProperty;

		public string ValidationError
		{
			get { return (string)base.GetValue(ValidationErrorProperty); }
			private set { base.SetValue(ValidationErrorPropertyKey, value); }
		}

		protected override void OnAttachedTo(Entry bindable)
		{
			bindable.TextChanged +=	HandleTextChanged;
			bindable.Unfocused += HandleFocusChanged;
			base.OnAttachedTo(bindable);
		}
		protected override void OnDetachingFrom(Entry bindable)
		{
			bindable.Unfocused -= HandleFocusChanged;
			base.OnDetachingFrom(bindable);
		}

		void HandleTextChanged(object sender, EventArgs e) {
			Validate (((Entry)sender).Text);
		}

		void HandleFocusChanged(object sender, FocusEventArgs e)
		{
			Validate (((Entry)sender).Text);
		}

		void Validate(string password) {
			var helper = new PasswordValidationHelper ();

			this.IsValid = helper.IsValid (password);
			this.ValidationError = helper.ValidationError;
		}
	}
}

