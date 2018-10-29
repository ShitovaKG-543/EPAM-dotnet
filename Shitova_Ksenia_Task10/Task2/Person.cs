using System;

namespace Task2
{
    public delegate void PersonDelegateCame(Person person, DateTime time);
    public delegate void PersonDelegateWalkedAway(Person person);
    public class Person
    {
        public event PersonDelegateCame Came; 
        public event PersonDelegateWalkedAway WalkedAway;


        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void SayHi(Person person, DateTime time)
        {
            if (time.Hour < 12)
            {
                Console.WriteLine($"Good morning, {person.Name}!, - said {this.Name}.");
            }
            else if (time.Hour >= 17)
            {
                Console.WriteLine($"Good evening, {person.Name}!, - said {this.Name}.");
            }
            else
            {
                Console.WriteLine($"Good day, {person.Name}!, - said {this.Name}.");
            }
        }

        public void SayBye(Person person)
        {
            Console.WriteLine($"Goodbye, {person.Name}!, - said {this.Name}.");
        }

        public void OnCome()
        {
            Came?.Invoke(this, DateTime.Now);
        }

        public void OnWalkAway()
        {
            WalkedAway?.Invoke(this);
        }
    }
}
