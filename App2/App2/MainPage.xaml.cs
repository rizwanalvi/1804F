using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using App2.Model;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage.Streams;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Mobile mb = new Mobile();
            comboBox.ItemsSource = mb.GetAllMobile();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           Mobile mob= (Mobile)  comboBox.SelectedItem;
            txtMobileName.Text = mob.MobileName;
            // imgView.Source = 
            BitmapImage bmp = new BitmapImage(new Uri(mob.ImagePath));
            
            imgView.Source = bmp;
        }
    }
}
