using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjectsTask
{
    public class Employee
    {
        private string surname;
        private int age;

        public Employee() 
        {
        }

        public Employee(string surname, int age)
        {
            this.surname = surname;
            this.age = age;
        }

        public void ChangeSurname(string updateSurname)
        {
            this.surname = updateSurname;
        }

        public string EmployeeInfo() => $"Surname: {this.surname}, Age: {this.age}";

        private string GetAge() => this.age.ToString();
    }
}
