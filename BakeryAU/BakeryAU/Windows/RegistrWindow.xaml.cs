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

using static BakeryAU.HelperClass.EFClass;

using BakeryAU.Windows;
using BakeryAU.DB;

namespace BakeryAU.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrWindow.xaml
    /// </summary>
    public partial class RegistrWindow : Window
    {
        public RegistrWindow()
        {
            
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxLogin.Text))
            {
                MessageBox.Show("Введите логин или пароль");
            }

            Context.User.Add(new User()
            {
                Login = tbxLogin.Text,
                Password = tbxPass.Password,
                Email = tbxEmail.Text,
            });

            Context.SaveChanges();

            MessageBox.Show("Успешная регистрация!");

        }
    }
}
