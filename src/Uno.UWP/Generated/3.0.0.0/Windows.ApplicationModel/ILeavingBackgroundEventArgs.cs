#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ILeavingBackgroundEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Foundation.Deferral GetDeferral();
		#endif
	}
}
