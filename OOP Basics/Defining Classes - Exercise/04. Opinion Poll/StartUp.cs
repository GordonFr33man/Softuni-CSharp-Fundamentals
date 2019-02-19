﻿using System;
using System.Linq;
using System.Reflection;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var age = int.Parse(input[1]);
                if (age > 30)
                {
                    Person person = new Person(name, age);
                    family.AddMember(person);
                }
            }

            foreach (var person in family.People.OrderBy(x => x.Name))
            {
                var name = person.Name;
                var age = person.Age;
                Console.WriteLine($"{name} - {age}");
            }
        }
    }
}
