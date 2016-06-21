using System;
using System.Threading.Tasks;
using XLabs.Forms.Controls;
using System.Threading;
using XLabs.Serialization.JsonNET;
using System.Collections.Generic;

namespace Etherify.LightWallet.Services
{
	public class FuncCallingControl<T> where T:class {
		public readonly object _lock = new object();
		public Action<T> _callback { get; set; }
	}

	public class EtherifyServiceProviderJsImpl: IEtherifyServiceProvider
	{
		#region Private Fields

		const string EhterifyNamespacePrefix = "Etherify.Eth.";

		readonly HybridWebView _hybridWebView;
		readonly JsonSerializer _serializer = new XLabs.Serialization.JsonNET.JsonSerializer ();

		Dictionary<Type, Object> _userCallbackReferences = new Dictionary<Type, object> ();

		#endregion


		#region Constructor and Initializations

		public EtherifyServiceProviderJsImpl (HybridWebView hybridWebView) {
			if (hybridWebView == null)
				throw new ArgumentNullException ("hybridWebView");

			_hybridWebView = hybridWebView;

			RegisterCallbacksForJavascriptCalls ();
		}

		private void RegisterCallbacksForJavascriptCalls() {

			RegisterCallback<CreateRandom12WordsResult> ("createRandom12WordsResult");

		}

		#endregion


		#region IEtherifyServiceProvider Implementation

		public void SetHookekEthereumHost(string value) {
			//TODO Validate url in 'value' parameter. Ex: http://hookedethereum:8545

			_hybridWebView.CallJsFunction (EhterifyNamespacePrefix + "setHookekEthereumHost", value);
		}
			
		public void CreateRandom12Words(Action<CreateRandom12WordsResult> callback, string userRandomString = "") {	

			CallGenericAsyncJavascriptAPI<CreateRandom12WordsResult> (
				callback, EhterifyNamespacePrefix + "createRandom12Words", userRandomString);
		}

		#endregion


		#region Private Methods

		private void AddFuncCallingControl<T>() where T:class {
			_userCallbackReferences [typeof(T)] = new FuncCallingControl<T>();
		}

		private FuncCallingControl<T> GetFuncCallingControl<T>() where T:class {
			return (_userCallbackReferences [typeof(T)] as FuncCallingControl<T>);
		}

		private void CallGenericAsyncJavascriptAPI<T>(Action<T> callback, string javascriptFunction, params object[] parameters ) where T:class {

			//TODO  Avoid deadlock with timeout in EtherifyServiceProviderJsImpl.CallGenericAsyncJavascriptAPI

			Monitor.Enter(GetFuncCallingControl<T>()._lock);
			try
			{
				GetFuncCallingControl<T>()._callback = callback;
				_hybridWebView.CallJsFunction (javascriptFunction, parameters);

			}
			catch (Exception e)
			{
				Monitor.Exit(GetFuncCallingControl<T>()._lock);
				throw new Exception (string.Format("EtherifyServiceProviderJsImpl raised an error when calling the javascript function {0}().", javascriptFunction), e);
			}
		}

		private void RegisterCallback<T> (string jsCallbackName) where T:class {

			//create object to control lock and keep the reference to the user callback function
			AddFuncCallingControl<T> ();

			//register a c# callback (lambda above) to bring to us the javascript result
			_hybridWebView.RegisterCallback(jsCallbackName, json =>
				{
					T result = null;
					try {
						result = _serializer.Deserialize<T>(json);
					}
					catch (Exception e) {
						Monitor.Exit(GetFuncCallingControl<T>()._lock);
						throw new Exception (string.Format("EtherifyServiceProviderJsImpl raised an error when deserializing the result from javascript {0} function.", jsCallbackName), e);
					}

					if (result == null)
						throw new Exception (string.Format("EtherifyServiceProviderJsImpl: javascript function {0} returned null value.", jsCallbackName));

					if (GetFuncCallingControl<T>()._callback != null)
						GetFuncCallingControl<T>()._callback(result);

				});

		}

		#endregion
			

	}
}

