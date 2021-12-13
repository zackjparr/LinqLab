using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 10, 2330, 112233, 10, 949, 3764, 2942 };

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            //nums
            //1 max value
            double minNum = nums.Min();
            Console.WriteLine($"Min Number: {minNum}");

            //2 min value
            double maxNum = nums.Max();
            Console.WriteLine($"Max Number: {maxNum}");

            //3 max value less than 10000
            double maxLessThan10000 = nums.Where(n => n <= 10000).Max();
            Console.WriteLine($"Max Value Less Than 10000: {maxLessThan10000}");
            Console.WriteLine();

            //4 all nums between 10 and 100
            List<int> numsInRange = nums.Where(x => x >= 10 && x <= 100).ToList();
            Console.WriteLine("Nums Between 10 and 100:");
            foreach (int num in numsInRange)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //5 all the Values between 100000 and 999999 inclusive
            List<int> numsInRange2 = nums.Where(x => x >= 100000 && x <= 999999).ToList();
            Console.WriteLine("Nums Between 100000 and 999999:");
            foreach (int num in numsInRange2)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //6 count all the even numbers
            List<int> evens = nums.Where(n => n % 2 == 0).ToList();
            //Console.WriteLine("Method Syntax for finding odds");
            //foreach (int even in evens)
            //{
            //    Console.WriteLine(even);
            //}
            Console.WriteLine("Number of evens: " + evens.Count());

            ////////////////////////////////////////////

            //7 find all students age of 21 and over
            List<Student> students21 = students.Where(x => x.Age >= 21).ToList();
            foreach(Student s in students21)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();

            //8 find oldest student
            int oldestAge = students.Max(x => x.Age);
            List<Student> oldestStudent = students.Where(x => x.Age == oldestAge).ToList();
            Console.WriteLine("Oldest Student(s):");
            foreach (Student s in oldestStudent)
            {
                Console.WriteLine($"{s.Name}");
            }
            Console.WriteLine();

            //9 find youngest student
            int youngestAge = students.Min(x => x.Age);
            List<Student> youngestStudent = students.Where(x => x.Age == youngestAge).ToList();
            Console.WriteLine("Youngest Student(s):");
            foreach (Student s in youngestStudent)
            {
                Console.WriteLine($"{s.Name}");
            }
            Console.WriteLine();

            //10 find oldest student under age of 25
            Console.WriteLine("Oldest Student Under 25:");
            List<Student> under25 = students.Where(x => x.Age < 25).ToList();
            int oldestUnder25 = under25.Max(x => x.Age);
            Console.WriteLine($"{(under25.Where(x => x.Age == oldestUnder25).First()).Name} " +
                $"\nAge: {(under25.Where(x => x.Age == oldestUnder25).First()).Age}");
            //foreach (Student s in oldestUnder25)
            //{
            //    Console.WriteLine($"{s.Name}");
            //}
            Console.WriteLine();


            //11 find all students over 21 with even ages
            Console.WriteLine("Even and Over 21:");
            List<Student> over21 = students.Where(x => x.Age >= 21).ToList();
            List<Student> evenAndOver21 = students.Where(x => x.Age % 2 == 0).ToList();
            foreach (Student s in evenAndOver21)
            {
                Console.WriteLine($"{s.Name}");
            }
            Console.WriteLine();

            //12 find all teenage students 13-19
            Console.WriteLine("All Teenage Students 13-19:");
            List<Student> between13and19 = students.Where(x => x.Age >= 13 && x.Age <= 19).ToList();
            foreach (Student s in between13and19)
            {
                Console.WriteLine($"{s.Name}");
            }
            Console.WriteLine();

            //13 all students whose name starts with a vowel
            Console.WriteLine("Vowel Students:");
            List<Student> vowelStudents = students.Where(x => x.Name.StartsWith("A") 
            || x.Name.StartsWith("E") || x.Name.StartsWith("I") 
            || x.Name.StartsWith("O") || x.Name.StartsWith("U")).ToList();
            foreach (Student s in vowelStudents)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
