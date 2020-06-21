using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

namespace Library_1
{
    /// <summary>
    /// Interaction logic for CompleteBookDetails.xaml
    /// </summary>
    public partial class CompleteBookDetails : Window
    {
        public CompleteBookDetails()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnIssuedbook_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from IRBook where book_return_date is null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("IRBook");
            da.Fill(dt);
            DataGridissuebook.ItemsSource = dt.DefaultView;
        }

        private void btnReturned_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from IRBook where book_return_date is not null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("IRBook");
            da.Fill(dt);
            DataGridreturnedbook.ItemsSource = dt.DefaultView;
        }
    }
}
