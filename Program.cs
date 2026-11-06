namespace HabitTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HabitLogic habitLogic = new HabitLogic();

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

                if (input == 0)
                {
                    Console.WriteLine("Exiting the program...");
                    return;
                }

                switch (input)
                {
                    case 1:
                        LoginForTheDay(habitLogic);
                        break;
                    case 2:
                        AddNewHabit(habitLogic);
                        break;
                    case 3:
                        ViewAllHabits(habitLogic);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Exiting now...");
                        return;
                }
            }
        }

        static void LoginForTheDay(HabitLogic habitLogic)
        {
            List<Habit> habits = habitLogic.GetAllHabits();

            foreach (Habit habit in habits)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"- {habit.Name} -");
                Console.WriteLine("Did you complete your habit for today? (y/n)");
                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    Console.WriteLine("Great job! Keep it up!");
                    habitLogic.UpdateStreak(habit.Name, habit.Streak + 1);
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Don't worry, you can try again tomorrow!");
                }
                else
                {
                    Console.WriteLine("Invalid input. Skipping this habit...");
                }
            }
        }

        static void AddNewHabit(HabitLogic habitLogic)
        {
            Console.Write("Enter the name of the new habit: ");
            string name = Console.ReadLine();
            bool added = habitLogic.AddHabit(name);

            if (added)
            {
                Console.WriteLine("Habit added!");
            }
            else
            {
                Console.WriteLine("That habit already exists.");
            }
        }

        static void ViewAllHabits(HabitLogic habitLogic)
        {
            List<Habit> habits = habitLogic.GetAllHabits();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("- Streak of your Listed Habits -");

            foreach (Habit habit in habits)
            {
                Console.WriteLine($"{habit.Name}: {habit.Streak}");
            }
        }
    }
}