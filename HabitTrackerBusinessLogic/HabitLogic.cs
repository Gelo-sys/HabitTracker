namespace HabitTracker
{
    public class HabitLogic
    {
        private HabitJsonDataService habitService = new HabitJsonDataService();

        public List<Habit> GetAllHabits()
        {
            return habitService.GetAllHabits();
        }

        public bool AddHabit(string name)
        {
            bool exists = habitService.GetAllHabits().Any(h => h.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (exists)
            {
                return false;
            }

            habitService.AddHabit(name);
            return true;
        }

        public void UpdateStreak(string name, int newStreak)
        {
            habitService.UpdateStreak(name, newStreak);
        }
    }
}