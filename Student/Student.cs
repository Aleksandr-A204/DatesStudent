namespace StudentInfo
{
    public class Student
    {
        public string FIO { get; set; }
        public Curriculum Curriculum { get; set; }
        public Address Address { get; set; }
        public Contacts Contacts { get; set; }

        public Student(string fio, Curriculum curriculum, Address address, Contacts contacts)
        {
            FIO = fio;
            Curriculum = curriculum;
            Address = address;
            Contacts = contacts;
        }
    }
}
