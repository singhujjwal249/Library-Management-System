using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library_1
{
    /// <summary>
    /// Interaction logic for Loginpagel
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SINEmail_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (SINEmail.Text == "Email")
            {
                SINEmail.Clear();
            }

        }

        private void SINPassword_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (SINPassword.PasswordChar == '*')
            {
                SINPassword.Clear();
            }
        }

        private void CAusername_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (CAusername.Text == "Name")
            {
                CAusername.Clear();
            }
        }

        private void CAEmail_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (CAEmail.Text == "Email")
            {
                CAEmail.Clear();
            }
        }

        private void CApassword_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (CApassword.PasswordChar == '*')
            {
                CApassword.Clear();
            }
        }
        private void SINFacebook_Click(object sender, RoutedEventArgs e)
        {
           System.Diagnostics.Process.Start("https://www.facebook.com/");
            
        }

        private void SINInstagram_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void SINTwitter_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/");
        }

        private void CAFacebook_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void CAInstagram_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void CATwitter_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/");
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void close1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        string connectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security=True"; 
        private void CAEnter_Click(object sender, RoutedEventArgs e)
        {
            if (CAusername.Text == "" || CAEmail.Text== "" || CApassword.Password == "")
                MessageBox.Show("Enter Valid Name, Email and Passwrod","Alert!!", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserEnter", sqlCon);
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Name", CAusername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", CAEmail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Pass", CApassword.Password.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Sign Up SUCCESSFULL!!", "Congratulations", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    Clear();
                }
            }
        }

        void Clear()
        {
            CAusername.Text = CAEmail.Text = CApassword.Password = "";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-TTPD3D8; database = Library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from UserLoginandSignup where Email ='" + SINEmail.Text + "' and Pass ='" + SINPassword.Password + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds);
            if (SINEmail.Text == "" || SINPassword.Password == "")
            {
                MessageBox.Show("Enter valid Email and Passowrd", "Alert!!", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            else if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dsa = new Dashboard();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Wrong Email OR Password!! Please Enter correct Email and Password ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        }
    }