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
        private static float Deg = -1 * Convert.ToSingle((180 * Timer.Diameter) / (Math.PI * Timer.Radius));    // Начальный угол
        private static int Count = -1;                                                                          // Начальный счётчик
        private static float Distance = Timer.Diameter;                                                         // Диаметр

        public static void Circle()
        {
            Deg += Convert.ToSingle((180 * Timer.Diameter) / (Math.PI * Timer.Radius)); ; Count++;
            if (Deg >= 360) Timer.Enabled = true;
            MarkerSpawn.Tochka(Distance, Timer.Radius, Deg, Count);
        }
    }
}
