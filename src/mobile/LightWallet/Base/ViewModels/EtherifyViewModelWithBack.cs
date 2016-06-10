using System;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace Etherify.LightWallet.Base.ViewModels
{
	public class EtherifyViewModelWithBack : EtherifyBaseViewModel
	{
		public DelegateCommand BackCommand { get; set; }

		public EtherifyViewModelWithBack (INavigationService navigationService, IPageDialogService dialogService) 
			: base(navigationService, dialogService)
		{
			BackCommand = new DelegateCommand (() => 
				_navigationService.GoBackAsync());

		}
	}
}

