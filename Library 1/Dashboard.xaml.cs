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

namespace Library_1
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           if(MessageBox.Show("Are You Sure You want to EXIT?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void Add_Books_Click(object sender, RoutedEventArgs e)
        {
            AddBooks abs = new AddBooks();
            abs.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AddStudent ast = new AddStudent();
            ast.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ViewStudentInformation vsi = new ViewStudentInformation();
            vsi.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            IssueBooks ib = new IssueBooks();
            ib.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            CompleteBookDetails cbd = new CompleteBookDetails();
            cbd.Show();
        }
               
        }

    }
