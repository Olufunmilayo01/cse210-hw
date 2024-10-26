class NegativeGoal : Goal
    {
        public NegativeGoal(string name, int points) : base(name, points) { }

        public override int RecordEvent() => -Points; // Deduct points when recorded

        public override bool IsComplete() => false;

        public override string GetDetails()
        {
            return $"{Name} - [Penalty] (-{Points} pts each time)";
        }
    }