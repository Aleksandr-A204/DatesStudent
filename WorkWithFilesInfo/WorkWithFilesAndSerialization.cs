using StudentInfo;
using System.Text.Json;

namespace WorkWithFilesInfo
{
    public class WorkWithFilesAndSerialization
    {

        // относительный путь к файлу
        private static string path = Path.Combine(Directory.GetCurrentDirectory(), "example1Json.json");

        // запись данных о студентах в файл
        public static void WriteToFile(List<Student> newListStudents)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                JsonSerializer.Serialize<List<Student>>(fs, newListStudents, options);
            }
        }

        // чтение данных о студентах из файла
        public static List<Student> ReadFromFile()
        {
            List<Student> listStudentsInfo = new List<Student>();

            if (!File.Exists(path))
                Console.WriteLine("Ошибка! Такого файла не существует!");
            else
                using (FileStream fs = new FileStream(path, FileMode.Open))
                    listStudentsInfo.AddRange(JsonSerializer.Deserialize<List<Student>>(fs)!);

            return listStudentsInfo;
        }
    }
}