namespace HabitTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("== HABIT TRACKER ==");
                Console.WriteLine("Enter 1 to login for the Day");
                Console.WriteLine("Enter 2 to add a new Habit");
                Console.WriteLine("Enter 3 to view all of your Habits");
                Console.WriteLine("Enter 0 to Exit");
                Console.Write("Enter your choice: ");
                int input = Convert.ToInt16(Console.ReadLine());
                int habitCount1 = 13;
                int habitCount2 = 7;

                if (input == 0)
                {
                    Console.WriteLine("Exiting the program...");
                    return;
                }
                else
                {
                    if (input == 1)
                    {
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("- Reading Manhwa -");
                        Console.WriteLine("Did you complete your habit for today? (y/n)");
                        string answer1 = Console.ReadLine();
                        if (answer1 == "y")
                        {
                            Console.WriteLine("Great job! Keep it up!");
                            habitCount1 += 1;
                        }
                        else if (answer1 == "n")
                        {
                            Console.WriteLine("Don't worry, you can try again tomorrow!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Exiting now...");
                            return;
                        }

                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("- Meditating -");
                        Console.WriteLine("Did you complete your habit for today? (y/n)");
                        string answer2 = Console.ReadLine();
                        if (answer2 == "y")
                        {
                            Console.WriteLine("Great job! Keep it up!");
                            habitCount2 += 1;                            
                        }
                        else if (answer2 == "n")
                        {
                            Console.WriteLine("Don't worry, you can try again tomorrow!");                         
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Exiting now...");
                            return;
                        }
                    }
                    else if (input == 2)
                    {
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Working in Progress, Sorry for the Inconvenience");
                    }
                    else if (input == 3)
                    {
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("- Streak of your Listed Habits -");
                        Console.WriteLine($"Reading Manhwa: {habitCount1}");
                        Console.WriteLine($"Meditating: {habitCount2}");
                        Console.WriteLine("...");

                        Console.WriteLine("Type 0 to Exit");
                        Console.WriteLine("Type R to Return");
                        Console.Write("Enter what you want to do: ");
                        string input2 = Console.ReadLine();
                        if (input2 == "R")
                        {
                            Console.WriteLine("Returning to the main menu...");
                        }
                        else if (input2 == "0")
                        {
                            Console.WriteLine("Exiting the program...");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Exiting now...");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Exiting now...");
                        return;
                    }
                }
            }
        }
    }
}