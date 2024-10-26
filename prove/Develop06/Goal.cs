using System;
using System.Collections.Generic;
using System.IO;

// namespace EternalQuestProgram
// {
    // Base Class: Goal
    abstract class Goal
    {
        protected string Name;
        protected int Points;

        public Goal(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public abstract int RecordEvent(); // Abstract to enforce implementation in derived classes
        public abstract bool IsComplete();
        public abstract string GetDetails();
    }
// }