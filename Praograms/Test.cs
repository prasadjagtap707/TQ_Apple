using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Praograms
{
    public class Questions
    {
        public string que;
        public string option1;
        public string option2;
        public string option3;
        public string option4;
        public string correct;
        public Questions()
        {
        }
        public Questions(string que, string option1, string option2, string option3, string option4, string correct)
        {
            this.que = que;
            this.option1 = option1;
            this.option2 = option2;
            this.option3 = option3;
            this.option4 = option4;
            this.correct = correct;
        }

        public string Que { get => que; set => que = value; }
        public string Option1 { get => option1; set => option1 = value; }
        public string Option2 { get => option2; set => option2 = value; }
        public string Option3 { get => option3; set => option3 = value; }
        public string Option4 { get => option4; set => option4 = value; }
        public string Correct { get => correct; set => correct = value; }
    }
    class Test
    {

        Quiz q = new Quiz();
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n-------------------------------------------------------------------------------------------------->>> Welcome to Online Quiz.... <<<------------------------------------------------------------------------------");
            SortedList<string, string> logindetails = new SortedList<string, string>();
            Console.Write("\n\n\t\t\t\t\t\t\t\t\t\t Login ID :  ");
            string login = Console.ReadLine();

            login = login.ToLower();
            if (login == "admin")
            {
                Console.WriteLine("where you want to add questions.\n1.java\n2.csharp\n3.html");
                string subject = Console.ReadLine();
                Console.WriteLine("How many questions do you want to add?");
                int no_que = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < no_que; i++)
                {

                    Console.WriteLine("Enter question- ");
                    string que = Console.ReadLine();
                    Console.WriteLine("Enter Options of Answer(4)");
                    string[] answer = new string[4];
                    for (int j = 0; j < 4; j++)
                    {
                        answer[j] = Console.ReadLine();
                    }
                    Console.WriteLine("Correct answer");
                    string correct = Console.ReadLine();
                    switch (subject)
                    {
                        case "java":
                            {
                                Quiz.java.Add(new Questions(que, answer[0], answer[1], answer[2], answer[3], correct));
                                Console.WriteLine("\tQuestion Successfully added.....");
                                foreach (Questions q in Quiz.java)
                                {
                                    Console.WriteLine(q.que);
                                }
                            }
                            break;
                        case "csharp":
                            {
                                Quiz.csharp.Add(new Questions(que, answer[0], answer[1], answer[2], answer[3], correct));
                                Console.WriteLine("\tQuestion Successfully added.....");
                                foreach (Questions q in Quiz.csharp)
                                {
                                    Console.WriteLine(q.que);
                                }
                            }
                            break;
                        case "html":
                            {
                                Quiz.html.Add(new Questions(que, answer[0], answer[1], answer[2], answer[3], correct));
                                Console.WriteLine("\tQuestion Successfully added.....");
                                foreach (Questions q in Quiz.html)
                                {
                                    Console.WriteLine(q.que);
                                }
                            }
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"------------------------------------------------------------------------------------------------->>>Welcome to MCQ Quiz {login.ToUpper()} <<<-----------------------------------------------------------------------------");
                Console.WriteLine("\n\t >> There will be a total of 20 questions");
                Console.WriteLine("\n\t >> You will be given 4 options and you have to press a, b ,c or d for the" +
                                  "\n\t    right option");
                Console.WriteLine("\n\t >> Each question will carry 1 point");
                Console.WriteLine("\n\t >> You will be asked questions continuously.");
                Console.WriteLine("\n\t >> There is no negative marking for wrong answer");

                Console.WriteLine("\n\n ******************************* BEST OF LUCK ***********************************\n\n");
                Boolean loop = true;
                int marks = 0;
                while (loop)
                {
                    Console.WriteLine("\n\tTopics for MCQ Quiz:\n\t1.java\n\t2.csharp\n\t3.html");
                    int topic = Convert.ToInt32(Console.ReadLine());

                    switch (topic)
                    {
                        case 1:
                            {
                                foreach (Questions o in Quiz.java)
                                {
                                    Console.WriteLine("\n\n");
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("\n");
                                    Console.WriteLine(o.que + "\n\tA." + o.option1 + "\n\tB." + o.option2 + "\n\tC." + o.option3 + "\n\tD." + o.option4);
                                    Console.Write("\n\tAns: ");
                                    string ans = Console.ReadLine();
                                    ans = ans.ToUpper();
                                    if (ans == "a" || ans == "A" || ans == "b" || ans == "B" || ans == "c" || ans == "C" || ans == "d" || ans == "D")
                                    {
                                        if (o.correct == ans)
                                            marks++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Atleast give correct letter(a/b/c/d)....");
                                        ans = Console.ReadLine();
                                        ans = ans.ToUpper();
                                        if (o.correct == ans)
                                            marks++;
                                    }
                                }
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("\tQuiz Complete..\n\n\n\n");
                                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\tYou scored : {marks} out of 10 ");
                            }
                            break;

                        case 2:
                            {
                                foreach (Questions o in Quiz.csharp)
                                {
                                    Console.WriteLine("\n\n");
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("\n");
                                    Console.WriteLine(o.que + "\n\tA." + o.option1 + "\n\tB." + o.option2 + "\n\tC." + o.option3 + "\n\tD." + o.option4);
                                    Console.Write("\n\tAns: ");
                                    string ans = Console.ReadLine();
                                    if (ans == "a" || ans == "A" || ans == "b" || ans == "B" || ans == "c" || ans == "C" || ans == "d" || ans == "D")
                                    {
                                        ans = ans.ToUpper();
                                        if (o.correct == ans)
                                            marks++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Atleast give correct letter(a/b/c/d)....");
                                        ans = Console.ReadLine();
                                        ans = ans.ToUpper();
                                        if (o.correct == ans)
                                            marks++;
                                    }

                                }
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("\tQuiz Complete..");
                                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\tYou scored : {marks} out of 10 ");

                            }
                            break;
                        case 3:
                            {
                                foreach (Questions o in Quiz.html)
                                {
                                    Console.WriteLine("\n\n");
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("\n");
                                    Console.WriteLine(o.que + "\n\tA." + o.option1 + "\n\tB." + o.option2 + "\n\tC." + o.option3 + "\n\tD." + o.option4);
                                    Console.Write("\n\tAns: ");
                                    string ans = Console.ReadLine();
                                    if (ans == "a" || ans == "A" || ans == "b" || ans == "B" || ans == "c" || ans == "C" || ans == "d" || ans == "D")
                                    {
                                        ans = ans.ToUpper();
                                        if (o.correct == ans)
                                            marks++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Atleast give correct letter(a/b/c/d)....");
                                        ans = Console.ReadLine();
                                        ans = ans.ToUpper();
                                        if (o.correct == ans)
                                            marks++;
                                    }

                                }
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("\tQuiz Complete..");
                                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\tYou scored : {marks} out of 10 ");
                            }
                            break;
                    }
                    Console.WriteLine("\n\n");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("\n"); Console.WriteLine("Do you want to give another Quiz Test???(Y/N)");
                    string str = Console.ReadLine();
                    str = str.ToUpper();
                    if (str == "n" || str == "N")
                        loop = false;
                }


            }
        }


    }

    public class Quiz
    {
        public static List<Questions> java = new List<Questions>();
        public static List<Questions> csharp = new List<Questions>();
        public static List<Questions> html = new List<Questions>();

        public static int score = 0;

        static Quiz()
        {
            java.Add(new Questions("1. Which of the following option leads to the portability and security of Java ?", "Bytecode is executed by JVM", "The applet makes the Java code secure and portable", "Use of exception handling", "Dynamic binding between objects", "A"));
            java.Add(new Questions("2. Which of the following is not a Java features ?", "Dynamic", "Architecture Neutral", "Use of pointers", "Object - oriented", "C"));
            java.Add(new Questions("3. The \u0021 article referred to as a", "Unicode escape sequence", "Octal escape", "Hexadecimal", "Line feed", "A"));
            java.Add(new Questions("4.  ___ is used to find and fix bugs in the Java programs.", "JVM", "JRE", "JDK", "JDB", "D"));
            java.Add(new Questions("5. What is the return type of the hashCode() method in the Object class?", "Object", "int", "long", "void", "B"));
            java.Add(new Questions("6. Which of the following is a valid long literal?", "ABH8097", "L990023", "904423", "0xnf029L", "D"));
            java.Add(new Questions("7. What does the expression float a = 35 / 0 return?", "0", "Not a Number", "Infinity", "Run time exception", "C"));
            java.Add(new Questions("8. Evaluate the following Java expression, if x=3, y=5, and z=10:  ++z + y - y + z + x++", "24", "23", "20", "25", "D"));
            java.Add(new Questions("9. Which of the following tool is used to generate API documentation in HTML format from doc comments in source code?", "javap tool", "javaw command", "Javadoc tool", "javah command", "C"));
            java.Add(new Questions("10. Which of the following creates a List of 3 visible items and multiple selections abled?", "new List(false, 3)", "new List(3, true)", "new List(true, 3)", "new List(3, false)", "B"));

            csharp.Add(new Questions("1. CLR is the .Net equivalent of ___.", "Java Virtual machine", "Common Language Runtime", "Common Type System", "Common Language Specification", "A"));
            csharp.Add(new Questions("2. Abstract class contains ___.", "Abstract methods", "Non Abstract methods", "", "Both", "None"));
            csharp.Add(new Questions("3. The default scope for the members of an interface is ___.", "private", "public", "protected", "internal", "B"));
            csharp.Add(new Questions("4. Which of the following statements is incorrect about delegate?", "Delegates are reference types.", "Delegates are object-oriented.", "Delegates are type-safe.", "Only one can be called using a delegate.", "D"));
            csharp.Add(new Questions("5. The space required for structure variables is allocated on the stack.", "Defining of constructors can be implicit or explicit.", "The calling of constructors is explicit.", "Implicit constructors can be parameterized or parameterless.", "Explicit constructors can be parameterized or parameterless.", "C"));
            csharp.Add(new Questions("6. Reference is a _.", "Copy of class which leads to memory allocation.", "Copy of class that is not initialized.", "Pre-defined data type.", "Copy of class creating by an existing instance.", "D"));
            csharp.Add(new Questions("7. The data members of a class by default are?", "protected, public", "private, public", "private", "public", "C"));
            csharp.Add(new Questions("8. What is the value returned by function compareTo( ) if the invoking string is less than the string compared?", "Zero", "A value of less than zero", "A value greater than zero", "None of the mentioned", "B"));
            csharp.Add(new Questions("9. The correct way to overload +operator?", "public sample operator +  (sample a, sample b)", "public abstract operator +  (sample a, sample b)", "public static operator +  (sample a, sample b)", "all of the mentioned above", "D"));
            csharp.Add(new Questions("10. Select the two types of threads mentioned in the concept of multithreading?", "Foreground", "Background", "Only foreground", "Both foreground and background", "D"));

            html.Add(new Questions("1. HTML stands for -", "HighText Machine Language", "HyperText and links Markup Language", "HyperText Markup Language", "None of these", "C"));
            html.Add(new Questions("2. The correct sequence of HTML tags for starting a webpage is -", "Head, Title, HTML, body", "HTML, Body, Title, Head", "HTML, Head, Title, Body", "HTML, Head, Title, Body", "D"));
            html.Add(new Questions("3. Which of the following element is responsible for making the text bold in HTML?", "<pre>", "<a>", "<b>", "<br>", "C"));
            html.Add(new Questions("4. Which of the following tag is used for inserting the largest heading in HTML?", "<h3>", "<h1>", "<h5>", "<h6>", "B"));
            html.Add(new Questions("5. Which of the following tag is used to insert a line-break in HTML?", "<br>", "<a>", "<pre>", "<b>", "A"));
            html.Add(new Questions("6. How to create an unordered list (a list with the list items in bullets) in HTML?", "<ul>", "<ol>", "<li>", "<i>", "A"));
            html.Add(new Questions("7. Which character is used to represent the closing of a tag in HTML?", "!", "/", ".", "none", "D"));
            html.Add(new Questions("8. How to create an ordered list (a list with the list items in numbers) in HTML?", "<ul>", "<ol>", "<li>", "<i>", "B"));
            html.Add(new Questions("9. Which of the following element is responsible for making the text italic in HTML?", "<i>", "<italic>", "<it>", "<pre>", "A"));
            html.Add(new Questions("10. <input> is - ", "a format tag.", "an empty tag.", "All of the above", "None of the above", "B"));

        }
    }

    
}



