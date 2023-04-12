using InfoStudentsWPF;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WorkWithFilesInfo;


namespace InfoStudents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EscClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void GetListStud_Click(object sender, RoutedEventArgs e)
        {
            GetInfoStud infoStud = new GetInfoStud();
            infoStud.Show();
        }
        private void AddDelStud_Click(object sender, RoutedEventArgs e)
        {
            AddDelStudent infoStud = new AddDelStudent();
            infoStud.Show();
        }
        private void EditStud_Click(object sender, RoutedEventArgs e)
        {
            EditStudent infoStud = new EditStudent();
            infoStud.Show();
        }
        private void FilteringBy_Click(object sender, RoutedEventArgs e)
        {
            FilteringByStud infoStud = new FilteringByStud();
            infoStud.Show();
        }
    }
}
