class ChecklistGoal : Goal
    {
        private int _requiredCount;
        private int _completedCount;
        private int _bonusPoints;

        public ChecklistGoal(string name, int points, int requiredCount, int bonusPoints) : base(name, points)
        {
            _requiredCount = requiredCount;
            _bonusPoints = bonusPoints;
            _completedCount = 0;
        }

        public override int RecordEvent()
        {
            if (_completedCount < _requiredCount)
            {
                _completedCount++;
                if (_completedCount == _requiredCount)
                    return Points + _bonusPoints; // Add bonus if goal is completed
                else
                    return Points;
            }
            return 0;
        }

        public override bool IsComplete() => _completedCount >= _requiredCount;

        public override string GetDetails()
        {
            return $"{Name} - [{_completedCount}/{_requiredCount}] ({Points} pts, +{_bonusPoints} bonus)";
        }
    }