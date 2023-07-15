using System;

class EternalQuestProgram
        {
        private List<Goal> goals;
        private int score;

        public EternalQuestProgram()
        {
            goals = new List<Goal>();
            score = 0;
        }

        public void CreateGoal(string goalType, string name, int value, int targetCount = 0)
        {
            Goal goal;
            switch (goalType.ToLower())
            {
                case "simple":
                    goal = new SimpleGoal(name, value);
                    break;
                case "eternal":
                    goal = new EternalGoal(name, value);
                    break;
                case "checklist":
                    goal = new ChecklistGoal(name, value, targetCount);
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    return;
            }
            goals.Add(goal);
        }

        public void RecordEvent(int goalIndex)
        {
            if (goalIndex >= 0 && goalIndex < goals.Count)
            {
                int pointsEarned = goals[goalIndex].RecordEvent();
                score += pointsEarned;
                Console.WriteLine($"You earned {pointsEarned} points!");
            }
            else
            {
                Console.WriteLine("Invalid goal index.");
            }
        }

        public void DisplayGoals()
        {
            Console.WriteLine("Goals:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i}. {goals[i].DisplayProgress()}");
            }
        }

        public void DisplayScore()
        {
            Console.WriteLine($"Your score: {score} points");
        }
    }