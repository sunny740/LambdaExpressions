using System;
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
                //Console.WriteLine(person.SSN + ". " + person.Name + ", " + person.Address + ", " + person.Age);
                Console.WriteLine("Persons Data : {0}, {1}, {2}, {3}", person.SSN, person.Name, person.Address, person.Age);                
            }
        }
        public void GetRecords()
        {
            
            Console.WriteLine("\nUC2 - Retrieve top 2 records from the list for age is less than 60");
            var Result = this.personList.FindAll(x => x.Age < 60).Take(2);
            Display(Result);
        }
        public void GetAgeRecords()
        {
            //Console.WriteLine();
            Console.WriteLine("\nUC3 - Retrieve all record from the list for age between 13 to 18");
            var result = this.personList.FindAll(x => x.Age > 13 && x.Age < 18);
            Display(result);
        }
        public void AgeRecords()
        {
            Console.WriteLine("\nUC4 - Retrieve average age in the list");
            var Result = this.personList.Average(x => x.Age);
            //Console.WriteLine(Result);
            Console.WriteLine("The average age of all guys is: " + Result);
        }
        public void FindValue()
        {
            Console.WriteLine("\nUC5 - Check for specific name present in the list or not") ;
            var result = this.personList.Where(x => x.Name == "Sunny");
            if (result != null)
            {
                Console.WriteLine("Name Is Present In List");
            }
            else
            {
                Console.WriteLine("Name Is Not Present In List");
            }
            Display(result);
        }
        public void SkipRecords()
        {
            Console.WriteLine("\nUC6 - Skip record from the list for age is less than 60");
            var Result = this.personList.Skip(this.personList.Where(x => x.Age < 60).Count());
            Display(Result);
        }
    }
}
