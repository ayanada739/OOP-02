
using System;


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

}

