﻿using System;
using System.Collections.Generic;
using System.Linq;
using Akavache;
using FFImageLoading.Forms.Touch;
using Foundation;
using UIKit;

namespace Cinephile.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            BlobCache.ApplicationName = "Cinephile";
            CachedImageRenderer.Init();

            return base.FinishedLaunching(app, options);
        }

        public override void WillTerminate(UIApplication uiApplication)
        {
            BlobCache.Shutdown();
            base.WillTerminate(uiApplication);
        }
    }
}
