﻿using StudentInfo;
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
using WorkWithFilesInfo;

namespace InfoStudentsWPF
{
    /// <summary>
    /// Логика взаимодействия для FilteringByStud.xaml
    /// </summary>
    public partial class FilteringByStud : Window
    {
        List<Student> listStudents = new List<Student>();
        public FilteringByStud()
        {
            InitializeComponent();

            listStudents = WorkWithFilesAndSerialization.ReadFromFile();
            userList.ItemsSource = listStudents;
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            string filter = textBoxFiltr.Text;

            if (textBoxFiltr.Text == "")
            {
                userList.ItemsSource = listStudents;
                return;
            }

            List<Student> listFilteringBy = new List<Student>();

            listFilteringBy.AddRange(listStudents.Where(student => student.FIO.Contains(filter!, StringComparison.OrdinalIgnoreCase)
            || student.Curriculum.Faculty.Contains(filter!, StringComparison.OrdinalIgnoreCase) || student.Curriculum.Speciality.Contains(filter!, StringComparison.OrdinalIgnoreCase)
            || student.Curriculum.Cource.Contains(filter!, StringComparison.OrdinalIgnoreCase) || student.Curriculum.Group.Contains(filter!, StringComparison.OrdinalIgnoreCase)
            || student.Address.City.Contains(filter!, StringComparison.OrdinalIgnoreCase) || student.Address.PostIndex.Contains(filter!, StringComparison.OrdinalIgnoreCase)
            || student.Address.Street.Contains(filter!, StringComparison.OrdinalIgnoreCase) || student.Contact.Phone.Contains(filter!, StringComparison.OrdinalIgnoreCase)
            || student.Contact.Email.Contains(filter!, StringComparison.OrdinalIgnoreCase))!);

            userList.ItemsSource = listFilteringBy;
        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBoxFiltr.Text == "Фильтровать по любому полю ...")
                textBoxFiltr.Text = "";

            textBoxFiltr.Foreground = Brushes.Black;
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBoxFiltr.Text == "")
                textBoxFiltr.Text = "Фильтровать по любому полю ...";

            textBoxFiltr.Foreground = Brushes.DarkGray;
        }
    }
}
