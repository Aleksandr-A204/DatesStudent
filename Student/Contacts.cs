namespace StudentInfo
{
    public class Contacts
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public Contacts(string phone, string email)
        {
            Phone = phone;
            Email = email;
        }
    }
}
