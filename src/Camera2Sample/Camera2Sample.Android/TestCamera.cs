using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Camera2Sample.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(TestCamera))]
namespace Camera2Sample.Droid
{
    public class TestCamera : ICamera
    {
        private MainActivity mainActivity;

        public void ShowCameraPage()
        {
            mainActivity = Forms.Context as MainActivity;
            mainActivity.ShowCameraPage();
        }
    }
}