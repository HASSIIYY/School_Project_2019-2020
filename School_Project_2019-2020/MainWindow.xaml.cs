using static ClassLibraryProject.NewObjects;
using ClassLibraryProject;
using System.Windows;
using System;
using System.Linq;

namespace School_Project_2019_2020
{
    public partial class MainWindow : Window
    {
        private void Button1_Grid1_1_Click(object sender, RoutedEventArgs e)
        {
            float Diametr = Convert.ToSingle(TextBox1_Grid1_1.Text);
            float Radius = Convert.ToSingle(TextBox2_Grid1_1.Text);
            Timer.NewTimer(Circle, GridNull, Diametr, Radius);
        }

        private void Button2_Grid1_1_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < MarkerSpawn.Elements.Distinct().Count(); i++)
            {
                MarkerSpawn.Elements.RemoveAt(i);
            }
        }
    }
}
