class EternalGoal : Goal
    {
        public EternalGoal(string name, int points) : base(name, points) { }

        public override int RecordEvent() => Points;

        public override bool IsComplete() => false; // Never complete

        public override string GetDetails()
        {
            return $"{Name} - [∞] ({Points} pts each time)";
        }
    }