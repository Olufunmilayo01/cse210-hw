class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;
        private int _level = 1;
        private const int PointsPerLevel = 1000; // Points needed to reach the next level

        public void AddGoal(Goal goal) => _goals.Add(goal);

        public void RecordGoalEvent(int goalIndex)
        {
            _score += _goals[goalIndex].RecordEvent();
            CheckForLevelUp();
        }

        private void CheckForLevelUp()
        {
            if (_score >= _level * PointsPerLevel)
            {
                _level++;
                Console.WriteLine($"Congratulations! You've reached Level {_level}! You've earned a reward badge.");
                // Optional: add extra points or special rewards for leveling up
                _score += 50; // Reward points for leveling up
            }
        }

        public void DisplayGoals()
        {
            Console.WriteLine("Goals:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
            }
            Console.WriteLine($"Score: {_score}");
            Console.WriteLine($"Level: {_level}");
        }

        public void SaveGoals(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);
                writer.WriteLine(_level); // Save level
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetDetails()); // Simplified save
                }
            }
        }

        public void LoadGoals(string filename)
        {
            if (File.Exists(filename))
            {
                _goals.Clear();
                using (StreamReader reader = new StreamReader(filename))
                {
                    _score = int.Parse(reader.ReadLine() ?? "0");
                    _level = int.Parse(reader.ReadLine() ?? "1");
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Logic to recreate goals would go here
                    }
                }
            }
        }
    }