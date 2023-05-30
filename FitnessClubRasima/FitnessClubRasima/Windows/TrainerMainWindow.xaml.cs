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
using FitnessClubRasima.ClassHelper;

namespace FitnessClubRasima.Windows
{
    /// <summary>
    /// Логика взаимодействия для TrainerMainWindow.xaml
    /// </summary>
    public partial class TrainerMainWindow : Window
    {
        public TrainerMainWindow()
        {
            InitializeComponent();
            TxtNameUser.Text = "Пользователь " + UserClass.AuthUser.Login + " (" + UserClass.AuthUser.Role.Title + ") ";
        }

        private void bScheduleWindow_Click(object sender, RoutedEventArgs e)
        {
            ScheduleWindow scheduleWindow = new ScheduleWindow();
            scheduleWindow.Show();
        }

        //private void bProfileWindow_Click(object sender, RoutedEventArgs e)
        //{
        //    ProfileWindow profileWindow = new ProfileWindow();
        //    profileWindow.Show();
        //}
    }
}
