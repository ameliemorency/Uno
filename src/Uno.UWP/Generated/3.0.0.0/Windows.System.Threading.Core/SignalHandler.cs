#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Threading.Core
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	public delegate void SignalHandler(global::Windows.System.Threading.Core.SignalNotifier @signalNotifier, bool @timedOut);
	#endif
}