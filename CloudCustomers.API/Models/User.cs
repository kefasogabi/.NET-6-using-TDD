namespace CloudCustomers.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Emails { get; set; }
        public Address Address { get; set; }
    }
}
