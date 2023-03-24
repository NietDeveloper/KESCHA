System.Console.Write("Enter your name:");
string name = Console.ReadLine();
string greeting = $"Hello! {name}";
System.Console.Write("Enter your age:");
string ageAsString = Console.ReadLine();
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine("Converting....");
System.Console.WriteLine($"Succesfuly converted! {age}");
System.Console.Write("Enter the age of Kescha:");
string ageAsString1 = Console.ReadLine();
int ageKescha = Convert.ToInt32(ageAsString1);

if(age<ageKescha){
    System.Console.WriteLine("You are younger!");
}
else if(age==ageKescha){
    System.Console.WriteLine("You are equal!");
}
else{
    System.Console.WriteLine("You are older!");
}