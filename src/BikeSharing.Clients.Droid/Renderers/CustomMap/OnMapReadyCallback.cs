using System;
using Android.Gms.Maps;

namespace BikeSharing.Clients.Droid.Renderers.CustomMap
{
    public class OnMapReadyCallback : Java.Lang.Object, IOnMapReadyCallback
    {
        private Action<GoogleMap> _callBack;

        public OnMapReadyCallback(Action<GoogleMap> callBack)
        {
            _callBack = callBack;
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            _callBack(googleMap);
        }
    }
}