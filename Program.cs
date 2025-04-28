namespace OppgaveKHBE0424;

class Program
{
    static void Main(string[] args)
    {
        /* initalize a new object, from a class
        Person person = new Person();
        person.Name = "Marius";
        person.Age = 39;
        
        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);

        string[] shoppingList = {"Milk", "Soda", "Dinner", "Candy", "Fish", "Salmon"}; // fixed size: new string[6]
        List<string> programmeringLanguages = new List<string>() {
            "C#", "Java", "Python", "JavaScript", "C", "C++", "Rust", "Go"
        };

        List<int> ints = [1,2,3,4];

        for(int i = 0; i < shoppingList.Length; i++) 
        {
            Console.WriteLine(shoppingList[i]);
        }

        foreach(var programming in programmeringLanguages) 
        {
            Console.WriteLine(programming);
        }*/

        /*
            Oppgave 1:
                - Lag noen enkle variabler av forksjellige primitive datatyper
                - Forsøk å skrive ut verdiene som er tildelt variablene ved å bruke Console.WriteLine(); metoden.
        */

        // svar oppgave 1.1

            string fName = "john";
            string lName = "doe";
           //int age = 35;
            char group = 'A';
            bool present = true;
            double version = 1.1;

        // svar oppgave 1.2

            Console.WriteLine (fName);
            Console.WriteLine (lName);
            //Console.WriteLine (age);
            Console.WriteLine (group);
            Console.WriteLine (present);
            Console.WriteLine (version);

        // command dotnet run in terminal

        /*
            Oppgave 2:
                - Forsøk å lage et array av forksjellige primitive datatyper.
                - Forsøk å skrive ut verdiene som befinner seg i arrayet, ved å bruke en for-loop, eller en foreach-loop.
        */
            Console.WriteLine ("Oppgave 2 starter her");
        // svar oppgave 2.1

            string[] merke = {"samsung", "apple", "sony", "nokia"};
            int[] screenSize = {10, 20, 30, 40};
            char[] electricityClass = {'A', 'B', 'C', 'D'};
            double[] osVersion = {1.1, 1.2, 1.3, 1.4};

        // svar oppgave 2.2

            for (int i = 0; i < merke.Length; i++) 
            {
                Console.WriteLine($"Merke: {merke[i]} - Screen size: {screenSize[i]} - Energy Class: {electricityClass[i]} - OS Version: {osVersion[i]}");
            }

            Console.WriteLine ("Oppgave 3 starter her");

        /*
            Oppgave 3:
                - Forsøk å tildele variabler til en generiske Liste: eksempel: List<int> integers = new List<int>();
                - Forsøk å skrive ut verdiene i listen, ved å bruke en for-loop eller en foreach-loop.
        */

        // svar oppgave 3.1

        List<string> Merke = new List<string>();
        Merke.Add ("samsung");
        Merke.Add("apple");
        Merke.Add("sony");
        Merke.Add("nokia");
        List<int> Size = new List<int>();
        Size.Add(10);
        Size.Add(20);
        Size.Add(30);
        Size.Add(40);
        List<char> EnergyClass = new List<char>();
        EnergyClass.Add('A');
        EnergyClass.Add('B');
        EnergyClass.Add('C');
        EnergyClass.Add('D');
        List<double> OsVersion = new List<double>();
        OsVersion.Add(1.1);
        OsVersion.Add(1.2);
        OsVersion.Add(1.2);
        OsVersion.Add(1.3);

        // svar oppgave 3.2

        for (int i = 0; i < Merke.Count; i++)
        Console.WriteLine ($"Merke: {Merke[i]} - Size: {Size[i]} -Energyclass:  {EnergyClass[i]} -OS version: {osVersion[i]}");


    }

    	public static double Add(double a, double b) 
		{
		  return a + b;
		}
		
		public static void AddVoid(double a, double b) 
		{
		  Console.WriteLine(a + b);
		}
}
