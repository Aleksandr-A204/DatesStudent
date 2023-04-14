using InfoStudents;
using StudentData;
using System;
using System.Windows;


namespace InfoStudentsWPF
{
    /// <summary>
    /// Логика взаимодействия для AppStudent.xaml
    /// </summary>
    public partial class AppStudent : Window
    {
        public AppStudent()
        {
            InitializeComponent();
        }

        private void Button_ClickEsc(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_ClickWPF(object sender, RoutedEventArgs e)
        {
            DatesStudent datesStudent = new DatesStudent();
            datesStudent.Show();
            Close();
        }
        private void Button_ClickConsol(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
