namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Client client = new Client("david", "password123", "david@gmail.com");

            client.Authorize(Console.ReadLine(), Console.ReadLine());

            Client client1 = new Client();




            
        }
    }
}
