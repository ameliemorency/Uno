#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Foundation
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WwwFormUrlDecoderEntry : global::Windows.Foundation.IWwwFormUrlDecoderEntry
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string WwwFormUrlDecoderEntry.Name is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  string Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member string WwwFormUrlDecoderEntry.Value is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Foundation.WwwFormUrlDecoderEntry.Name.get
		// Forced skipping of method Windows.Foundation.WwwFormUrlDecoderEntry.Value.get
		// Processing: Windows.Foundation.IWwwFormUrlDecoderEntry
	}
}