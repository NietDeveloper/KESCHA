namespace KESCHA.Classes
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age {get ; set;}
        public int AgeDifference { get; set; }
        public Animal()
        {
            Name="No name";
            Age=0;
            AgeDifference=0;
        }   

        public Animal (string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Animal(int userAge, int animalAge, string name)
        {
            Name=name;
            Age=animalAge;
            CalculateAgeDifferenceWithNoReturn(userAge,animalAge);
        }

        public void PrintAgeDifference(){
            Console.WriteLine($"The difference between your and {Name}'s age is {AgeDifference}");
        }

        public void CompareAges(int userAge)
        {
            if(userAge<Age){
                Console.WriteLine("You are younger!");
                }
            else if(userAge==Age){
                    Console.WriteLine("You are equal!");
                }
            else{
                Console.WriteLine("You are older!");
                }
        }

        public void TellAboutFriend(string userName, int userAge)
        {
            System.Console.WriteLine("Let me tell you about my friends.");
            string[] friendsName=new string[5];
            friendsName[0]="alpa";
            friendsName[1]="begis";
            friendsName[2]="artur";
            friendsName[3]="islam";
            friendsName[4]=userName;
            int[] friendsAge={24,23,29,30,userAge};
            string[] address={"Mirobod","Yunusobod","Sergeli","Boysun"};
            // foreach(string friendName in friendsName)
            // {
            //     System.Console.WriteLine(friendName);
            // }
            for(int i=0; i<friendsName.Length;i++)
            {
            System.Console.WriteLine($"{friendsName[i]} is {friendsAge[i]} year old.");   
            }
        }
        public void CalculateAgeDifferenceWithNoReturn(int userAge)
        {
            AgeDifference = userAge-Age;
        }
        public int CalculateAgeDifference(int userAge, int animalAge)
        {
            return userAge-animalAge;
        }

        public virtual void Greet(string userName)
        {
            if(userName=="")
            {
                Console.WriteLine("NO NAME!");
            }
            Console.WriteLine($"Hello! {userName}");
        }
        private void CalculateAgeDifferenceWithNoReturn(int userAge, int animalAge)
        {
            AgeDifference=userAge-animalAge;
        }
    }
}