using StudentInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WorkWithFilesInfo;

namespace InfoStudentsWPF
{
    /// <summary>
    /// Логика взаимодействия для EditStutend.xaml
    /// </summary>
    public partial class EditStudent : Window
    {
        List<Student> listStudents = new List<Student>();
        public EditStudent()
        {
            InitializeComponent();

            listStudents = WorkWithFilesAndSerialization.ReadFromFile();
            listView_DataStuds.ItemsSource = listStudents;
        }
        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_ClickEdit(object sender, RoutedEventArgs e) 
        {
            Student? selectedStudent = listView_DataStuds.SelectedItem as Student;
            if (selectedStudent is null) 
                return;

            EditAddStud getEditStudent = new EditAddStud(selectedStudent);

            if (getEditStudent.ShowDialog() == true)
            {
                listStudents.Insert(listStudents.IndexOf(selectedStudent), getEditStudent.NewStudent);
                listStudents.Remove(selectedStudent);
                WorkWithFilesAndSerialization.WriteToFile(listStudents);

                listStudents = WorkWithFilesAndSerialization.ReadFromFile();
                listView_DataStuds.ItemsSource = listStudents;
            }
        }
    }
}
