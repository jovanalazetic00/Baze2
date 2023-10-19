using BAZE2_PR111_2019.Models;
using Microsoft.EntityFrameworkCore;
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

namespace BAZE2_PR111_2019
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SkijaskaStazaContext skijaskaStaza1Context = new SkijaskaStazaContext();
        private CollectionViewSource sudija3ViewSource;
        private CollectionViewSource licenca1ViewSource;
        private CollectionViewSource zaTakmicare1ViewSource;
        private CollectionViewSource zaStazu1ViewSource;
        private CollectionViewSource proizvodjacOpreme1ViewSource;
        private CollectionViewSource drzava1ViewSource;
        private CollectionViewSource skijas1ViewSource;
        private CollectionViewSource trka1ViewSource;
        private CollectionViewSource ucestvuje1ViewSource;
        private CollectionViewSource oprema1ViewSource;
        private CollectionViewSource staza1ViewSource;
        public MainWindow()
        {
            InitializeComponent();
            sudija3ViewSource = (CollectionViewSource)FindResource(nameof(sudija3ViewSource));
            licenca1ViewSource = (CollectionViewSource)FindResource(nameof(licenca1ViewSource));
            zaTakmicare1ViewSource = (CollectionViewSource)FindResource(nameof(zaTakmicare1ViewSource));
            zaStazu1ViewSource = (CollectionViewSource)FindResource(nameof(zaStazu1ViewSource));
            proizvodjacOpreme1ViewSource = (CollectionViewSource)FindResource(nameof(proizvodjacOpreme1ViewSource));
            drzava1ViewSource = (CollectionViewSource)FindResource(nameof(drzava1ViewSource));
            skijas1ViewSource = (CollectionViewSource)FindResource(nameof(skijas1ViewSource));
            trka1ViewSource = (CollectionViewSource)FindResource(nameof(trka1ViewSource));
            ucestvuje1ViewSource = (CollectionViewSource)FindResource(nameof(ucestvuje1ViewSource));
            oprema1ViewSource = (CollectionViewSource)FindResource(nameof(oprema1ViewSource));
            staza1ViewSource = (CollectionViewSource)FindResource(nameof(staza1ViewSource));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            skijaskaStaza1Context.Sudija3s.Load();
            skijaskaStaza1Context.Licenca1s.Load();
            skijaskaStaza1Context.ProizvodjacOpreme1s.Load();
            skijaskaStaza1Context.ZaTakmicare1s.Load();
            skijaskaStaza1Context.ZaStazu1s.Load();
            skijaskaStaza1Context.Drzava1s.Load();
            skijaskaStaza1Context.Skijas1s.Load();
            skijaskaStaza1Context.Trka1s.Load();
            skijaskaStaza1Context.Ucestvuje1s.Load();
            skijaskaStaza1Context.Oprema1s.Load();
            skijaskaStaza1Context.Staza1s.Load();


            sudija3ViewSource.Source = skijaskaStaza1Context.Sudija3s.Local.ToObservableCollection();
            licenca1ViewSource.Source = skijaskaStaza1Context.Licenca1s.Local.ToObservableCollection();
            zaTakmicare1ViewSource.Source = skijaskaStaza1Context.ZaTakmicare1s.Local.ToObservableCollection();
            zaStazu1ViewSource.Source = skijaskaStaza1Context.ZaStazu1s.Local.ToObservableCollection();
            proizvodjacOpreme1ViewSource.Source = skijaskaStaza1Context.ProizvodjacOpreme1s.Local.ToObservableCollection();
            drzava1ViewSource.Source = skijaskaStaza1Context.Drzava1s.Local.ToObservableCollection();
            skijas1ViewSource.Source = skijaskaStaza1Context.Skijas1s.Local.ToObservableCollection();
            trka1ViewSource.Source = skijaskaStaza1Context.Trka1s.Local.ToObservableCollection();
            ucestvuje1ViewSource.Source = skijaskaStaza1Context.Ucestvuje1s.Local.ToObservableCollection();
            oprema1ViewSource.Source = skijaskaStaza1Context.Oprema1s.Local.ToObservableCollection();
            staza1ViewSource.Source = skijaskaStaza1Context.Staza1s.Local.ToObservableCollection();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            skijaskaStaza1Context.Dispose();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = skijaskaStaza1Context.SaveChanges();

            Sudija3DataGrid.Items.Refresh();
            Licenca1DataGrid.Items.Refresh();
            ZaTakmicare1DataGrid.Items.Refresh();
            ZaStazu1DataGrid.Items.Refresh();
            ProizvodjacOpreme1DataGrid.Items.Refresh();
            Drzava1DataGrid.Items.Refresh();
            Skijas1DataGrid.Items.Refresh();
            Trka1DataGrid.Items.Refresh();
            Ucestvuje1DataGrid.Items.Refresh();
            Oprema1DataGrid.Items.Refresh();
            Staza1DataGrid.Items.Refresh();



            MessageBox.Show("Broj izvršenih zapisa: " + n, "Sacuvaj promjene");
        }
    }
}
