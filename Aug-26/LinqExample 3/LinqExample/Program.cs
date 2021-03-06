﻿using College;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        static void Main()
        {
            //create collection of objects
            List<Student> students = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "Scott", Location = "Hyderabad", Branch = BranchOfStudent.IT },
                new Student() { StudentID = 2, StudentName = "Smith", Location = "London", Branch = BranchOfStudent.CSE },
                new Student() { StudentID = 3, StudentName = "Jones", Location = "Hyderabad", Branch = BranchOfStudent.IT },
                new Student() { StudentID = 4, StudentName = "Anna", Location = "London", Branch = BranchOfStudent.CSE },
                new Student() { StudentID = 5, StudentName = "Rahul", Location = "Hyderabad", Branch = BranchOfStudent.CSE },
                new Student() { StudentID = 6, StudentName = "David", Location = "Chennai", Branch = BranchOfStudent.IT }
            };

            //LINQ: Reverse
            students = ((IEnumerable<Student>)students).Reverse().ToList();

            foreach (var item in students)
            {
                Console.WriteLine(item.StudentID + ", " + item.StudentName + ", " + item.Location + ", " + item.Branch);
            }

            Console.ReadKey();
        }
    }
}

