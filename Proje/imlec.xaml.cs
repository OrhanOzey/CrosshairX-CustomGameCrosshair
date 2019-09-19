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
using System.Windows.Shapes;

namespace Crosshair
{
    /// <summary>
    /// imlec.xaml etkileşim mantığı
    /// </summary>
    public partial class imlec : Window
    {
        public imlec()
        {
            InitializeComponent();
            rsCros.Source = new BitmapImage(new Uri("crosshair/2.png", UriKind.Relative));
        }
    }
}
