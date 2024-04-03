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

namespace PractikaSalon.Pages
{
    /// <summary>
    /// Логика взаимодействия для Klient.xaml
    /// </summary>
    public partial class Klient : Page
    {
        
        public Klient()
        {
            InitializeComponent();
            
        }

      
       

        private void btaddzakaz_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Zakaz());
        }

        private void btaddklient_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Dobavlenie());
        }

        private void btaddsotrudnik_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Sotrudnik()); 
        }
    }
    
}
