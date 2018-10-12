using System;

namespace Task1
{
    public class User
    {
        private string _surname;
        private string _name;
        private string _middleName;
        private DateTime _birthDate;
        private int _age;

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException($"{nameof(Surname)} cannot be null");
                }
                _surname = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be null");
                }
                _name = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return _middleName;
            }
            set
            {
                _middleName = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }

            set
            {
                if (value == null || !(value > new DateTime(1950, 1, 1) && value < DateTime.Now))
                {
                    throw new ArgumentException($"{nameof(BirthDate)} cannot be null or less than {new DateTime(1950, 1, 1)} and more than {DateTime.Now}");
                }
                _birthDate = value;
            }
        }

        public int Age
        {
            get
            {

                DateTime dateNow = DateTime.Now;
                int age = dateNow.Year - BirthDate.Year;
                if ((BirthDate.Month > dateNow.Month) || (BirthDate.Month == dateNow.Month && BirthDate.Day > dateNow.Day))
                {
                    return age - 1;
                }
                else
                {
                    return age;
                }

            }
        }

        public User(string surname, string name, string middleName, DateTime birthDate)
        {
            Surname = surname;
            Name = name;
            MiddleName = middleName;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"Surname: {Surname}, name: {Name}, middle name: {MiddleName}, birth date: {BirthDate.ToString("d")}, age: {Age}";
        }
    }
}
