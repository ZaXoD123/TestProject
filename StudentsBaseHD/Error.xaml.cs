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

namespace StudentsBaseHD
{
    /// <summary>
    /// Логика взаимодействия для Error.xaml
    /// </summary>
    public partial class Error : Window
    {
        Error()
        {
            InitializeComponent();
        }
        public static void GetError(Exception exception)
        {
            var a = new Error();
            a.ErrTB.Content = exception.Message;
            a.ShowDialog();
        }
    }
}
