#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Shell
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IAdaptiveCard 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		string ToJson();
		#endif
	}
}
