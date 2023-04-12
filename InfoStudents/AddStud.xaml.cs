using StudentInfo;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WorkWithFilesInfo;

namespace InfoStudentsWPF
{
    public partial class AddStud : Window
    {
        public Student NewStudent { get; private set; }

        public AddStud(Student newStudent)
        {
            InitializeComponent();

            NewStudent = newStudent;
        }

        private void Button_ClickCancel(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //void Button_ClickSave(object sender, RoutedEventArgs e)
        //{
        //    DialogResult = true;
        //}


        int numClick = 0;

        private void Button_ClickSave(object sender, RoutedEventArgs e)
        {
            string fio = fioTextBox.Text.Trim();
            string faculty = facultyTextBox.Text.Trim();
            string speciality = specialityTextBox.Text.Trim();
            string cource = courceTextBox.Text.Trim();
            string group = groupTextBox.Text.Trim();
            string city = cityTextBox.Text.Trim();
            string postCode = postcodeTextBox.Text.Trim();
            string street = streetTextBox.Text.Trim();
            string phone = phoneTextBox.Text.Trim();
            string eMail = emailTextBox.Text.Trim();

            List<TextBox> listTextBox = new List<TextBox> { fioTextBox, facultyTextBox, specialityTextBox, courceTextBox, groupTextBox, cityTextBox, postcodeTextBox, streetTextBox, phoneTextBox, emailTextBox };

            if (fio == "")
            {
                fioTextBox.ToolTip = "Это поле введено не корректно!";
                fioTextBox.Background = Brushes.DarkRed;
            }
            else if (faculty == "")
            {
                ClearBackgroundAndToolTip(listTextBox);

                facultyTextBox.ToolTip = "Это поле введено не корректно!";
                facultyTextBox.Background = Brushes.DarkRed;
            }
            else if (speciality == "")
            {
                ClearBackgroundAndToolTip(listTextBox);

                specialityTextBox.ToolTip = "Это поле введено не корректно!";
                specialityTextBox.Background = Brushes.DarkRed;
            }
            else if (cource == "")
            {
                ClearBackgroundAndToolTip(listTextBox);

                courceTextBox.ToolTip = "Это поле введено не корректно!";
                courceTextBox.Background = Brushes.DarkRed;
            }
            else if (group == "")
            {
                ClearBackgroundAndToolTip(listTextBox);

                groupTextBox.ToolTip = "Это поле введено не корректно!";
                groupTextBox.Background = Brushes.DarkRed;
            }
            else if (city == "")
            {
                ClearBackgroundAndToolTip(listTextBox);

                cityTextBox.ToolTip = "Это поле введено не корректно!";
                cityTextBox.Background = Brushes.DarkRed;
            }
            else if (postCode == "")
            {
                ClearBackgroundAndToolTip(listTextBox);

                postcodeTextBox.ToolTip = "Это поле введено не корректно!";
                postcodeTextBox.Background = Brushes.DarkRed;
            }
            else if (street == "")
            {
                ClearBackgroundAndToolTip(listTextBox);

                streetTextBox.ToolTip = "Это поле введено не корректно!";
                streetTextBox.Background = Brushes.DarkRed;
            }
            else if (phone == "")
            {
                ClearBackgroundAndToolTip(listTextBox);

                phoneTextBox.ToolTip = "Это поле введено не корректно!";
                phoneTextBox.Background = Brushes.DarkRed;
            }
            else if (eMail == "" || !eMail.Contains('@') || !eMail.Contains('.'))
            {
                ClearBackgroundAndToolTip(listTextBox);

                emailTextBox.ToolTip = "Это поле введено не корректно!";
                emailTextBox.Background = Brushes.DarkRed;
            }
            else
            {
                ClearBackgroundAndToolTip(listTextBox);

                NewStudent = new Student(fio, new Curriculum(faculty, speciality, cource, group), new Address(city, postCode, street), new Contact(phone, eMail));

                DialogResult = true;

                Close();
                return;
            }

            numClick++;
            if (numClick > 3)
                MessageBox.Show("Хватить тупить! Введите поля корректно!");
        }

        private static void ClearBackgroundAndToolTip(List<TextBox> brush)
        {
            for (int i = 0; i < brush.Count; i++)
            {
                brush[i].ToolTip = "";
                brush[i].Background= Brushes.White;
            }
        }
    }
}
