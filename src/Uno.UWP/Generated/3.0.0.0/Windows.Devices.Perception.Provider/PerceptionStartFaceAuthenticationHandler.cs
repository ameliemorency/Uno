#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Perception.Provider
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	public delegate bool PerceptionStartFaceAuthenticationHandler(global::Windows.Devices.Perception.Provider.PerceptionFaceAuthenticationGroup @sender);
	#endif
}
