using System;

namespace MoshDbMigrator.Models.Repository
{
    public class Person
    {
        public string Name { get; private set; }
        public DateTime Birthdate { get; private set; }
        public string Lastname { get; private set; }


        public Person(string name,  string lastname, DateTime birthdate)
        {
            Name = name;
            Birthdate = birthdate;
            Lastname = lastname;
        }

        public string GetFullanme() 
        {
            return $"{Name} {Lastname}";
        }

        public int GetAge() 
        {
            var result = DateTime.Now - Birthdate;
            var years = result.Days / 365;
            return years;
        }
    }
}
