using System;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ClassLibraryProject
{
    public class Timer
    {
        public delegate void Link();
        public static Link Obj;
        public static Grid NameGrid;
        public static float Diameter;
        public static float Radius;

        public static DispatcherTimer TimerCount = new DispatcherTimer();
        public static bool Enabled = false;
        public static void NewTimer(Link Objec, Grid GridName, float DiameterNew, float RadiusNew)
        {
            Obj = Objec;
            NameGrid = GridName;
            Diameter = DiameterNew;
            Radius = RadiusNew;

            TimerCount.Interval = TimeSpan.FromTicks(1);
            TimerCount.Tick += TimerTicker;
            if (Enabled == false) TimerCount.Start();
        }
        private static void TimerTicker(object sender, EventArgs e)
        {
            if (Enabled) TimerCount.Stop();
            Obj();
        }
    }
}
