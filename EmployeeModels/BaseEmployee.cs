using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeModels
{
    public class BaseEmployee : IEmployee
    {
        private int _salary;
        private string _fisrtName, _lastName;
        public string Name { get => GetType().Name; }
        public string FisrtName
        {
            get
            {
                return _fisrtName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException(FisrtName);
                else
                    _fisrtName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException(LastName);
                else
                    _lastName = value;
            }
        }
        public int Salary
        {
            get
            {
                return GetSalary();
            }
            set
            {
                if (value >= 0)
                    _salary = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(_salary));
            }
        }

        protected virtual int GetSalary()
        {
            return _salary;
        }
        public void ToConsole()
        {
            Console.WriteLine(String.Format("{0} {1} salary is", _fisrtName, _lastName, _salary));
        }
    }
}
