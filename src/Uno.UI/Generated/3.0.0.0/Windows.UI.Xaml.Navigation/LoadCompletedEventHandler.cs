#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Navigation
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	public delegate void LoadCompletedEventHandler(object @sender, global::Windows.UI.Xaml.Navigation.NavigationEventArgs @e);
	#endif
}
