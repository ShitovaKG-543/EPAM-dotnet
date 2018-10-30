using System;

namespace Task2
{
    public class Employee : User, IEquatable<Employee>
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

        ////////
        public bool Equals(Employee other)
        {
            if (other == null)
            {
                throw new Exception("employee can not be null");
            }
            return Surname.Equals(other.Surname) &&
                Name.Equals(other.Name) &&
                MiddleName.Equals(other.MiddleName) &&
                BirthDate.Equals(other.BirthDate) &&
                WorkExperience.Equals(other.WorkExperience) &&
                Position.Equals(other.Position);
        }
    }
}
