using System;

namespace Task1
{
    public class Employee : User
    {
        private int _workExperience;
        private string _position;

        public int WorkExperience
        {
            get
            {
                return _workExperience;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(WorkExperience)} cannot be less than zero");
                }
                _workExperience = value;
            }
        }

        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Position)} cannot be null");
                }
                _position = value;
            }
        }

        public Employee(
            string surname,
            string name,
            string middleName,
            DateTime birthDate,
            int workExperience,
            string position) : base(surname, name, middleName, birthDate)
        {
            WorkExperience = workExperience;
            Position = position;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, work experience: {WorkExperience}, position: {Position}";
        }
    }
}
