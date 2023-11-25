using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        //string filePath = "age.txt";
        //if (File.Exists(filePath))
        //{
        //    string age = File.ReadAllText(filePath);
        //    Console.WriteLine("Ваш вік: " + age);
        //}
        //else
        //{
        //    Console.Write("Будь ласка, введіть свій вік: ");
        //    string age = Console.ReadLine();
        //    File.WriteAllText(filePath, age);
        //}
        //Console.ReadKey();

        Random random = new Random();

        string newWordListName;

        string filePath_newWordListName = "PONNNNN";

        int indexAddWord = 0;

        string q;

        string i;

        string wordsList;

        int mistakes = 0;

        string germanWord1 = "zwingen";
        string englischWord1 = "to force";
        string germanWord2 = "ernten";
        string englischWord2 = "to harvest";
        string germanWord3 = "rechtfertigen";
        string englischWord3 = "to justify";
        string germanWord4 = "Schote";
        string englischWord4 = "pod";
        string germanWord5 = "abladen";
        string englischWord5 = "to dump";
        string germanWord6 = "Handel";
        string englischWord6 = "trade";
        string germanWord7 = "egoitisch";
        string englischWord7 = "selfisch";
        string germanWord8 = "Beteiligung";
        string englischWord8 = "involvment";
        string germanWord9 = "ältere Menschen, Senioren";
        string englischWord9 = "the elderly";
        string germanWord10 = "das Engagement";
        string englischWord10 = "commitment";
        string germanWord11 = "Hacken";
        string englischWord11 = "to chop";
        string germanWord12 = "hinauf";
        string englischWord12 = "onto";

        List<string> germanWords = new List<string>();
        List<string> englischWords = new List<string>();

        string englischInput;

        if (File.Exists(filePath_newWordListName))
        {
            newWordListName = File.ReadAllText(filePath_newWordListName);
            
        }
        else
        {
            newWordListName = "empty";
        }
        

        Console.WriteLine("Welcome To My ConsoleApp <3");
        Console.WriteLine("Please select your Words list:");
        Console.WriteLine($"0 - Default\n1 - {newWordListName}\nc - create new word list");

        

        wordsList = Console.ReadLine();

        //доделать потому что пздц
        switch (wordsList)
        {
            case "0":               
                germanWords.AddRange(new string[] { germanWord1, germanWord2, germanWord3, germanWord4, germanWord5, germanWord6, germanWord7, germanWord8, germanWord9, germanWord10, germanWord11, germanWord12 });
                englischWords.AddRange(new string[] { englischWord1, englischWord2, englischWord3, englischWord4, englischWord5, englischWord6, englischWord7, englischWord8, englischWord9, englischWord10, englischWord11, englischWord12 });
                break;
            case "1":

                break;
            case "c":
                Console.WriteLine("How do you want to name this list?");
                newWordListName = Console.ReadLine();
                File.WriteAllText(filePath_newWordListName, newWordListName);

                while (true)
                {
                    indexAddWord += 1;

                    Console.Write("Deutsch:");
                    germanWord1=Console.ReadLine();
                    Console.Write("Englisch:");
                    englischWord1 = Console.ReadLine();
                    germanWords.AddRange(new string[] {germanWord1});
                    englischWords.AddRange(new string[] {englischWord1});

                    Console.Clear();
                    Console.WriteLine("1 - Write one more Word?");
                    Console.WriteLine("2 - its all");
                    q = Console.ReadLine();

                    if (q == "1")
                    {
                        
                    }
                    else if (q == "2")
                    {
                        break;
                    }           
                }

                break;

        }         

        
        
        Console.Clear();


        //ne trogati uhhhh
        while (germanWords.Count > 0)
        {
            int index = random.Next(germanWords.Count);

            Console.WriteLine("Deutsch:" + germanWords[index]);
            Console.Write("Englisch:");
            englischInput = Console.ReadLine();
            if (englischInput == englischWords[index])
            {
                Console.WriteLine("right!");
                germanWords.RemoveAt(index);
                englischWords.RemoveAt(index);
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ops...");
                Console.WriteLine("Right answer:");
                Console.WriteLine("Deutsch:" + germanWords[index]);
                Console.WriteLine("Englisch:" + englischWords[index]);
                mistakes++;
                Console.ReadKey();
                Console.Clear();
            }
        }
        Console.WriteLine($"You did {mistakes} mistakes");

        Console.WriteLine("if you want to practice one more time write 1");
        i = Console.ReadLine();
        if (i == "1")
        {
            Main();
        }
    }
}

