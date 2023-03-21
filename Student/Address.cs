namespace StudentInfo
{
    public class Address
    {
        public string City { get; set; }
        public string PostIndex { get; set; }
        public string Street { get; set; }
        public Address(string city, string postIndex, string street)
        {
            City = city;
            PostIndex = postIndex;
            Street = street;
        }
    }
}
