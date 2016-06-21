using System;
using System.Threading.Tasks;

namespace Etherify.LightWallet.Services
{
	public interface IEtherifyServiceProvider
	{
		void SetHookekEthereumHost(string value);
		void CreateRandom12Words(Action<CreateRandom12WordsResult> callback, string userRandomString = "");			
	}
}

