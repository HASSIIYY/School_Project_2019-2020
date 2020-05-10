using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ClassLibraryProject
{
    public class MarkerSpawn
    {
        public static Ellipse[] Elements = new Ellipse[1000000];
        public static void Tochka(float pointDiameter, double Distance, float Deg, int i)
        {
            Ellipse NewEllipse = new Ellipse
            {
                Width = pointDiameter,
                Fill = (Brush)new BrushConverter().ConvertFrom("#FF323232"),
                Margin = new Thickness(Distance * Math.Cos(Math.PI * Deg / 180), 0, 0, Distance * Math.Sin(Math.PI * Deg / 180))
            };
            Elements[i] = NewEllipse;
            NewEllipse.Height = pointDiameter;
            Timer.NameGrid.Children.Add(NewEllipse);

        }
    }
}