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
using System.Data.SqlClient;

namespace Library_1
{
    /// <summary>
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtStudentName.Clear();
            txtEnrollment_No.Clear();
            txtDepartment.Clear();
            txtStudentSemester.Clear();
            txtStudentContact.Clear();
            txtStudentEmail.Clear();
        }

        private void btnSaveInfo_Click(object sender, RoutedEventArgs e)
        {
            if (txtStudentName.Text != "" && txtEnrollment_No.Text != "" && txtDepartment.Text != "" && txtStudentSemester.Text != "" && txtStudentContact.Text != "" && txtStudentEmail.Text != "")
            {
                String name = txtStudentName.Text;
                String enroll = txtEnrollment_No.Text;
                String dep = txtDepartment.Text;
                String sem = txtStudentSemester.Text;
                Int64 mobile = Int64.Parse(txtStudentContact.Text);
                String email = txtStudentEmail.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into NewStudent (sname,enroll,dep,sem,contact,email) values ('" + name + "','" + enroll + "','" + dep + "','" + sem + "','" + mobile + "','" + email + "') ";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please Fill Empty Fields", "Suggest", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
