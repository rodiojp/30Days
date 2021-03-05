using System;

namespace PersonLib
{
    public enum EmployeePosition {Manager, Owner, Salesman}
    public class Employee : Person, ISalariable, IFirable
    {

        public Employee(string firstName, string lastName, EmployeePosition position, decimal salary) : base(firstName, lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentNullException("lastName cannot be null empty or white space");
            if (salary < 1)
                throw new ArgumentNullException("salary cannot be less than 1");
            Position = position;
            _Salary = salary;
        }
        public EmployeePosition Position { get; protected set; }
        decimal _Salary;
        public decimal Salary => _Salary;

        public override string ToString()
        {
            return $"{base.ToString()}, {Position}, {Salary}";
        }
        public new static string SayHello(string name)
        {
            string greeting = "Hi. How may I help you";
            if (string.IsNullOrWhiteSpace(name))
                return $"{greeting}?";
            else
                return $"{greeting}, {name}?";
        }

        public static string SayHello(Employee toEmployee)
        {
            if (toEmployee == null) throw new ArgumentNullException("Employee cannot be null");
            return SayHello(toEmployee.ToString());
        }

        public void PaySalary()
        {
            //throw new NotImplementedException();
            // pay salary
        }

        public void Fire()
        {
            _Salary = 0;
        }
    }
}