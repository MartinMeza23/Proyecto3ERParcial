using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Proyecto3ERParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Programa Programa = new Programa();
        ObservableCollection<Programa> programa = new ObservableCollection<Programa>();

        public MainWindow()

        {
            InitializeComponent();


           Pelicula pelicula0 = (new Pelicula("Chabelo y Pepito", 1965));
           Pelicula pelicula1 = (new Pelicula("Santo contra los villanos", 1950));
           Pelicula pelicula2 = (new Pelicula("Terminator", 1991));
           Pelicula pelicula3 = (new Pelicula("Matrix", 1999));

            Serie serie0 = (new Serie("Friens", 2016));
            Serie serie1 = (new Serie("Breaking Bad", 2016));
            Serie serie2 = (new Serie("Lost", 2003));

            programa.Add(pelicula0);
            programa.Add(pelicula1);
            programa.Add(pelicula2);
            programa.Add(pelicula3);


            programa.Add(serie0);
            programa.Add(serie1);
            programa.Add(serie2);

            ListaTyA.ItemsSource = programa;
        }

        private void BtnNuevoElemento_Click(object sender, RoutedEventArgs e)
        { 
            
            GrdPincipal.Children.Clear();
            GrdPincipal.Children.Add(new Seleccion ());

            BtnNuevoElemento.Visibility = Visibility.Hidden;

            BtnAñoMayor.Visibility = Visibility.Hidden;
            BtnAñoMenor.Visibility = Visibility.Hidden;

            OrdA.Visibility = Visibility.Hidden;
            OrdZ.Visibility = Visibility.Hidden;

            BtnCancelar.Visibility = Visibility.Visible;
            BtnGuardar.Visibility = Visibility.Visible;

        }

        private void ListaTyA_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            GrdPincipal.Children.Clear();
            BtnNuevoElemento.Visibility = Visibility.Visible;

            BtnAñoMayor.Visibility = Visibility.Visible;
            BtnAñoMenor.Visibility = Visibility.Visible;

            OrdA.Visibility = Visibility.Visible;
            OrdZ.Visibility = Visibility.Visible;

            BtnCancelar.Visibility = Visibility.Hidden;
            BtnGuardar.Visibility = Visibility.Hidden;
        }
    }
}
