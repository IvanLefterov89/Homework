using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var student = new Student();
            List<Student> students = new List<Student>();
           
            for (int i = 0; i < n; i++)
             {
                string[] command = Console.ReadLine().Split();
                student.FirstName = command[0];
                student.LastName = command[1];
                student.grade = double.Parse(command[2]);

                students.Add(new Student { FirstName = student.FirstName, LastName = student.LastName, grade = student.grade });             
            }            

           var result= students.OrderByDescending(x => x.grade).ToList();

            foreach (var item in result)
            {
               Console.WriteLine(item);
           }
        }
    }

     class Student // syzdavane na klas
    {

        public string FirstName { get; set; }  // syzdavane na properties
        public string LastName { get; set; }// syzdavane na properties
        public double grade { get; set; }// syzdavane na properties


        public override string ToString()
        {
            return $"{FirstName} {LastName}: {grade:F2}";
        }
    }
}
