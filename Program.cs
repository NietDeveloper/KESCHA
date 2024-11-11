System.Console.Write("Enter your name:");
string name = Console.ReadLine();
System.Console.WriteLine($"Hello {name}");
System.Console.Write("Enter you age:");
int age = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Successfully. Your age is {age}");
int ageKescha = 2;
if(age > ageKescha)
{
    System.Console.WriteLine($"Men sizden {age-ageKescha} jas kishi ekenmen.");
}
else if(age<ageKescha)
{
    System.Console.WriteLine($"Men sizden {ageKescha-age} jas u\'lkenmen");
}
else
{
    System.Console.WriteLine("Bizdin' jasimiz ten' eken.");
}

