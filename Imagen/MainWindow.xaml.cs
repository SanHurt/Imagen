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

namespace Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const double OPACIDAD_ALTA = 0.9;
        const double OPACIDAD_MEDIA = 0.6;
        const double OPACIDAD_BAJA = 0.3;

        const Stretch AJUSTE_RELLENO = Stretch.Fill;
        const Stretch AJUSTE_UNIFORM = Stretch.Uniform;
        const Stretch AJUSTE_UNIFORM_TO_FILL = Stretch.UniformToFill;
        const Stretch AJUSTE_NONE = Stretch.None;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void opacidadAltaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = OPACIDAD_ALTA;
        }

        private void opacidadMediaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = OPACIDAD_MEDIA;
        }

        private void opacidadBajaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = OPACIDAD_BAJA;
        }

        private void rellenoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = AJUSTE_RELLENO;
        }

        private void uniformRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = AJUSTE_UNIFORM;
        }

        private void uniformFillRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = AJUSTE_UNIFORM_TO_FILL;
        }

        private void noneRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = AJUSTE_NONE;
        }
    }
}
