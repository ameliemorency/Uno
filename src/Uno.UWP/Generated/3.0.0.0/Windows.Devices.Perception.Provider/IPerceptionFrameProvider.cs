#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Perception.Provider
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IPerceptionFrameProvider : global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool Available
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Devices.Perception.Provider.PerceptionFrameProviderInfo FrameProviderInfo
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.Foundation.Collections.IPropertySet Properties
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.Devices.Perception.Provider.IPerceptionFrameProvider.FrameProviderInfo.get
		// Forced skipping of method Windows.Devices.Perception.Provider.IPerceptionFrameProvider.Available.get
		// Forced skipping of method Windows.Devices.Perception.Provider.IPerceptionFrameProvider.Properties.get
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Start();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Stop();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void SetProperty( global::Windows.Devices.Perception.Provider.PerceptionPropertyChangeRequest value);
		#endif
	}
}
