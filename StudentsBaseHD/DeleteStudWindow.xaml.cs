﻿using System;
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
    /// Логика взаимодействия для DeleteStudWindow.xaml
    /// </summary>
    public partial class DeleteStudWindow : Window
    {
        public DeleteStudWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Glue.DeleteStud(int.Parse(DelTargetTB.Text));
            }
            catch (Exception a)
            {
                Error.GetError(a);
            }
            MainWindow.Reset();
            Close();
        }
    }
}
