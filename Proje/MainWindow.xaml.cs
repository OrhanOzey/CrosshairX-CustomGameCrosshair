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

namespace Crosshair
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        imlec imlec1 = new imlec();
        public MainWindow()
        {
            InitializeComponent();
            this.Left = SystemParameters.PrimaryScreenWidth - 350;
            this.Top = SystemParameters.PrimaryScreenHeight / 2 - 200;
            CrosshairResimListe = new List<BitmapImage>();
            imlec1.Show();
            CrosshairListeDoldur();
            CrosshairListele();
        }

        private void CrosshairListele()
        {
            for (int i = 0; i < 200; i++)
            {
                CrosshairResimListe.Add(CrosshairListe[i]);
            }

            for (int i = 0; i < 200; i++)
            {
                Image resim = new Image();
                lbCrosshair.Items.Add(resim);
                resim.Source = CrosshairListe[i];
                resim.Width = 75;
            }
        }

        public List<BitmapImage> CrosshairListe { get; private set; }
        public List<BitmapImage> CrosshairResimListe { get; private set; }

        private void CrosshairListeDoldur()
        {
            CrosshairListe = new List<BitmapImage>();
            string ResimKlasoru = "crosshair/";
            for (int i = 0; i < 200; i++)
            {
                CrosshairListe.Add(new BitmapImage(new Uri(ResimKlasoru + "crosshair" + i + ".png", UriKind.Relative)));
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            imlec1.Close();
        }

        private void LbCrosshair_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            imlec1.rsCros.Source = (lbCrosshair.SelectedItem as Image).Source;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           imlec1.rsCros.Width = rsSlider.Value * 100;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lBaslik.Text = "Crosshair List";
            lBoyut.Text = "Crosshair Size";
            lNot.Text = "Info : If crosshair is not working, be sure in-game settings Graphics Mode Borderless in mode.";
            this.Title = "CrosshairX Settings";
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            lBaslik.Text = "Crosshair Listesi";
            lBoyut.Text = "Crosshair Boyutu";
            lNot.Text = "Bilgi : Eğer Oyun içerisinde Crosshair gözükmüyor ise Oyununuzun Ekran Görüntüsü Ayarları Borderless/Çerçevesiz olduğundan emin olun.";
            this.Title = "CrosshairX Ayarlar";
        }
    }
}
