using StudentInfo;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace InfoStudentsWPF
{
    public partial class EditAddStud : Window
    {
        public Student NewStudent { get; private set; }

        public EditAddStud(Student newStudent)
        {
            InitializeComponent();

            if (newStudent.FIO == "" && newStudent.Curriculum.Faculty == "" && newStudent.Curriculum.Speciality == "" && newStudent.Curriculum.Cource == "" && newStudent.Curriculum.Group == ""
    && newStudent.Address.City == "" && newStudent.Address.PostIndex == "" && newStudent.Address.Street == "" && newStudent.Contact.Phone == "" && newStudent.Contact.Email == "")
            {
                Title = "Добавление студента";
            }
            else
            {
                Title = "Изменение студента";

                fioTextBox.Text = newStudent.FIO;
                facultyTextBox.Text = newStudent.Curriculum.Faculty;
                specialityTextBox.Text = newStudent.Curriculum.Speciality;
                courceTextBox.Text = newStudent.Curriculum.Cource;
                groupTextBox.Text = newStudent.Curriculum.Group;
                cityTextBox.Text = newStudent.Address.City;
                postcodeTextBox.Text = newStudent.Address.PostIndex;
                streetTextBox.Text = newStudent.Address.Street;
                phoneTextBox.Text = newStudent.Contact.Phone;
                emailTextBox.Text = newStudent.Contact.Email;

                fioTextBlock.Text = "ФИО";
                facultyTextBlock.Text = "Факультет";
                specialityTextBlock.Text = "Специальность";
                courceTextBlock.Text = "Курс";
                groupTextBlock.Text = "Группа";
                cityTextBlock.Text = "Город";
                postcodeTextBlock.Text = "Почтовый индекс";
                streetTextBlock.Text = "Улица";
                phoneTextBlock.Text = "Номер телефона";
                emailTextBlock.Text = "Эл. почта";
            }

            NewStudent = newStudent;
        }

        private void Button_ClickCancel(object sender, RoutedEventArgs e)
        {
            Close();
        }

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

            bool fioIsCorrectFiend = true;
            bool facultyIsCorrectFiend = true;
            bool specialityIsCorrectFiend = true;
            bool courceIsCorrectFiend = true;
            bool groupIsCorrectFiend = true;
            bool cityIsCorrectFiend = true;
            bool postCodeIsCorrectFiend = true;
            bool streetIsCorrectFiend = true;
            bool phoneIsCorrectFiend = true;
            bool eMailIsCorrectFiend = true;


            if (fio == "")
            {
                fioTextBox.ToolTip = "Это поле введено не корректно!";
                fioTextBox.Background = Brushes.DarkRed;

                fioIsCorrectFiend = false;
            }
            else
            {
                fioTextBox.ToolTip = "Это поле введено корректно.";
                fioTextBox.Background = Brushes.White;
            }

            if (faculty == "")
            {
                facultyTextBox.ToolTip = "Это поле введено не корректно!";
                facultyTextBox.Background = Brushes.DarkRed;

                facultyIsCorrectFiend = false;
            }
            else
            {
                facultyTextBox.ToolTip = "Это поле введено корректно!";
                facultyTextBox.Background = Brushes.White;
            }

            if (speciality == "")
            {
                specialityTextBox.ToolTip = "Это поле введено не корректно!";
                specialityTextBox.Background = Brushes.DarkRed;

                specialityIsCorrectFiend = false;
            }
            else
            {
                specialityTextBox.ToolTip = "Это поле введено корректно!";
                specialityTextBox.Background = Brushes.White;
            }

            if (cource == "")
            {
                courceTextBox.ToolTip = "Это поле введено не корректно!";
                courceTextBox.Background = Brushes.DarkRed;

                courceIsCorrectFiend = false;
            }
            else
            {
                courceTextBox.ToolTip = "Это поле введено корректно!";
                courceTextBox.Background = Brushes.White;
            }

            if (group == "")
            {
                groupTextBox.ToolTip = "Это поле введено не корректно!";
                groupTextBox.Background = Brushes.DarkRed;

                groupIsCorrectFiend = false;
            }
            else
            {
                groupTextBox.ToolTip = "Это поле введено корректно!";
                groupTextBox.Background = Brushes.White;
            }

            if (city == "")
            {
                cityTextBox.ToolTip = "Это поле введено не корректно!";
                cityTextBox.Background = Brushes.DarkRed;

                cityIsCorrectFiend = false;
            }
            else
            {
                cityTextBox.ToolTip = "Это поле введено корректно!";
                cityTextBox.Background = Brushes.White;
            }

            if (postCode == "")
            {
                postcodeTextBox.ToolTip = "Это поле введено не корректно!";
                postcodeTextBox.Background = Brushes.DarkRed;

                postCodeIsCorrectFiend = false;
            }
            else
            {
                postcodeTextBox.ToolTip = "Это поле введено корректно!";
                postcodeTextBox.Background = Brushes.White;
            }

            if (street == "")
            {
                streetTextBox.ToolTip = "Это поле введено не корректно!";
                streetTextBox.Background = Brushes.DarkRed;

                streetIsCorrectFiend = false;
            }
            else
            {
                streetTextBox.ToolTip = "Это поле введено корректно!";
                streetTextBox.Background = Brushes.White;
            }

            if (phone == "")
            {
                phoneTextBox.ToolTip = "Это поле введено не корректно!";
                phoneTextBox.Background = Brushes.DarkRed;

                phoneIsCorrectFiend = false;
            }
            else
            {
                phoneTextBox.ToolTip = "Это поле введено корректно!";
                phoneTextBox.Background = Brushes.White;
            }

            if (eMail == "" || !eMail.Contains('@') || !eMail.Contains('.'))
            {
                emailTextBox.ToolTip = "Это поле введено не корректно!";
                emailTextBox.Background = Brushes.DarkRed;

                eMailIsCorrectFiend = false;
            }
            else
            {
                emailTextBox.ToolTip = "Это поле введено корректно!";
                emailTextBox.Background = Brushes.White;
            }

            if (fioIsCorrectFiend && facultyIsCorrectFiend && specialityIsCorrectFiend && courceIsCorrectFiend && groupIsCorrectFiend && cityIsCorrectFiend && postCodeIsCorrectFiend
                && streetIsCorrectFiend && phoneIsCorrectFiend && eMailIsCorrectFiend)
            {
                NewStudent = new Student(fio, new Curriculum(faculty, speciality, cource, group), new Address(city, postCode, street), new Contact(phone, eMail));

                DialogResult = true;

                Close();
                return;
            }

            numClick++;
            if (numClick > 3)
                MessageBox.Show("Хватить тупить! Пожалуйста, заполните все обязательные поля.");
        }
    }
}
