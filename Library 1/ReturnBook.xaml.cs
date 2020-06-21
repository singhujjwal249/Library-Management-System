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
    /// Interaction logic for ReturnBook.xaml
    /// </summary>
    public partial class ReturnBook : Window
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DATAGRID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                txtEnrollbox3.Text = row_selected["std_enroll"].ToString();
                txtBookName.Text = row_selected["book_name"].ToString();
                txtBookIssueDate.Text = row_selected["book_issue_date"].ToString();
            }
        }

        private void btnShowD_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from IRBook where std_enroll = '" + txtEnrollbox3.Text + "' and book_return_date IS NULL ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("IRBook");
            da.Fill(dt);
            DATAGRID.ItemsSource = dt.DefaultView;
        }

        private void txtEnrollbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from IRBook where std_enroll LIKE '" + txtEnrollbox1.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("IRBook");
            da.Fill(dt);
            DATAGRID.ItemsSource = dt.DefaultView;
        }

        private void btnrefresh_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                txtEnrollbox1.Clear();
                txtEnrollbox3.Clear();
                txtBookName.Clear();
                txtBookIssueDate.Clear();
                
            }
        }

        private void btnexit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                this.Close();
            }
        }

        private void btnreturn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Return on Specified Date. Confirm?", "Success", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                String BName = txtBookName.Text;
                String bname = txtBookIssueDate.Text;
                String DTP = dateTimePicker3.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update IRBook set book_return_date = '" + dateTimePicker3 + "' where std_enroll = '"+txtEnrollbox3.Text+"'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Please Return on Specified Date!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }
    }
}
