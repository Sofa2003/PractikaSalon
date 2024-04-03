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
    /// Логика взаимодействия для Dobavlenie.xaml
    /// </summary>
    public partial class Dobavlenie : Page
    {
        public Dobavlenie()
        {
            InitializeComponent();
        }

        private void btnochist_Click(object sender, RoutedEventArgs e)
        {
            textboximi.Text = "";
            textboxfamilia.Text = "";
            textboxotchestvo.Text = "";
            textboxtelefon.Text = "";
            textboxemail.Text = "";
        }
    }
}
