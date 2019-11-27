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
        ObservableCollection<DatosPeli_Ser> datosPeli_Ser = new ObservableCollection<DatosPeli_Ser>();
        ObservableCollection<Pelicula> pelicula = new ObservableCollection<Pelicula>();
        ObservableCollection<Serie> serie = new ObservableCollection<Serie>();
        public MainWindow()
        {
            InitializeComponent();

            Pelicula pelicula1 = new Pelicula("Chabelo y Pepito", 1965, "Accion", "asdfsdf", "sdfsadfasdf", 5);
            Pelicula pelicula2 = new Pelicula("Santo contra los villanos", 1950, "", "", "", 5);
            Pelicula pelicula3 = new Pelicula("Terminator", 1991, "sdfsd", "sdfsdf", "sdfsdf", 5);
            Pelicula pelicula4 = new Pelicula("Matrix", 1999, "sdfsd", "sdfsf", "sdfsdf", 5);

            Serie serie1 = new Serie("Friens", 2016, "Romance", 7, "sepa", "sdfds", 5);
            Serie serie2 = new Serie("Breaking Bad", 2016, "Accion", 7, "sepa", "dfsdf", 5);
            Serie serie3 = new Serie("Lost", 2003, "aasd", 7, "sepa", "sdfsdf", 5);

            datosPeli_Ser.Add(serie1);
            datosPeli_Ser.Add(serie2);
            datosPeli_Ser.Add(serie3);
            datosPeli_Ser.Add(pelicula1);
            datosPeli_Ser.Add(pelicula2);
            datosPeli_Ser.Add(pelicula3);
            datosPeli_Ser.Add(pelicula4);

            lstPeliculaSerie.ItemsSource = datosPeli_Ser;
        }



        private void lstPeliculaSerie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnCancelarNuevo_Click(object sender, RoutedEventArgs e)
        {
            GrdPrincipal.Children.Clear();
            BtnNuevoElemento.Visibility = Visibility.Visible;
            BtnAscAZ.Visibility = Visibility.Visible;
            BtnDescZA.Visibility = Visibility.Visible;
            BtnAscAño.Visibility = Visibility.Visible;
            BtnDescAño.Visibility = Visibility.Visible;
            BtnGuardarNuevo.Visibility = Visibility.Hidden;
            BtnCancelarNuevo.Visibility = Visibility.Hidden;
        }

        private void BtnGuardarNuevo_Click(object sender, RoutedEventArgs e)
        {
            GrdPrincipal.Children.Clear();
            BtnNuevoElemento.Visibility = Visibility.Visible;
            BtnAscAZ.Visibility = Visibility.Visible;
            BtnDescZA.Visibility = Visibility.Visible;
            BtnAscAño.Visibility = Visibility.Visible;
            BtnDescAño.Visibility = Visibility.Visible;
            BtnGuardarNuevo.Visibility = Visibility.Hidden;
            BtnCancelarNuevo.Visibility = Visibility.Hidden;
        }

        private void BtnNuevoElemento_Click_1(object sender, RoutedEventArgs e)
        {
            GrdPrincipal.Children.Clear();
            GrdPrincipal.Children.Add(new SeleccionarPS());
            BtnNuevoElemento.Visibility = Visibility.Hidden;
            BtnAscAZ.Visibility = Visibility.Hidden;
            BtnDescZA.Visibility = Visibility.Hidden;
            BtnAscAño.Visibility = Visibility.Hidden;
            BtnDescAño.Visibility = Visibility.Hidden;
            BtnGuardarNuevo.Visibility = Visibility.Visible;
            BtnCancelarNuevo.Visibility = Visibility.Visible;

        }

        private void BtnAscAZ_Click(object sender, RoutedEventArgs e)
        {
            bool cambio;
            do
            {
                cambio = false;
                for (int i = 0; i < (datosPeli_Ser.Count - 1); i++)
                {
                    if (string.Compare(datosPeli_Ser[i].Titulo, datosPeli_Ser[i + 1].Titulo) > 0)
                    {
                        var temp = datosPeli_Ser[i];
                        datosPeli_Ser[i] = datosPeli_Ser[i + 1];
                        datosPeli_Ser[i + 1] = temp;
                        cambio = true;
                    }
                }
            } while (cambio == true);
        }

        private void BtnAscAño_Click(object sender, RoutedEventArgs e)
        {
            int gap, i;
            gap = datosPeli_Ser.Count / 2;
            while (gap > 0)
            {
                for (i = 0; i < datosPeli_Ser.Count; i++)
                {
                    if (gap + i < datosPeli_Ser.Count && datosPeli_Ser[i].Año > datosPeli_Ser[gap + i].Año)
                    {
                        var temp = datosPeli_Ser[i];
                        datosPeli_Ser[i] = datosPeli_Ser[gap + i];
                        datosPeli_Ser[gap + i] = temp;
                    }
                }
                gap--;
            }
        }

        private void BtnDescZA_Click(object sender, RoutedEventArgs e)
        {
            bool cambio;
            do
            {
                cambio = false;
                for (int i = 0; i < (datosPeli_Ser.Count - 1); i++)
                {
                    if (string.Compare(datosPeli_Ser[i].Titulo, datosPeli_Ser[i + 1].Titulo) < 0)
                    {
                        var temp = datosPeli_Ser[i];
                        datosPeli_Ser[i] = datosPeli_Ser[i + 1];
                        datosPeli_Ser[i + 1] = temp;
                        cambio = true;
                    }
                }
            } while (cambio == true);
        }

        private void BtnDescAño_Click(object sender, RoutedEventArgs e)
        {
            int gap, i;
            gap = datosPeli_Ser.Count / 2;
            while (gap > 0)
            {
                for (i = 0; i < datosPeli_Ser.Count; i++)
                {
                    if (gap + i < datosPeli_Ser.Count && datosPeli_Ser[i].Año < datosPeli_Ser[gap + i].Año)
                    {
                        var temp = datosPeli_Ser[i];
                        datosPeli_Ser[i] = datosPeli_Ser[gap + i];
                        datosPeli_Ser[gap + i] = temp;
                    }
                }
                gap--;
            }
        }

        private void BtnEliminarNuevo_Click(object sender, RoutedEventArgs e)
        {
            GrdPrincipal.Children.Clear();
            BtnNuevoElemento.Visibility = Visibility.Visible;
            BtnAscAZ.Visibility = Visibility.Visible;
            BtnDescZA.Visibility = Visibility.Visible;
            BtnAscAño.Visibility = Visibility.Visible;
            BtnDescAño.Visibility = Visibility.Visible;
            BtnGuardarNuevo.Visibility = Visibility.Hidden;
            BtnCancelarNuevo.Visibility = Visibility.Hidden;


            if (lstPeliculaSerie.SelectedIndex != -1)
            {
                datosPeli_Ser.RemoveAt(lstPeliculaSerie.SelectedIndex);
            }
        }

        private void BtnGuardarNuevo_Click_1(object sender, RoutedEventArgs e)
        {
            GrdPrincipal.Children.Clear();
            BtnNuevoElemento.Visibility = Visibility.Visible;
            BtnAscAZ.Visibility = Visibility.Visible;
            BtnDescZA.Visibility = Visibility.Visible;
            BtnAscAño.Visibility = Visibility.Visible;
            BtnDescAño.Visibility = Visibility.Visible;
            BtnGuardarNuevo.Visibility = Visibility.Hidden;
            BtnCancelarNuevo.Visibility = Visibility.Hidden;
        }

        private void BtnCancelarNuevo_Click_1(object sender, RoutedEventArgs e)
        {
            GrdPrincipal.Children.Clear();
            BtnNuevoElemento.Visibility = Visibility.Visible;
            BtnAscAZ.Visibility = Visibility.Visible;
            BtnDescZA.Visibility = Visibility.Visible;
            BtnAscAño.Visibility = Visibility.Visible;
            BtnDescAño.Visibility = Visibility.Visible;
            BtnGuardarNuevo.Visibility = Visibility.Hidden;
            BtnCancelarNuevo.Visibility = Visibility.Hidden;

        }
    }
}
