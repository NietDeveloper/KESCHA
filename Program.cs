System.Console.Write("Enter your name:");
string name = Console.ReadLine();
string greeting = $"Hello! {name}";
System.Console.Write("Enter your age:");
string ageAsString = Console.ReadLine();
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine("Converting....");
System.Console.WriteLine($"Succesfuly converted! {age}");
string password="";
do
{
    System.Console.Write("Enter the password to talk to Kescha:");
    password=Console.ReadLine();
}while(password!="niet0999");
System.Console.Write("Enter the age of Kescha:");
string ageAsString1 = Console.ReadLine();
int ageKescha = Convert.ToInt32(ageAsString1);
string message=
    age>=10 || ageKescha>=10
        ?$"{name} and Kescha are older than 10 years."
        :$"{name} and Kescha are younger than 10 years.";
System.Console.WriteLine(message);

if(age<ageKescha){
    System.Console.WriteLine("You are younger!");
}
else if(age==ageKescha){
    System.Console.WriteLine("You are equal!");
}
else{
    System.Console.WriteLine("You are older!");
}

System.Console.WriteLine("Let me tell you about my friends.");
string[] friendsName=new string[5];
friendsName[0]="alpa";
friendsName[1]="begis";
friendsName[2]="artur";
friendsName[3]="islam";
friendsName[4]=name;
int[] friendsAge={24,23,29,30,age};
string[] address={"Mirobod","Yunusobod","Sergeli","Boysun"};
// foreach(string friendName in friendsName)
// {
//     System.Console.WriteLine(friendName);
// }
for(int i=0; i<friendsName.Length;i++)
{
System.Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} year old.");   
}

