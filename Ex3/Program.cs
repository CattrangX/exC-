using System;
using System.Collections.Generic;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Age: {Age}";
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { ID = 1, Name = "Nhan", Age = 20 },
            new Student { ID = 2, Name = "Tu", Age = 22 },
            new Student { ID = 3, Name = "Loi", Age = 40 }
        };

        students.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));

        Console.WriteLine("danh sach sau khi sap xep: ");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}
