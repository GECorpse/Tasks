using FitnessClubRasima.ClassHelper;
using FitnessClubRasima.DB;
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

namespace FitnessClubRasima.Windows
{
    /// <summary>
    /// Логика взаимодействия для ManagementListWindow.xaml
    /// </summary>
    public partial class ManagementListWindow : Window
    {
        List<string> listSort = new List<string>()
        {
            "По умолчанию",
            "По имени (от А до Я)",
            "По имени (от Я до А)",
            "По фамилия (от А до Я)",
            "По фамилия (от Я до А)",
            "По отчество (от А до Я)",
            "По отчество (от Я до А)",
        };

        public ManagementListWindow()
        {
            InitializeComponent();

            CmbSort.ItemsSource = listSort;
            CmbSort.SelectedIndex = 0;

            GetUserList();
        }

        private void GetUserList()
        {
            List<User> userList = new List<User>();

            userList = EFClass.context.User.ToList();

            //поиск, фильтрация и сортировка

            //поиск
            //Имя
            userList = userList.Where(i => i.Login.ToLower().Contains(TbSearch.Text.ToLower())).ToList();

            //сортировка
            var selectedIndexCmb = CmbSort.SelectedIndex;

            switch (selectedIndexCmb)
            {
                case 0:
                    userList = userList.OrderBy(i => i.ID).ToList();
                    break;
                case 1:
                    userList = userList.OrderBy(i => i.ID).ToList();
                    break;
                case 2:
                    userList = userList.OrderByDescending(i => i.Login).ToList();
                    break;

                default:
                    userList = userList.OrderBy(i => i.ID).ToList();
                    break;

            }

            //фильтрация

            lvUser.ItemsSource = userList;
        }

        private void BtnAddUser_Click(object sender, RoutedEventArgs e)
        {
            AddEditServiceWindow addEditServiceWindow = new AddEditServiceWindow();
            addEditServiceWindow.ShowDialog();

            GetUserList();
        }

        private void BtnEditUser_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }

            var service = button.DataContext as Service;


            AddEditServiceWindow addEditServiceWindow = new AddEditServiceWindow(service);
            addEditServiceWindow.ShowDialog();

            GetUserList();
        }

        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            GetUserList();
        }

        private void CmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GetUserList();
        }

        private void lvUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
