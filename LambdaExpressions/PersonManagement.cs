﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class PersonManagement
    {
        List<Person> personList = new List<Person>();
        public void AddData()
        {
            //UC1
            personList.Add(new Person { SSN = 1, Name = "Sunny", Address = "Madhya", Age = 20 });
            personList.Add(new Person { SSN = 2, Name = "Halex", Address = "Utter",  Age = 31 });
            personList.Add(new Person { SSN = 3, Name = "Harsh", Address = "Punjab", Age = 70 });
            personList.Add(new Person { SSN = 4, Name = "Alexx", Address = "Andra",  Age = 70 });
            personList.Add(new Person { SSN = 5, Name = "Games", Address = "Bhopal", Age = 24 });
            personList.Add(new Person { SSN = 6, Name = "Ramon", Address = "Karela", Age = 26 });
            personList.Add(new Person { SSN = 7, Name = "Mannu", Address = "Tamil",  Age = 65 });
            personList.Add(new Person { SSN = 8, Name = "Sunil", Address = "Mumbai", Age = 16 });
            Display(personList);
        }
        public void Display(IEnumerable<Person> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine(person.SSN + ". " + person.Name + ", " + person.Address + ", " + person.Age);
            }
        }
    }
}