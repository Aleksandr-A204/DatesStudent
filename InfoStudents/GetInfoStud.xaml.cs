using StudentInfo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
    /// Логика взаимодействия для GetInfoStud.xaml
    /// </summary>
    public partial class GetInfoStud : Window
    {
        public GetInfoStud()
        {
            InitializeComponent();

            userList.ItemsSource = WorkWithFilesAndSerialization.ReadFromFile();
        }
    }
}
