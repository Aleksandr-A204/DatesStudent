namespace StudentInfo
{
    public class Contact
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public Contact(string phone, string email)
        {
            Phone = phone;
            Email = email;
        }
    }
}
