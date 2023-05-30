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
using FitnessClubRasima.Windows;
using FitnessClubRasima.ClassHelper;
using System.IO;
using Microsoft.Win32;

namespace FitnessClubRasima.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddEditUserWindow.xaml
    /// </summary>
    public partial class AddEditUserWindow : Window
    {
        private bool isEdit = false;
        private User editUser;

        public AddEditUserWindow()
        {
            InitializeComponent();

            isEdit = false;
        }

        public AddEditUserWindow(User user)
        {
            // конструктор для редактирования

            InitializeComponent();


            // Изменения заголовка и текста кнопки
            TblockTitle.Text = "Редактирование услуги";
            BtnAddEditUser.Content = "Сохранить изменения";

            // Заполнение текстовых полей 

            TbLoginUser.Text = user.Login.ToString();
            TbEmailUser.Text = user.Email.ToString();
            TbPasswordUser.Text = user.Password.ToString();
            TbRoleUser.Text = user.Role.ToString();


            isEdit = true;
            editUser = user;

        }

        private void BtnAddEditUser_Click(object sender, RoutedEventArgs e)
        {
            // валидация
            if (isEdit == true)
            {
                //// изменение
                
                editUser.Login = TbLoginUser.Text;
                editUser.Email = TbEmailUser.Text;
                editUser.Password = TbPasswordUser.Text;

                EFClass.context.SaveChanges();
                MessageBox.Show("Информация о сотруднике успешно изменена");

            }
            else
            {
                //// добавление
                User user = new User();
                user.Login = TbLoginUser.Text;
                user.Email = TbEmailUser.Text;
                user.Password = TbPasswordUser.Text;


                EFClass.context.User.Add(user);
                EFClass.context.SaveChanges();
                MessageBox.Show("Услуга успешно добавлена");
            }

            this.Close();
        }
    }
}
