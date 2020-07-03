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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelloWPF
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
        private Employee emp;
      public MainWindow()
      {
         InitializeComponent();
            emp = new Employee()
            {
                Name = "Assam Toumi",
                Title = "Developper"
            };
            DataContext = emp;
      }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            emp.Name = "J1";
            emp.Title = "Teacher";
        }
    }
}
