#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.BackgroundTransfer
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IBackgroundTransferContentPartFactory 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Networking.BackgroundTransfer.BackgroundTransferContentPart CreateWithName( string name);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Networking.BackgroundTransfer.BackgroundTransferContentPart CreateWithNameAndFileName( string name,  string fileName);
		#endif
	}
}
