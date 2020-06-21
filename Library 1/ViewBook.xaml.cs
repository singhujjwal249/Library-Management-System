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
    /// Interaction logic for ViewBook.xaml
    /// </summary>
    public partial class ViewBook : Window
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Show_books_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from AddNewBook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("AddNewBook");
            da.Fill(dt);
            DataGridView1.ItemsSource = dt.DefaultView;                       
        }
     
        private void DataGridView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                txtbId.Text = row_selected["bid"].ToString();
                txtBookName.Text = row_selected["bName"].ToString();
                txtAuthor.Text = row_selected["bAuthor"].ToString();
                txtPublication.Text = row_selected["bpub1"].ToString();
                dateTimePicker1.Text = row_selected["bPDate"].ToString();
                txtPrice.Text = row_selected["bPrice"].ToString();
                txtQuantity.Text = row_selected["bQuan"].ToString();                
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                txtbId.Clear();
                txtBookName.Clear();
                txtAuthor.Clear();
                txtPublication.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
            }
        }

        private void txtBookName1_TextChanged(object sender, TextChangedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from AddNewBook where bName LIKE '"+txtBookName1.Text+ "%'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("AddNewBook");
            da.Fill(dt);
            DataGridView1.ItemsSource = dt.DefaultView;
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtBookName1.Clear();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Data Will be Updated. Confirm?", "Success", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                String biD = txtbId.Text;
                String bname = txtBookName.Text;
                String bauthor = txtAuthor.Text;
                String publication = txtPublication.Text;
                String pdate = dateTimePicker1.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                Int64 quan = Int64.Parse(txtQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update AddNewBook set bName = '" + bname + "' ,bAuthor = '" + bauthor + "',bPub1 = '" + publication + "',bPDate = '" + pdate + "',bPrice = " + price + ",bQuan = " + quan + " where bid =" + biD + " ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Data Will be Deleted. Confirm?", "Confirmation Dialog", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
            {
                String biD = txtbId.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete AddNewBook where bid =" + biD + " ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

    }
}
