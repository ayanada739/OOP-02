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

        private int Id;
        private string EmpName;
        private decimal Salary;
        #endregion

        // Encapsulation Separate Data Definition [Attributes]
        // From Its Use [Getter Setter)— [Property]

        #region 1. Apply Encapsulation [Getter Setter]
        // a. Private Att
        //B. two funcs Getter _ Setter

        //Getter 
        public string GetName()
        {
            return EmpName;
        }
        //Setter
        public void setName(string? value)
        {
            EmpName = value?.Length >5 ? value.Substring(0 , 5) : value;

        }
        #endregion

        #region MyRegion

        #endregion


        #region Constructors
        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            EmpName = name;
            Salary = salary;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id = {Id}\nName = {EmpName}\nSalary = {Salary:c}";
        }
        #endregion



    }
}
