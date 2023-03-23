using StudentInfo;
using WorkWithFilesInfo;

namespace StudentData
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 50;
            Console.WindowWidth = 210;
            Console.Title = "Данные о студентах";

            do
            {
                Console.WriteLine("1. Получить полный список студентов.");
                Console.WriteLine("2. Отображать/отредактировать карточки студента.");
                Console.WriteLine("3. Просмотривать список студентов с фильтрацией по любому полю.");
                Console.WriteLine("4. Добавить/удалить студента.");
                Console.WriteLine("5. Завершить программу.");
                var number = Console.ReadLine();
                Console.Clear();

                switch (number)
                {
                    case "1":
                        PrintInfoAboutStutendts(WorkWithFilesAndSerialization.ReadFromFile());
                        break;
                    case "2":
                        ShowingOrEditingStudent();
                        break;
                    case "3":
                        WatchListStudentsWithFilter();
                        break;
                    case "4":
                        SizeStud();
                        break;
                    case "5":
                        return;
                    default:
                        Console.Clear();
                        continue;
                }
                Console.Write("Чтобы почистить консольку и продолжить программу, нажмите любую клавишу.");
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }

        static void PrintInfoAboutStutendts(List<Student> listStudents, bool tablIsEmpty = true)
        {

            var maxWidthNumber = "№".Length;
            var maxWidthFIO = "FIO".Length;
            var maxWidthFaculty = "Faculty".Length;
            var maxWidthSpeciality = "Speciality".Length;
            var maxWidthCource = "Cource".Length;
            var maxWidthGroup = "Group".Length;
            var maxWidthCity = "City".Length;
            var maxWidthPostIndex = "PostIndex".Length;
            var maxWidthStreet = "Street".Length;
            var maxWidthPhone = "Phone".Length;
            var maxWidthEmail = "Email".Length;

            if (listStudents?.Count() == 0)
            {
                if (!tablIsEmpty)
                {
                    var formatTablDisj = string.Format("| {{0, -{0}}} | {{1, -{1}}} | {{2, -{2}}} | {{3, -{3}}} | {{4, -{4}}} | {{5, -{5}}} | {{6, -{6}}} | {{7, -{7}}} | {{8, -{8}}} | {{9, -{9}}} | {{10, -{10}}} |",
                        maxWidthNumber, maxWidthFIO, maxWidthFaculty, maxWidthSpeciality, maxWidthCource, maxWidthGroup, maxWidthCity, maxWidthPostIndex, maxWidthStreet, maxWidthPhone, maxWidthEmail);
                    var formatTablInter = string.Format("+ {{0, -{0}}} + {{1, -{1}}} + {{2, -{2}}} + {{3, -{3}}} + {{4, -{4}}} + {{5, -{5}}} + {{6, -{6}}} + {{7, -{7}}} + {{8, -{8}}} + {{9, -{9}}} + {{10, -{10}}} +",
                        maxWidthNumber, maxWidthFIO, maxWidthFaculty, maxWidthSpeciality, maxWidthCource, maxWidthGroup, maxWidthCity, maxWidthPostIndex, maxWidthStreet, maxWidthPhone, maxWidthEmail);

                    PrintHeadlines(formatTablDisj, formatTablInter, maxWidthNumber, maxWidthFIO, maxWidthFaculty, maxWidthSpeciality, maxWidthCource, maxWidthGroup,
                        maxWidthCity, maxWidthPostIndex, maxWidthStreet, maxWidthPhone, maxWidthEmail);
                    Console.WriteLine("Не найдено!");
                }
                else
                    Console.WriteLine("Пустая таблица!");
            } else
            {
                maxWidthNumber = string.Format("{0}", listStudents?.Count()).Length > maxWidthNumber ? string.Format("{0}", listStudents!.Count()).Length : maxWidthNumber;
                maxWidthFIO = listStudents?.Select(stud => stud.FIO.Length).Max() > maxWidthFIO ? listStudents!.Select(stud => stud.FIO.Length).Max() : maxWidthFIO;
                maxWidthFaculty = listStudents?.Select(stud => stud.Curriculum.Faculty.Length).Max() > maxWidthFaculty ? listStudents!.Select(stud => stud.Curriculum.Faculty.Length).Max() : maxWidthFaculty;
                maxWidthSpeciality = listStudents?.Select(stud => stud.Curriculum.Speciality.Length).Max() > maxWidthSpeciality ? listStudents!.Select(stud => stud.Curriculum.Speciality.Length).Max() : maxWidthSpeciality;
                maxWidthCource = listStudents?.Select(stud => stud.Curriculum.Cource.Length).Max() > maxWidthCource ? listStudents!.Select(stud => stud.Curriculum.Cource.Length).Max() : maxWidthCource;
                maxWidthGroup = listStudents?.Select(stud => stud.Curriculum.Group.Length).Max() > maxWidthGroup ? listStudents!.Select(stud => stud.Curriculum.Group.Length).Max() : maxWidthGroup;
                maxWidthCity = listStudents?.Select(stud => stud.Address.City.Length).Max() > maxWidthCity ? listStudents!.Select(stud => stud.Address.City.Length).Max() : maxWidthCity;
                maxWidthPostIndex = listStudents?.Select(stud => stud.Address.PostIndex.Length).Max() > maxWidthPostIndex ? listStudents!.Select(stud => stud.Address.PostIndex.Length).Max() : maxWidthPostIndex;
                maxWidthStreet = listStudents?.Select(stud => stud.Address.Street.Length).Max() > maxWidthStreet ? listStudents!.Select(stud => stud.Address.Street.Length).Max() : maxWidthStreet;
                maxWidthPhone = listStudents?.Select(stud => stud.Contacts.Phone.Length).Max() > maxWidthPhone ? listStudents!.Select(stud => stud.Contacts.Phone.Length).Max() : maxWidthPhone;
                maxWidthEmail = listStudents?.Select(stud => stud.Contacts.Email.Length).Max() > maxWidthEmail ? listStudents!.Select(stud => stud.Contacts.Email.Length).Max() : maxWidthEmail;

                var formatTablDisj = string.Format("| {{0, -{0}}} | {{1, -{1}}} | {{2, -{2}}} | {{3, -{3}}} | {{4, -{4}}} | {{5, -{5}}} | {{6, -{6}}} | {{7, -{7}}} | {{8, -{8}}} | {{9, -{9}}} | {{10, -{10}}} |",
                    maxWidthNumber, maxWidthFIO, maxWidthFaculty, maxWidthSpeciality, maxWidthCource, maxWidthGroup, maxWidthCity, maxWidthPostIndex, maxWidthStreet, maxWidthPhone, maxWidthEmail);
                var formatTablInter = string.Format("+ {{0, -{0}}} + {{1, -{1}}} + {{2, -{2}}} + {{3, -{3}}} + {{4, -{4}}} + {{5, -{5}}} + {{6, -{6}}} + {{7, -{7}}} + {{8, -{8}}} + {{9, -{9}}} + {{10, -{10}}} +",
                    maxWidthNumber, maxWidthFIO, maxWidthFaculty, maxWidthSpeciality, maxWidthCource, maxWidthGroup, maxWidthCity, maxWidthPostIndex, maxWidthStreet, maxWidthPhone, maxWidthEmail);

                PrintHeadlines(formatTablDisj, formatTablInter, maxWidthNumber, maxWidthFIO, maxWidthFaculty, maxWidthSpeciality, maxWidthCource, maxWidthGroup,
                    maxWidthCity, maxWidthPostIndex, maxWidthStreet, maxWidthPhone, maxWidthEmail);

                int i = 1;
                foreach (var student in listStudents!)
                    Console.WriteLine(formatTablDisj, i++, student.FIO, student.Curriculum.Faculty, student.Curriculum.Speciality, student.Curriculum.Cource,
                        student.Curriculum.Group, student.Address.City, student.Address.PostIndex, student.Address.Street, student.Contacts.Phone,
                        student.Contacts.Email);

                Console.WriteLine(formatTablInter, formatTabl(maxWidthNumber), formatTabl(maxWidthFIO), formatTabl(maxWidthFaculty), formatTabl(maxWidthSpeciality), formatTabl(maxWidthCource),
                                formatTabl(maxWidthGroup), formatTabl(maxWidthCity), formatTabl(maxWidthPostIndex), formatTabl(maxWidthStreet), formatTabl(maxWidthPhone), formatTabl(maxWidthEmail));
            }
        }
        static void PrintHeadlines(string tablDisj, string tablInter, params int[] maxWidth)
        {
            Console.WriteLine(tablInter, formatTabl(maxWidth[0]), formatTabl(maxWidth[1]), formatTabl(maxWidth[2]), formatTabl(maxWidth[3]), formatTabl(maxWidth[4]),
                formatTabl(maxWidth[5]), formatTabl(maxWidth[6]), formatTabl(maxWidth[7]), formatTabl(maxWidth[8]), formatTabl(maxWidth[9]), formatTabl(maxWidth[10]));
            Console.WriteLine(tablDisj, "№", "FIO", "Faculty", "Speciality", "Cource", "Group", "City", "PostIndex", "Street", "Phone", "Email");
            Console.WriteLine(tablInter, formatTabl(maxWidth[0]), formatTabl(maxWidth[1]), formatTabl(maxWidth[2]), formatTabl(maxWidth[3]), formatTabl(maxWidth[4]),
                formatTabl(maxWidth[5]), formatTabl(maxWidth[6]), formatTabl(maxWidth[7]), formatTabl(maxWidth[8]), formatTabl(maxWidth[9]), formatTabl(maxWidth[10]));
        }

        static string formatTabl(int maxWidth)
        {
            string str = "";

            for (int i = 0; i < maxWidth; i++)
                str += "-";

            return str;
        }

        // Метод создания отображения/редактирования карточки студента
        static void ShowingOrEditingStudent()
        {
            List<Student> listStudents = WorkWithFilesAndSerialization.ReadFromFile();

            PrintInfoAboutStutendts(listStudents);

            if (listStudents.Count() == 0)
            {
                Console.WriteLine("Невозможно редактировать, т.к. пустая таблица!");
                return;
            }

            bool isSaveToFile = false;
            var nmr = "0";
            do
            {
                if (nmr == "0")
                    Console.Write("Введите номер строки таблицы, для которого вы хотите изменить информацию про студента: ");
                else
                {
                    while (true)
                    {
                        PrintInfoAboutStutendts(listStudents);

                        Console.Write("Вы хотите ещё редактировать данные о студенте? y/n ");

                        var yesOrNo = Console.ReadLine()?.ToLower();
                        if (yesOrNo == "y")
                            break;
                        else if (yesOrNo == "n")
                        {
                            WorkWithFilesAndSerialization.WriteToFile(listStudents);
                            return;
                        } else
                        {
                            Console.Clear();
                            continue;
                        }
                    }
                    isSaveToFile = true;
                    Console.Write("Введите номер строки таблицы, для которого вы хотите изменить информацию про студента: ");
                }

                int number;

                while (!(int.TryParse(Console.ReadLine()!, out number) && 1 <= number && listStudents.Count() >= number--))
                {
                    Console.Clear();
                    if (listStudents.Count() <= number)
                        Console.WriteLine("Ошибка! Нет такого номера строки в таблице!");
                    else
                        Console.WriteLine("Ошибка при конвертации!");
                    PrintInfoAboutStutendts(listStudents);
                    Console.Write("Ещё раз введите натуральное число, которому принадлежит номер строки: ");
                }

                PrintInfoSize();

                nmr = Console.ReadLine();
                while (nmr != "1" && nmr != "2" && nmr != "3" && nmr != "4" && nmr != "5" && nmr != "6" && nmr != "7" && nmr != "8" && nmr != "9" && nmr != "10" && nmr != "0")
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка! Редактируем информацию про студента в {0}-й строке таблицы.", number + 1);
                    PrintInfoAboutStutendts(listStudents);
                    PrintInfoSize();
                    nmr = Console.ReadLine();
                }

                switch (nmr)
                {
                    case "1":
                        Console.Write("Измените ФИО: ");
                        listStudents[number].FIO = Console.ReadLine() ?? "";
                        Console.Clear();
                        Console.WriteLine("ФИО успешно было изменено.");
                        break;
                    case "2":
                        Console.Write("Измените факультет: ");
                        listStudents[number].Curriculum.Faculty = Console.ReadLine() ?? "";
                        Console.Clear();
                        Console.WriteLine("Факультет успешно был изменен.");
                        break;
                    case "3":
                        Console.Write("Измените специальность: ");
                        listStudents[number].Curriculum.Speciality = Console.ReadLine() ?? "";
                        Console.Clear();
                        Console.WriteLine("Специальность успешно была изменена.");
                        break;
                    case "4":
                        Console.Write("Измените курс: ");
                        listStudents[number].Curriculum.Cource = Console.ReadLine() ?? "";
                        Console.Clear();
                        Console.WriteLine("Курс успешно был изменен.");
                        break;
                    case "5":
                        Console.Write("Измените группу: ");
                        listStudents[number].Curriculum.Group = Console.ReadLine() ?? "";
                        Console.Clear();
                        Console.WriteLine("Группа успешно была изменена.");
                        break;
                    case "6":
                        Console.Write("Измените город: ");
                        listStudents[number].Address.City = Console.ReadLine() ?? "";
                        Console.Clear();
                        Console.WriteLine("Город успешно был изменен.");
                        break;
                    case "7":
                        Console.Write("Измените почтовый индекс: ");
                        listStudents[number].Address.PostIndex = Console.ReadLine() ?? "";
                        Console.Clear();
                        Console.WriteLine("Почтовый индекс успешно был изменен.");
                        break;
                    case "8":
                        Console.Write("Измените улицу: ");
                        listStudents[number].Address.Street = Console.ReadLine() ?? "";
                        Console.Clear();
                        Console.WriteLine("Улица успешно была изменена.");
                        break;
                    case "9":
                        Console.Write("Измените номер телефона: ");
                        listStudents[number].Contacts.Phone = Console.ReadLine() ?? "";
                        Console.Clear();
                        Console.WriteLine("Телефон успешно был изменен.");
                        break;
                    case "10":
                        Console.Write("Измените адрес электронной почты: ");
                        listStudents[number].Contacts.Email = Console.ReadLine() ?? "";
                        Console.Clear();
                        Console.WriteLine("Адрес электронной почты успешно был изменен.");
                        break;
                }
            } while (nmr != "0");

            if (isSaveToFile)
                WorkWithFilesAndSerialization.WriteToFile(listStudents);
        }
        static void PrintInfoSize()
        {
            Console.WriteLine("1) Изменение ФИО");
            Console.WriteLine("2) Изменение факультета");
            Console.WriteLine("3) Изменение специальности");
            Console.WriteLine("4) Изменение курса");
            Console.WriteLine("5) Изменение группы");
            Console.WriteLine("6) Изменение города");
            Console.WriteLine("7) Изменение почтового индекса");
            Console.WriteLine("8) Изменение улицы");
            Console.WriteLine("9) Изменение номера телефона");
            Console.WriteLine("10) Изменение адреса электронной почты");
            Console.WriteLine("0) Выход");
        }

        // Метод формы просмотра списка студентов с возможностью фильтрации по факультету, специальности, курсу, группе
        static void WatchListStudentsWithFilter()
        {
            List<Student> listStudents = WorkWithFilesAndSerialization.ReadFromFile();

            PrintInfoAboutStutendts(listStudents);

            if (listStudents.Count() == 0)
            {
                Console.WriteLine("Невозможно фильтровать по любому полю, т.к. пустая таблица!");
                return;
            }

            List<Student> listFilteringBy = new List<Student>();

            Console.Write("Фильтруете по любому полю: ");
            var scanfString = Console.ReadLine();

            listFilteringBy.AddRange(listStudents.Where(student => student.FIO.Contains(scanfString!, StringComparison.OrdinalIgnoreCase)
            || student.Curriculum.Faculty.Contains(scanfString!, StringComparison.OrdinalIgnoreCase) || student.Curriculum.Speciality.Contains(scanfString!, StringComparison.OrdinalIgnoreCase)
            || student.Curriculum.Cource.Contains(scanfString!, StringComparison.OrdinalIgnoreCase) || student.Curriculum.Group.Contains(scanfString!, StringComparison.OrdinalIgnoreCase)
            || student.Address.City.Contains(scanfString!, StringComparison.OrdinalIgnoreCase) || student.Address.PostIndex.Contains(scanfString!, StringComparison.OrdinalIgnoreCase)
            || student.Address.Street.Contains(scanfString!, StringComparison.OrdinalIgnoreCase) || student.Contacts.Phone.Contains(scanfString!, StringComparison.OrdinalIgnoreCase)
            || student.Contacts.Email.Contains(scanfString!, StringComparison.OrdinalIgnoreCase))!);

            Console.Clear();

            PrintInfoAboutStutendts(listFilteringBy, false);
        }

        // Метод добавления/удаления студента
        static void SizeStud()
        {
            List<Student> listStudents = WorkWithFilesAndSerialization.ReadFromFile();

            while (true)
            {
                PrintInfoAboutStutendts(listStudents);

                Console.WriteLine("1. Добавить студента.\n2. Удалить студента.");
                var number = Console.ReadLine();

                switch (number)
                {
                    case "1":

                        Console.Write("Заполняем информацию о студенте.\nВведите ФИО: ");
                        var scanfFIO = Console.ReadLine() ?? "";
                        Console.Write("Введите факультет: ");
                        var scanfFacult = Console.ReadLine() ?? "";
                        Console.Write("Введите специальность: ");
                        var scanfSpecial = Console.ReadLine() ?? "";
                        Console.Write("Введите курс: ");
                        var scanfCource = Console.ReadLine() ?? "";
                        Console.Write("Введите группу: ");
                        var scanfGroup = Console.ReadLine() ?? "";
                        Console.Write("Введите город: ");
                        var scanfCity = Console.ReadLine() ?? "";
                        Console.Write("Введите почтовый индекс: ");
                        var scanfIndex = Console.ReadLine() ?? "";
                        Console.Write("Введите улицу: ");
                        var scanfStreet = Console.ReadLine() ?? "";
                        Console.Write("Введите номер телефона: ");
                        var scanfPhone = Console.ReadLine() ?? "";
                        Console.Write("Введите электронную почту: ");
                        var scanfEmail = Console.ReadLine() ?? "";

                        listStudents.Add(new Student(scanfFIO, new Curriculum(scanfFacult, scanfSpecial, scanfCource, scanfGroup), new Address(scanfCity, scanfIndex, scanfStreet), 
                            new Contacts(scanfPhone, scanfEmail)));
                        WorkWithFilesAndSerialization.WriteToFile(listStudents);
                        Console.WriteLine("Студент успешно добавлен в конец списка.");
                        return;
                    case "2":

                        if (listStudents.Count() == 0)
                        {
                            Console.WriteLine("Невозможно удалить, т.к. пустая таблица!");
                            return;
                        }

                        Console.Write("Введите номер строки, который из таблицы вы хотите удалить. ");
                        listStudents.RemoveAt(Nmr(listStudents) - 1);
                        WorkWithFilesAndSerialization.WriteToFile(listStudents);
                        Console.WriteLine("Студент успешно удален.");
                        return;
                }
                Console.Clear();
            }
        }
        static int Nmr(List<Student> listStudents)
        {

            int nmr;

            while (!(int.TryParse(Console.ReadLine(), out nmr) && listStudents.Count() >= nmr && 0 < nmr))
            {
                Console.Clear();
                Console.WriteLine("Ошибка!");
                PrintInfoAboutStutendts(listStudents);
                Console.WriteLine("Ещё раз введите номер строки, который из таблицы вы хотите удалить. ");
            }
            return nmr;
        }
    }
}