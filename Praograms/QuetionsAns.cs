using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Praograms
{
    class QuetionsAns
    {
        string question;
        string option_A;
        string option_B;
        string option_C;
        string option_D;
        string correctoption;

        public QuetionsAns(string question, string option_A, string option_B, string option_C, string option_D, string correctoption)
        {
            this.Question = question;
            this.Option_A = option_A;
            this.Option_B = option_B;
            this.Option_C = option_C;
            this.Option_D = option_D;
            this.Correctoption = correctoption;
        }

        public string Question { get => question; set => question = value; }
        public string Option_A { get => option_A; set => option_A = value; }
        public string Option_B { get => option_B; set => option_B = value; }
        public string Option_C { get => option_C; set => option_C = value; }
        public string Option_D { get => option_D; set => option_D = value; }
        public string Correctoption { get => correctoption; set => correctoption = value; }
    }

    class Quizzz
    {
        static List<QuetionsAns> java = new List<QuetionsAns>();
        static List<QuetionsAns> csharp =new List<QuetionsAns>();
        static List<QuetionsAns> Html = new List<QuetionsAns>();
      
        static Dictionary<string, List<QuetionsAns>> dt = new Dictionary<string, List<QuetionsAns>>();
        static int score = 0;
        static Quizzz()
        {
            java.Add(new QuetionsAns("1)What is java "," A"," B","c","d","A"));
            java.Add(new QuetionsAns("2)Number of primitive data types in Java are?","6","7","8","9","C"));
            java.Add(new QuetionsAns("3)_____ is used to find and fix bugs in the Java programs.", "JVM", "JRE", "JDK", "JDB", "D"));
            java.Add(new QuetionsAns("4)What is the return type of the hashCode() method in the Object class? ", " Object", " int", "long", "void", "B"));
            java.Add(new QuetionsAns("5)Which package contains the Random class?", " java.util package", " java.lang package", "java.awt package", "java.io package", " A"));

            csharp.Add(new QuetionsAns("Q 1 - Which of the following defines unboxing correctly?", "When a value type is converted to object type, it is called unboxing.", "When an object type is converted to a value type, it is called unboxing.", "Both of the above.", " None of the above.","B"));
            csharp.Add(new QuetionsAns("Q 2 - Which of the following converts a type to a string in C#?", " ToInt64", "ToSbyte", "ToSingle", "ToString", "D"));
            csharp.Add(new QuetionsAns("Q 3 - Which of the following operator creates a pointer to a variable in C#?", "sizeof", "typeof", "&", "*", "D"));
            csharp.Add(new QuetionsAns("Q 4 - Which of the following is the default access specifier of a class member variable?","Private","Public","Protected","Internal","A"));
            csharp.Add(new QuetionsAns("Q 5 - Which of the following preprocessor directive allows to create a compound conditional directive, along with #if in C#?","define","elif","if","else","D"));

            Html.Add(new QuetionsAns("Q 1 -What does HTML stand for?", "Home Test markup Load","Hyper test markup Languange", "Hyper or hyperLink test markup Languange","None of these","B"));
            Html.Add(new QuetionsAns("Q 2 -What is the smallest header in HTML by default?", "h2", "h4", "h6", "h7", "C"));
            Html.Add(new QuetionsAns("Q 3 - HTML files are saved by default with the extension?", ".html", ".h", ".ht", ".HTC", "A"));
            Html.Add(new QuetionsAns("Q 4 -The correct sequence of HTML tags for starting a webpage is -", "Head, Title, HTML, body", "HTML, Body, Title, Head", "HTML, Head, Title, Body", "HTML, Head, Title, Body","D"));
            Html.Add(new QuetionsAns("Q 5 -Which of the following element is responsible for making the text bold in HTML?", "<pre>","<b>","<a>","<br>","B"));


        }   

        static void Main(string[] args)
        {
            string str;
            int choice;
            Console.WriteLine("Enter Your Name -:  ");
            str = (Console.ReadLine());
            while (true)
            {
                Console.WriteLine("WELCOME TO  " + str + " for  Quize\n");
                Console.WriteLine("*****choice the Languange **********\n\n");

                Console.WriteLine("1. Java\n");
                Console.WriteLine("2. C# \n");
                Console.WriteLine("3. HTML \n");

                Console.WriteLine("***************\n\n");
                Console.WriteLine("ENTER YOUR CHOICE : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                       
                        break;

                    case 2:
                        foreach (var csharp in csharp)
                        {
                            Console.WriteLine(csharp);
                        }
                        break;
                    case 3:
                        foreach (var html in Html)
                        {
                            Console.WriteLine(html);
                        }
                        break;
                }
                Console.WriteLine("\n\n THANK you ");
            }
        }
    }
}
