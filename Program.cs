using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{

    class SuperVirus : Task5.Virus
    {
        public SuperVirus() : base (false)
        {
            m_DateTimeCreated = DateTime.Now;
        }

        public override float KillProbability 
        { 
            get { return m_KillProbability; }
            set { m_KillProbability = value * 2.0f > 1.0f ? 1.0f : value * 2.0f; } 
        }
        public override string Name 
        {
            get { return m_Name; }
            set { m_Name = value.Replace("virus", "supervirus"); } 
        }
        public override string VictimName 
        {
            get;
            set;
        }

        public override DateTime DateTimeOfCreation 
        {
            get { return m_DateTimeCreated; }
        }

        private DateTime m_DateTimeCreated;
        private float m_KillProbability;
        private string m_Name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Func<Task5, Task5.Virus> TaskSolver = task =>
            {
                Task5.Virus virus = new SuperVirus();
                return virus;
            };
            Task5.CheckSolver(TaskSolver);
        }
    }
}
