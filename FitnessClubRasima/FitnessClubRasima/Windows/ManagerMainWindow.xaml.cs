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
using FitnessClubRasima.DB;
using FitnessClubRasima.ClassHelper;

namespace FitnessClubRasima.Windows
{
    /// <summary>
    /// Логика взаимодействия для ManagerMainWindow.xaml
    /// </summary>
    public partial class ManagerMainWindow : Window
    {
        public ManagerMainWindow()
        {
            InitializeComponent();
            TxtNameUser.Text = "Пользователь " + UserClass.AuthUser.Login + " (" + UserClass.AuthUser.Role.Title + ") ";
        }

        private void bManagementListWindow_Click(object sender, RoutedEventArgs e)
        {
            ManagementListWindow managementListWindow = new ManagementListWindow();
            managementListWindow.Show();
        }

        private void bReportListWindow_Click(object sender, RoutedEventArgs e)
        {
            ReportListWindow reportListWindow = new ReportListWindow();
            reportListWindow.Show();
        }
    }
}
