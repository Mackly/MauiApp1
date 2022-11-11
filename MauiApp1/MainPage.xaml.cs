using Microsoft.Maui.Handlers;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
#if ANDROID
        Microsoft.Maui.Handlers.WebViewHandler.Mapper.ModifyMapping(nameof(Android.Webkit.WebViewClient), (handler, view, action) =>
        {
            MapCustomWebViewClient(handler, view);
        });
#endif
    }

#if ANDROID
    public void MapCustomWebViewClient(IWebViewHandler handler, IWebView webView)
    {
        WebViewHandler.MapWebViewClient(handler, webView);
        handler.PlatformView.SetWebViewClient(new MauiApp1.Platforms.Android.CustomWebViewClient(handler as WebViewHandler));
    }
#endif
}

