using System;


namespace AllAssignmentsHub
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userWantsToExit = false;
            while (!userWantsToExit)
            {
                Console.WriteLine("Welcome to C# programming all class assignments!");
                Console.WriteLine("Choose an assignment below:");
                Console.WriteLine("1: Good morning world");
                Console.WriteLine("2: My age");
                Console.WriteLine("3: Grade calculator");
                Console.WriteLine("4: Multiplication loop");
                Console.WriteLine("5: Array: Three films");
                Console.WriteLine("6: Dog age");
                Console.WriteLine("7: whileLoop Multiplication");
                Console.WriteLine("8: String");
                Console.WriteLine("9: Object and Class");
                Console.WriteLine("0: EXIT");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int n)) //User input a number
                {
                    int selection = int.Parse(input);
                    if (selection <= 9 && selection >= 0)
                    {
                        Console.Clear();

                        if (selection == 1)
                        {
                            Code.Assignments.Assignment1();
                        }
                        if (selection == 2)
                        {
                            Code.Assignments.Assignment2();
                        }
                        if (selection == 3)
                        {
                            Code.Assignments.Assignment3();
                        }
                        if (selection == 4)
                        {
                            Code.Assignments.Assignment4();
                        }
                        if (selection == 5)
                        {
                            Code.Assignments.Assignment5();
                        }
                        if (selection == 6)
                        {
                            Code.Assignments.Assignment6();
                        }
                        if (selection == 7)
                        {
                            Code.Assignments.Assignment7();
                        }
                        if (selection == 8)
                        {
                            Code.Assignments.Assignment8();
                        }
                        if (selection == 9)
                        {
                            Code.Assignments.Assignment9();
                        }

                        if (selection == 0)
                        {
                            Console.WriteLine("Good bye");
                            userWantsToExit = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please choose a number between 0-9");
                    }
                }
                else //user input something else
                {
                    Console.WriteLine("Please choose a number between 0-9");
                }
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
