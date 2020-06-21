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
    /// Interaction logic for ViewStudentInformation.xaml
    /// </summary>
    public partial class ViewStudentInformation : Window
    {
        public ViewStudentInformation()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtEnrollmentNo1_TextChanged(object sender, TextChangedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent where enroll LIKE '" + txtEnrollmentNo1.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("NewStudent");
            da.Fill(dt);
            DataGridView1.ItemsSource = dt.DefaultView;
        }

        private void Show_Students_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("NewStudent");
            da.Fill(dt);
            DataGridView1.ItemsSource = dt.DefaultView;
        }

        private void DataGridView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                txtStuid.Text = row_selected["stuid"].ToString();
                txtStudentName.Text = row_selected["sname"].ToString();
                txtEnrollmentNo.Text = row_selected["enroll"].ToString();
                txtDepartment.Text = row_selected["dep"].ToString();
                txtStudentSemester.Text = row_selected["sem"].ToString();
                txtStudentContact.Text = row_selected["contact"].ToString();
                txtStudentEmail.Text = row_selected["email"].ToString();
                
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                txtStuid.Clear();
                txtStudentName.Clear();
                txtEnrollmentNo.Clear();
                txtDepartment.Clear();
                txtStudentSemester.Clear();
                txtStudentContact.Clear();
                txtStudentEmail.Clear();

            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtEnrollmentNo1.Clear();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Data Will be Updated. Confirm?", "Success", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                String Sid = txtStuid.Text;
                String Stuname = txtStudentName.Text;
                String enrollment = txtEnrollmentNo.Text;
                String Department = txtDepartment.Text;
                String Sem = txtStudentSemester.Text;
                Int64 contac = Int64.Parse(txtStudentContact.Text);
                String mail = txtStudentEmail.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewStudent set sname = '" + Stuname + "' ,enroll = '" + enrollment + "',dep = '" + Department + "',sem = '" + Sem + "',  contact = " + contac + ",email = '" + mail + "' where stuid =" + Sid + " ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Data Will be Deleted. Confirm?", "Confirmation Dialog", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
            {
                String Sid = txtStuid.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete NewStudent where stuid =" + Sid + " ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

    }
}
