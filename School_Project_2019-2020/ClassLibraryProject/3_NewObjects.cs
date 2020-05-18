using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ClassLibraryProject
{
    public class NewObjects
    {
        public static int I = 0;                                                                                // Начальный счётчик элементов
        private static int Count = -1;                                                                          // Начальный счётчик
        private static float Deg = -1 * Convert.ToSingle((180 * Timer.Diameter) / (Math.PI * Timer.Radius));    // Начальный угол
        private static float Distance = Timer.Diameter;                                                         // Диаметр

        public static void Circle()
        {
            I++;
            Deg += Convert.ToSingle((180 * Timer.Diameter) / (Math.PI * Timer.Radius)); ; Count++;
            if (Deg >= 360)
            {
                Deg = -1 * Convert.ToSingle((180 * Timer.Diameter) / (Math.PI * Timer.Radius));
                Distance += 1;
                Timer.Enabled = true;
            }
            MarkerSpawn.Tochka(Distance, Timer.Radius, Deg, Count);
        }
    }
}