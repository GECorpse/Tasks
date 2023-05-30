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
using FitnessClubRasima.Windows;

namespace FitnessClubRasima.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            // авторизация
            // 1. получить всех пользователей!
            // 2. выбрать пользователей по условию 
            // 3. из итогового списка выбрать одну запись 
            //

            var authUser = EFClass.context.User.ToList()
                .Where(i => i.Login == TbLogin.Text && i.Password == PbPassword.Password)
                .FirstOrDefault();

            //if (authUser != null)
            //{
            //    // сохраняем пользователя
            //    UserClass.AuthUser = authUser;

            //    // переход на нужное окно
            //    MainWindow mainWindow = new MainWindow();
            //    mainWindow.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Пользователь не найден");
            //}

            //switch (authUser.IdRole)
            //{
            //    case 1:

            //        ManagerMainWindow managerMainWindow = new ManagerMainWindow();
            //        managerMainWindow.Show();
            //        break;
            //    case 2:
            //        MainWindow mainWindow = new MainWindow();
            //        mainWindow.Show();
            //        break;
            //    case 3:
            //        TrainerMainWindow trainerMainWindow = new TrainerMainWindow();
            //        trainerMainWindow.Show();
            //        break;
            //    default:
            //        MessageBox.Show("Пользователь не найден");
            //        break;

            //}

            if (authUser != null)
            {
                UserClass.AuthUser = authUser;

                switch (authUser.IdRole)
                {
                    case 1:

                        ManagerMainWindow managerMainWindow = new ManagerMainWindow();
                        managerMainWindow.Show();
                        break;
                    case 2:
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        break;
                    case 3:
                        TrainerMainWindow trainerMainWindow = new TrainerMainWindow();
                        trainerMainWindow.Show();
                        break;
                    default:
                        MessageBox.Show("Пользователь не найден");
                        break;

                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }

        private void bToReg_Click(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new RegWindow();
            regWindow.ShowDialog();
        }
    }
}
