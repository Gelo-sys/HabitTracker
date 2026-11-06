using System.Text.Json;
using HabitTracker;

namespace HabitTracker
{
    public class HabitJsonDataService
    {
        private List<Habit> habits = new List<Habit>();
        private readonly string jsonFilePath;

        public HabitJsonDataService()
        {
            jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Habit.json");

            if (!File.Exists(jsonFilePath))
            {
                File.WriteAllText(jsonFilePath, "[]");
            }

            LoadFromJson();
        }

        private void LoadFromJson()
        {
            string content = File.ReadAllText(jsonFilePath);
            habits = JsonSerializer.Deserialize<List<Habit>>(content) ?? new List<Habit>();
        }

        private void SaveToJson()
        {
            string content = JsonSerializer.Serialize(habits, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonFilePath, content);
        }

        public List<Habit> GetAllHabits()
        {
            return habits;
        }

        public void AddHabit(string name)
        {
            habits.Add(new Habit { Name = name, Streak = 0 });
            SaveToJson();
        }

        public void UpdateStreak(string name, int newStreak)
        {
            Habit habit = habits.FirstOrDefault(h => h.Name == name);
            if (habit != null)
            {
                habit.Streak = newStreak;
                SaveToJson();
            }
        }
    }
}