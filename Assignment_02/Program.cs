
using System;
using System.Globalization;


namespace Assignment_02
{
    #region Part 01 1.Try all what we have learned in the lecture.

    // IN Demo
    #endregion


    //PART 02

    #region 1.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

    //    struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Person(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Person[] persons = new Person[3];
    //        persons[0] = new Person("Alice", 30);
    //        persons[1] = new Person("Bob", 25);
    //        persons[2] = new Person("Charlie", 35);

    //        foreach (Person person in persons)
    //        {
    //            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    //        }
    //    }
    //}
    #endregion

    #region 2 Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

    //struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Person(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Person[] persons = new Person[3];

    //        for (int i = 0; i < 3; i++)
    //        {
    //            Console.Write("Enter Name: ");
    //            string name = Console.ReadLine();
    //            Console.Write("Enter Age: ");
    //            int age = int.Parse(Console.ReadLine());

    //            persons[i] = new Person(name, age);
    //        }

    //        Person oldest = persons[0];

    //        foreach (Person person in persons)
    //        {
    //            if (person.Age > oldest.Age)
    //            {
    //                oldest = person;
    //            }
    //        }

    //        Console.WriteLine($"The oldest person is {oldest.Name} with {oldest.Age} years.");
    //    }
    //}

    #endregion


    //PART 03

    #region  Design and implement a Class for the employees in a company.

    //public enum SecurityLevel
    //{
    //    Guest,
    //    Developer,
    //    Secretary,
    //    DBA,
    //    SecurityOfficer
    //}

    //public struct HiringDate
    //{
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }

    //    public HiringDate(int day, int month, int year)
    //    {
    //        Day = day;
    //        Month = month;
    //        Year = year;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Day:00}/{Month:00}/{Year:0000}";
    //    }
    //}

    //public class Employee
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public SecurityLevel SecurityLevel { get; set; }
    //    public decimal Salary { get; set; }
    //    public HiringDate HireDate { get ; set; }
    //    private char gender;
    //    public char Gender
    //    {
    //        get { return gender; }
    //        set
    //        {
    //            if (value == 'M' || value == 'F')
    //            {
    //                gender = value;
    //            }
    //            else
    //            {
    //                throw new ArgumentException("Gender must be either 'M' or 'F'");
    //            }
    //        }
    //    }

    //    public Employee(int id , string name , SecurityLevel securityLevel , decimal salary , HiringDate hireDate , char gender)
    //    {
    //        ID = id;
    //        Name = name;
    //        SecurityLevel = securityLevel;
    //        Salary = salary;
    //        HireDate = hireDate;
    //        Gender = gender;
    //    }

    //    public override string ToString()
    //    {
    //        return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary.ToString("C", CultureInfo.CurrentCulture)}, Hire Date: {HireDate}, Gender: {Gender}";
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Employee[] employees = new Employee[3];
    //        employees[0] = new Employee(1, "Alice" , SecurityLevel.DBA , 60000 , new HiringDate(12 , 5 , 2018) , 'F');
    //        employees[1] = new Employee(2, "Bob" , SecurityLevel.Guest , 40000 , new HiringDate(23 , 8 , 2019) , 'M');
    //        employees[2] = new Employee(3, "Charlie" , SecurityLevel.SecurityOfficer , 80000 , new HiringDate(15 , 3 , 2017) , 'M');

    //        Array.Sort(employees , (e1 , e2) => (e1.HireDate.Year , e1.HireDate.Month , e1.HireDate.Day).CompareTo((e2.HireDate.Year , e2.HireDate.Month , e2.HireDate.Day)));

    //        foreach (var employee in employees)
    //        {
    //            Console.WriteLine(employee);
    //        }

             
    //    }
    //}
    #endregion

}

