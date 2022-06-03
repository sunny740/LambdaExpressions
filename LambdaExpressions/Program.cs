using System;

namespace LambdaExpressions

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ***** Welcome To Lambda Expressions *****\n ");
            PersonManagement management = new PersonManagement();
            management.AddData();
            management.GetRecords();
            management.GetAgeRecords();
            management.AgeRecords();
        }
    }
}