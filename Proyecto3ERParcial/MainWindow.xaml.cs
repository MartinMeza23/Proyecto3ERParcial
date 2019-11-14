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

namespace Proyecto3ERParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbPeliseries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdagregar.Children.Clear();
        }

        private void Btnaceptar_Click(object sender, RoutedEventArgs e)
        {
            switch (cbPeliseries.SelectedIndex)
            {
                case 0:
                    grdagregar.Children.Add(new Series());
                    break;
                case 1:
                    grdagregar.Children.Add(new Peliculas());
                    break;
                default:
                    break;
            }
        }

        private void ListTitAño_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
