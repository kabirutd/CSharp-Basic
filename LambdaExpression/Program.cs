using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    /*
     RESOURCES:
        https://www.dotnetperls.com/lambda

        https://www.codeproject.com/Tips/298963/Understand-Lambda-Expressions-in-Minutes

     */
    class Program
    {
        delegate bool IsYoungerThan(Student stud, int youngAge);
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            IsYoungerThan isYoungerThan = (s, youngAge) =>
            {
                Console.WriteLine("Lambda expression with multiple line in the body");
                return s.Age < youngAge;


            };

            Student stud = new Student() { Age = 25 };
           // Console.WriteLine(isYoungerThan(stud, 28));

            //IsYoungerThan isYoungerThan2;

            //isYoungerThan2 = (Student s, int youngAge) => s.Age >= youngage;

            //Console.WriteLine 
            IsEvenNumber();
        }

        static void IsEvenNumber()
        {

            //return List<int> evenNumbers = numlist.where(n => n % 2 == 1).ToList();
            List<int> numbers = new List<int> { 11, 37, 52, 23, 42, 18}; //numlist; // new List<int> { 11, 37, 52 };
            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            //Console.WriteLine(numbers);
            Console.WriteLine("Numbers are: ");
            foreach (int number in numbers)
            {
               
                Console.WriteLine(number);
            }

            Console.WriteLine("Even Numbers are: ");
            foreach  (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public class Student
        {

            public int Id { get; set; }
            public string name { get; set; }
            public int Age { get; set; }
                

        }
    }
}
