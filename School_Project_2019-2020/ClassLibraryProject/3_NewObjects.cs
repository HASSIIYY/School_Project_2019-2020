using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassLibraryProject
{
    public class NewObjects
    {
        private static float Deg = (float)-0.125; // Начальный угол
        private static int Count = -1;            // Начальный счётчик
        public static void Circle()
        {
            Deg += (float)0.125; Count++;
            if (Deg >= 540) Timer.Enabled = true;
            MarkerSpawn.Tochka(Timer.Diameter, Timer.Radius, Deg, Count);
        }
    }
}
