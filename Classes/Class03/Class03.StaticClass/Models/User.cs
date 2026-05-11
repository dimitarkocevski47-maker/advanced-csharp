using Class03.StaticClass.Helpers;

namespace Class03.StaticClass.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

        public User(string username, string address, List<Order> orders)
        {
            Username = username;
            Address = address;
            Orders = orders;
        }

        public User()
        {
            
        }

        public void PrintOrders()
        {
            //ConsoleHelper consoleHelper = new ConsoleHelper();

            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine($"Orders of {Username}:");
            //Console.ResetColor();

            ConsoleHelper.WriteInColor($"Orders of {Username}:");

            for (int i = 0; i < Orders.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {Orders[i].GetInfo()}");
            }
        }
    }
}
