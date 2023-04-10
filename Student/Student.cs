namespace StudentInfo
{
    public class Student
    {
        public string FIO { get; set; }
        public Curriculum Curriculum { get; set; }
        public Address Address { get; set; }
        public Contact Contact { get; set; }

        public Student(string fio, Curriculum curriculum, Address address, Contact contact)
        {
            FIO = fio;
            Curriculum = curriculum;
            Address = address;
            Contact = contact;
        }
    }
}
