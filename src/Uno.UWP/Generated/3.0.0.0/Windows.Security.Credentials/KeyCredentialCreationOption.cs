#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Credentials
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum KeyCredentialCreationOption 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		ReplaceExisting,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		FailIfExists,
		#endif
	}
	#endif
}
