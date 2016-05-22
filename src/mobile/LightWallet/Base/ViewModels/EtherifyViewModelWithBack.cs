using System;
using Prism.Commands;
using Prism.Navigation;

namespace Etherify.LightWallet.Base.ViewModels
{
	public class EtherifyViewModelWithBack : EtherifyBaseViewModel
	{
		public DelegateCommand BackCommand { get; set; }

		public EtherifyViewModelWithBack (INavigationService navigationService) : base(navigationService)
		{
			BackCommand = new DelegateCommand (() => 
				_navigationService.GoBackAsync());

		}
	}
}

