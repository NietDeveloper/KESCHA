using KESCHA.Classes;
namespace KESCHA
{
    class Program
    {
        static void Main()
        {
            Animal kescha= new Bird(name: "KESCHA", age: 3);
            Animal kasee= new Pet(name:"KASEE",age: 5);

            Console.Write("Enter your name:");
            string userName = Console.ReadLine();
            Console.Write("Kescha says:");
            kescha.Greet(userName);
            Console.Write("Kasee says:");
            kasee.Greet(userName);
            Console.Write("Enter your age:");
            string ageAsString = Console.ReadLine();

            int userAge = Convert.ToInt32(ageAsString);
            System.Console.WriteLine("Converting....");
            System.Console.WriteLine($"Succesfuly converted! {userAge}");

            string password="";
            do
            {
                System.Console.Write("Enter the password to talk to Kescha:");
                password=Console.ReadLine();
            }while(password!="qwerty");

            kescha.CalculateAgeDifferenceWithNoReturn(userAge);
            kescha.PrintAgeDifference();
            kescha.CompareAges(userAge);
            kescha.TellAboutFriend(userName,userAge);
        }
    }
}