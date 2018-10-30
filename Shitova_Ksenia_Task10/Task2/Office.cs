using System;
using System.Collections.Generic;

namespace Task2
{
    class Office
    {
        private List<Person> _persons { get; set; } = new List<Person>();

        public void Add(Person person)
        {
            Console.WriteLine($"[{person.Name} came to work]");
            foreach (var pers in _persons)
            {
                person.WalkedAway += pers.SayBye;
                pers.WalkedAway += person.SayBye;
                person.Came += pers.SayHi;
            }
            person.OnCome();
            _persons.Add(person);
        }

        public void Remove(Person person)
        {
            _persons.Remove(person);
            Console.WriteLine($"[{person.Name} went home]");
            person.OnWalkAway();
            foreach (var pers in _persons)
            {
                person.Came -= pers.SayHi;
                person.WalkedAway -= pers.SayBye;
                pers.WalkedAway -= person.SayBye;
            }
        }
    }
}
