﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Util;
using TaxCalculator.Droid;

namespace TaxCalculator.Droid
{
    [Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        static readonly string TAG = "X:" + typeof(SplashActivity).Name;

        public override void OnCreate(Bundle bundle, PersistableBundle persistentState)
        {
            base.OnCreate(bundle, persistentState);
            Log.Debug(TAG, "SplashActivity.OnCreate");
        }

        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            Log.Debug(TAG, "Startup work is finished - starting MainActivity.");
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }

        // Prevent the back button from canceling the startup process
        public override void OnBackPressed() { }

            // Simulates background work that happens behind the splash screen
        async void SimulateStartup()    
        {
            Log.Debug(TAG, "Performing some startup work that takes a bit of time");
            await Task.Delay(40);
            Log.Debug(TAG, "startup work is finished - starting MainActivity");
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
        }
    }
   
