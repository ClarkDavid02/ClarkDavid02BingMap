using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Maps.MapControl.WPF;



namespace CDCasupanan.BingMaps.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counter = 0;

        public MainWindow()
        {
            InitializeComponent();

            myMap.MouseDoubleClick += new MouseButtonEventHandler(myMap_MouseDoubleClick);
        }

        private void myMap_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;

            Point mousePosition = e.GetPosition(this);
            Pushpin pin = new Pushpin();
            pin.Location = myMap.ViewportPointToLocation(mousePosition);
            myMap.Children.Add(pin);

        }
    }
}
