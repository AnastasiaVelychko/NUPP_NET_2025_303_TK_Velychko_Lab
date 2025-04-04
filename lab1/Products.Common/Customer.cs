namespace OnlineElectronics.Common
{
    // Клас для клієнтів
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        // Конструктор класу Customer
        public Customer(int id, string name, string email, string address)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
        }
    }
}
