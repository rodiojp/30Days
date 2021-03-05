using System;

namespace PersonLib
{
    public interface ISalariable
    {
        decimal Salary { get; }
        void PaySalary();
    }
}