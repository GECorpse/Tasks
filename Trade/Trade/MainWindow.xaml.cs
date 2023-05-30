using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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

namespace Trade
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public login()
        {
            InitializeComponent();
            OpenPage(pages.login);
        }

        public enum pages
        {
            login,
            regin
        }

        void OpenPage(pages pages)
        {
            if (pages == pages.login)
            {
                frame.Navigate(new login(this));
            }
            else if (pages == pages.regin)
                frame.Navigate(new regin(this));
        }

        public DataTable Select(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("server=DESKTOP - 26420GT;Trusted_Connection=Yes; DataBase=Trade;");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

    }
}
