using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02.Encapsulation
{
    internal struct Employee
    {
        #region Atributes

        //public int Id;
        //private string EmpName;
        //private decimal Empsalary;
        #endregion

        // Encapsulation Separate Data Definition [Attributes]
        // From Its Use [Getter Setter)— [Property]

        #region 1. Apply Encapsulation [Getter Setter]
        //// a. Private Att
        ////B. two funcs Getter _ Setter

        ////Getter 
        //public string GetName()
        //{
        //    return EmpName;
        //}
        ////Setter
        //public void setName(string? value)
        //{
        //    EmpName = value?.Length >5 ? value.Substring(0 , 5) : value;

        //}
        #endregion

        #region 2. Apply Encapsulation [Property]
        ////1.Full
        ////2.Automatic
        ////3.Indexer

        //public decimal Salary
        //{
        //    get { return Empsalary; }
        //    set { Empsalary = value < 5000 ? 5000 : value; }
        //}


        ////Full Property 
        ////private int age;
        ////public int Age
        ////{
        ////    get { return age; }
        ////    set { age = value; }
        ////}

        ////public int Age;//Attr

        ////Automatic
        //public int Age { get; set; } //Property
        //                             //Compiler will Generate Hidden Private Attr [Backing Field]

        //// Full Property >> PropFull

        ////Automatic Property>> Prop
        //// public string Test { get; set; }

        ////private decimal deduction; //[Derived Attr]

        //public decimal Deduction //ReadOnly
        //{
        //    get { return Salary * 0.2M; }

        //}



        #endregion


        #region Constructors
        //public Employee(int id, string name, decimal salary ,int age)
        //{
        //    Id = id;
        //    EmpName = name;
        //    this.Empsalary = salary;
        //    Age = age;
        //}
        #endregion

        #region Methods
        //public override string ToString()
        //{
        //    return $"Id = {Id}\nName = {EmpName}\nSalary = {Empsalary:c}\nAge = {Age}";
        //}
        #endregion



    }
}
