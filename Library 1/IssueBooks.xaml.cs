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
    /// Interaction logic for IssueBooks.xaml
    /// </summary>
    public partial class IssueBooks : Window
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnPresstostart_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand ("select bName from AddNewBook", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    ComboBooksName.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();
        }
        private void DATAGRID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {                  
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                txtEnrollbox2.Text = row_selected["enroll"].ToString();
                txtSName.Text = row_selected["sname"].ToString();               
                txtDep.Text = row_selected["dep"].ToString();
                txtStudentSem.Text = row_selected["sem"].ToString();
                txtStudentMobile.Text = row_selected["contact"].ToString();
                txtStudentMail.Text = row_selected["email"].ToString();

            }
        }

        private void txtEnrollbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent where enroll LIKE '" + txtEnrollbox.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("NewStudent");
            da.Fill(dt);
            DATAGRID.ItemsSource = dt.DefaultView;
        }

        private void btnShowD_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("NewStudent");
            da.Fill(dt);
            DATAGRID.ItemsSource = dt.DefaultView;
        }

        private void btnrefresh_Click(object sender, RoutedEventArgs e)
        {
            
            if (MessageBox.Show("Are You Sure?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {                
                txtEnrollbox.Clear();
                txtEnrollbox2.Clear();
                txtSName.Clear();
                txtDep.Clear();
                txtStudentSem.Clear();
                txtStudentMobile.Clear();
                txtStudentMail.Clear();           
            }                        
        }

        private void btnIssueBook_Click(object sender, RoutedEventArgs e)
        {
            if (txtSName.Text != "")
            {
                if (txtSName.Text != "" && txtDep.Text != "" && txtStudentSem.Text != "" && txtStudentMobile.Text != "" && txtStudentMail.Text != "")
                {
                    String Enrollid = txtEnrollbox2.Text;  
                    String SName = txtSName.Text;                    
                    String Sdep = txtDep.Text;
                    String Ssem = txtStudentSem.Text;
                    Int64 Smobile = Int64.Parse(txtStudentMobile.Text);
                    String Semail = txtStudentMail.Text;
                    String BookN = ComboBooksName.Text;
                    String BookIssueDate = dateTimePicker2.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "insert into IRBook (std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date) values ('" + Enrollid + "','" + SName + "','" + Sdep + "','" + Ssem + "','" + Smobile + "','" + Semail + "','" + BookN + "','" + BookIssueDate + "') ";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book Issued Successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Please Fill Empty Fields", "Suggest", MessageBoxButton.OK, MessageBoxImage.Information);
                }                
            }
        }

        private void btnexit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                this.Close();
            }
        }
    }
}
