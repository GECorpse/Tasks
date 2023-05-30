using FitnessClubRasima.ClassHelper;
using FitnessClubRasima.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace FitnessClubRasima
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TxtNameUser.Text = "Пользователь " + UserClass.AuthUser.Login + " (" + UserClass.AuthUser.Role.Title + ") ";
        }


        
        private void bClientListWindow_Click(object sender, RoutedEventArgs e)
        {
            ClientListWindow ClientListWindow = new ClientListWindow();
            ClientListWindow.ShowDialog();

            //Window cw = Application.Current.Windows.OfType<Window>().SingleOrDefault(i => i.IsActive);

            //ClientListWindow.Show();

            //cw.Close();
        }

        private void bServiceListWindow_Click(object sender, RoutedEventArgs e)
        {
            ServiceWindow serviceWindow = new ServiceWindow();
            serviceWindow.ShowDialog();
        }

        private void bPurchaseHistoryWindow_Click(object sender, RoutedEventArgs e)
        {
            PurchaseHistoryWindow purchaseHistoryWindow = new PurchaseHistoryWindow();
            purchaseHistoryWindow.ShowDialog();
        }
    }
}
