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
using StudentsDataBase;

namespace StudentsBaseHD
{
    /// <summary>
    /// Логика взаимодействия для StudentSearchWindow.xaml
    /// </summary>
    public partial class StudentSearchWindow : Window
    {
        public StudentSearchWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SomeText1.Visibility = Visibility.Hidden;
            SomeText2.Visibility = Visibility.Visible;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            SomeText2.Visibility = Visibility.Hidden;
            SomeText1.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (YearRB.IsChecked.Value)
                {
                    MainWindow.GetData(Glue.SearchStudent(int.Parse(FirstArgTB.Text), SecondArgTB.Text));
                }
                else
                {
                    MainWindow.GetData(Glue.SearchStudent(FirstArgTB.Text, SecondArgTB.Text));
                }
            }
            catch (Exception a)
            {
                Error.GetError(a);
            }
            
            Close();
        }
    }
}
