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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using StudentsDataBase;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;

namespace StudentsBaseHD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static ListBox listBox= null;

        public MainWindow()
        {
            InitializeComponent();
            listBox = MyListBox;
            Reset();
            
            Closing += (object sender, CancelEventArgs e) => Glue.Save();
        }

        public static void Reset()
        {
            
            var temp = Glue.GetData();
            listBox.Items.Clear();
            foreach(var item in temp)
            {
                listBox.Items.Add(item);
            }
        }
        public static void GetData(List<string>lol)
        {
            listBox.Items.Clear();
            foreach (var item in lol)
            {
                listBox.Items.Add(item);
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddStudWindow addStud = new AddStudWindow();
            addStud.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DeleteStudWindow deleteStud = new DeleteStudWindow();
            deleteStud.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ChangeFacultyWindow changeFaculty = new ChangeFacultyWindow();
            changeFaculty.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            StudentSearchWindow SearchStud = new StudentSearchWindow();
            SearchStud.ShowDialog();
        }
    }
}
