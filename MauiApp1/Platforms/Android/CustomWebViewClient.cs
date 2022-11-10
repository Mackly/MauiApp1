using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Android.Webkit;

using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace MauiApp1.Platforms.Android
{
    class CustomWebViewClient : MauiWebViewClient
    {
        public CustomWebViewClient(WebViewHandler handler) : base(handler)
        {

        }
    }
}
