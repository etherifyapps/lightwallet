using System;

namespace Etherify.LightWallet.Helpers
{
	public class PasswordValidationHelper
	{
		const int PASSWORD_MIN_LENGTH = 8;

		public string ValidationError { get; set; }

		public bool IsValid(string password) {
			if (string.IsNullOrEmpty (password)) {
				ValidationError = LocalizeService.GetString ("CreateNewWalletPage_PasswordFieldIsRequired"); 
				return false;
			}

			if (password.Length < PASSWORD_MIN_LENGTH) {
				ValidationError = LocalizeService.GetString ("CreateNewWalletPage_PasswordMustHave8CharsOrMore"); 
				return false;
			}

			ValidationError = ""; 
			return true;
		}


		public bool IsValid(string password, string confirmPassword) {
			var isValid = IsValid (password);
			if (!isValid) {
				return false;
			}

			if (password != confirmPassword) {
				ValidationError = LocalizeService.GetString ("CreateNewWalletPage_ConfirmPasswordIsDifferent");
				return false;
			}

			ValidationError = ""; 
			return true;
		}

	}
}

