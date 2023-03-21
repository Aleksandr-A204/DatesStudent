namespace StudentInfo
{
    public class Curriculum
    {
        public string Faculty { get; set; }
        public string Speciality { get; set; }
        public string Cource { get; set; }
        public string Group { get; set; }
        public Curriculum(string faculty, string speciality, string cource, string group)
        {
            Faculty = faculty;
            Speciality = speciality;
            Cource = cource;
            Group = group;
        }
    }
}
