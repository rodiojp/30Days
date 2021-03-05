using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonLib;
using System;
using System.Diagnostics;

namespace EmployeeLibTest
{
    [TestClass]
    public class EmployeeType
    {

        [TestMethod]
        [DataRow("John", "Doe", EmployeePosition.Manager, 5000)]
        public void EmployeeToStringTest(string firstName, string lastName, EmployeePosition position, double salary)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\" position =\"{position}\" salary ={salary}");
            Employee p = new Employee(firstName, lastName, position, Convert.ToDecimal(salary));
            Trace.WriteLine($"p.ToString() = \"{p.ToString()}\" p.FirstName = \"{p.FirstName}\" p.LastName = \"{p.LastName}\" p.Position =\"{p.Position}\" p.Salary ={p.Salary}");
            Assert.IsTrue(p.ToString() == $"{firstName} {lastName}, {position}",
                       $"Expected for p.ToString() == \"{firstName} {lastName}, {position}\", Actual = \"{p.FirstName} {p.LastName}, {p.Position}\"");
        }

        [TestMethod]
        [DataRow("John", "Doe", EmployeePosition.Manager, 5000)]
        public void SayHelloToEmployeeTest(string firstName, string lastName, EmployeePosition position, double salary)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\" position =\"{position}\" salary ={salary}");
            Employee p = new Employee(firstName, lastName, position, Convert.ToDecimal(salary));
            Trace.WriteLine($"p.ToString() = \"{p.ToString()}\" p.FirstName = \"{p.FirstName}\" p.LastName = \"{p.LastName}\" p.Position =\"{p.Position}\" p.Salary ={p.Salary}");
            Assert.IsTrue(Employee.SayHello(p) == $"Hi. How may I help you, {p}?",
            $"Expected for Employee.SayHello(p) == \"Hi. How may I help you, {p}?\"");
        }
        [TestMethod]
        [DataRow(null)]
        [ExpectedException(typeof(ArgumentNullException), "A ArgumentNullException was inappropriately handled.")]
        public void SayHelloToNullEmployeeTest(Employee p)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"Employee = \"{p}\"");
            Employee.SayHello(p);
        }

        [TestMethod]
        [DataRow("John", "Josh", "Jeremy")]
        public void SayHelloToStringParamsTest(params string[] names)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"names = \"{string.Join(", ", names)}\"");
            Trace.WriteLine($"Employee.SayHello(names) = \"{Employee.SayHello(names)}\"");
            Assert.IsTrue(Employee.SayHello(names) == $"Hello, {string.Join(", ", names)}!",
                       $"Expected for Employee.SayHello(names) == \"Hello, {string.Join(", ", names)}!\"");
        }

        [TestMethod]
        [DataRow(null)]
        public void SayHelloToStringParamsNullTest(params string[] names)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"names = \"{string.Join(", ", names)}\"");
            Trace.WriteLine($"Employee.SayHello(names) = \"{Employee.SayHello(names)}\"");
            Assert.IsTrue(Employee.SayHello(names) == $"Hello!",
                       $"Expected for Employee.SayHello(names) == \"Hello, {string.Join(", ", names)}!\"");
        }

        [TestMethod]
        [DataRow("John", "Doe", EmployeePosition.Manager, 5000)]
        public void FirstNameAndLastNameMatchTest(string firstName, string lastName, EmployeePosition position, double salary)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\" position =\"{position}\" salary ={salary}");
            Employee p = new Employee(firstName, lastName, position, Convert.ToDecimal(salary));
            Trace.WriteLine($"p.ToString() = \"{p.ToString()}\" p.FirstName = \"{p.FirstName}\" p.LastName = \"{p.LastName}\" p.Position =\"{p.Position}\" p.Salary ={p.Salary}");

            Assert.IsTrue(p.FirstName == firstName,
                       $"Expected for p.FirstName == \"{firstName}\", Actual = \"{p.FirstName}\"");

            Assert.IsTrue(p.LastName == lastName,
                      $"Expected for p.LastName == \"{lastName}\", Actual = \"{p.LastName}\"");
        }

        [TestMethod]
        [DataRow("John", "  ", EmployeePosition.Manager, 0)]
        [DataRow("John", null, EmployeePosition.Manager, 0)]
        [DataRow(null, null, EmployeePosition.Manager, 0)]
        [DataRow(null, "  ", EmployeePosition.Manager, 0)]
        [DataRow(null, null, EmployeePosition.Manager, 0)]
        [DataRow("  ", "  ", EmployeePosition.Manager, 0)]
        [DataRow("  ", "  ", EmployeePosition.Manager, 0)]
        [DataRow("  ", null, EmployeePosition.Manager, 0)]
        [DataRow("", "", EmployeePosition.Manager, 0)]
        [DataRow("", "  ", EmployeePosition.Manager, 0)]
        [DataRow("", null, EmployeePosition.Manager, 0)]
        [ExpectedException(typeof(ArgumentNullException), "A ArgumentNullException was inappropriately handled.")]
        public void ConstructorExceptionTest(string firstName, string lastName, EmployeePosition position, double salary)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\" position =\"{position}\" salary ={salary}");
            Employee p = new Employee(firstName, lastName, position, Convert.ToDecimal(salary));
            Trace.WriteLine($"p.ToString() = \"{p.ToString()}\" p.FirstName = \"{p.FirstName}\" p.LastName = \"{p.LastName}\" p.Position =\"{p.Position}\" p.Salary ={p.Salary}");
        }

    }
}
