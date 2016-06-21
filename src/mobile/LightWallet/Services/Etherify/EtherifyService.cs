using System;

namespace Etherify.LightWallet.Services
{
	public class EtherifyService
	{
		#region Static Properties/Methods

		static IEtherifyServiceProvider _api = null;
		static string _hookekEthereumHost;

		public static IEtherifyServiceProvider API
		{
			get
			{
				if (_api == null)
					throw new Exception ("EtherifyService must be initialized before EtherifyService.API being accessed!");

				return _api;
			}
		}
			

		public static void Initialize(IEtherifyServiceProvider etherifyServiceProvider, string hookekEthereumHost = "http://hookedethereum:8545") {
			_api = etherifyServiceProvider;
			_hookekEthereumHost = hookekEthereumHost;

			_api.SetHookekEthereumHost (_hookekEthereumHost);
		}

		#endregion

		public EtherifyService ()
		{
		}
	}

	#region API DTOs

	public class CreateRandom12WordsResult 
	{
		public bool success { get; set; }
		public string random12Words { get; set; }
		public string error { get; set; }
	}


	#endregion
}

