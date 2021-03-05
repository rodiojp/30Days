using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonLib;
using System;
using System.Diagnostics;

namespace PersonLibTest
{
    [TestClass]
    public class PersonType
    {
        [TestMethod]
        [DataRow("John")]
        [DataRow("John", "")]
        public void LastNameIsEmptyTest(string firstName, string lastName = "")
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\"");
            Person p = new Person(firstName, lastName);
            Trace.WriteLine($"p.FirstName = \"{p.FirstName}\" p.LastName = \"{p.LastName}\"");
            Assert.IsTrue(p.LastName == string.Empty,
                       $"Expected for p.LastName == \"{string.Empty}\", Actual = \"{p.LastName}\"");

        }

        [TestMethod]
        [DataRow("John")]
        [DataRow("John", "Doe")]
        public void PersonToStringTest(string firstName, string lastName = "")
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\"");
            Person p = new Person(firstName, lastName);
            Trace.WriteLine($"p.ToString() = \"{p.ToString()}\" p.FirstName = \"{p.FirstName}\" p.LastName = \"{p.LastName}\"");
            if (string.IsNullOrWhiteSpace(lastName))
            {
                Trace.WriteLine("match firstName only");
                Assert.IsTrue(p.ToString() == firstName,
                $"Expected for p.FirstName == \"{firstName}\", Actual = \"{p.FirstName}\"");
            }
            else
            {
                Assert.IsTrue(p.ToString() == $"{firstName} {lastName}",
                           $"Expected for p.ToString() == \"{firstName} {lastName}\", Actual = \"{p.FirstName} {p.LastName}\"");
            }
        }

        [TestMethod]
        [DataRow("John")]
        [DataRow("John", "Doe")]
        public void SayHelloToPersonTest(string firstName, string lastName = "")
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\"");
            Person p = new Person(firstName, lastName);
            Trace.WriteLine($"Person.SayHello(p) = \"{Person.SayHello(p)}\" p.FirstName = \"{p.FirstName}\" p.LastName = \"{p.LastName}\"");
            Assert.IsTrue(Person.SayHello(p) == $"Hello, {p}!",
            $"Expected for Person.SayHello(p) == \"Hello, {p}!\"");
        }
        [TestMethod]
        [DataRow(null)]
        [ExpectedException(typeof(ArgumentNullException), "A ArgumentNullException was inappropriately handled.")]
        public void SayHelloToNullPersonTest(Person p)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"person = \"{p}\"");
            Person.SayHello(p);
        }

        [TestMethod]
        [DataRow("John")]
        public void SayHelloToStringTest(string name = "")
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"name = \"{name}\"");
            Trace.WriteLine($"Person.SayHello(name) = \"{Person.SayHello(name)}\"");
            Assert.IsTrue(Person.SayHello(name) == $"Hello, {name}!",
            $"Expected for Person.SayHello(name) == \"Hello, {name}!\"");
        }

        [TestMethod]
        [DataRow("John", "Josh", "Jeremy")]
        public void SayHelloToStringParamsTest(params string[] names)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"names = \"{string.Join(", ", names)}\"");
            Trace.WriteLine($"Person.SayHello(names) = \"{Person.SayHello(names)}\"");
            Assert.IsTrue(Person.SayHello(names) == $"Hello, {string.Join(", ", names)}!",
                       $"Expected for Person.SayHello(names) == \"Hello, {string.Join(", ", names)}!\"");
        }

        [TestMethod]
        [DataRow(null)]
        public void SayHelloToStringParamsNullTest(params string[] names)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"names = \"{string.Join(", ", names)}\"");
            Trace.WriteLine($"Person.SayHello(names) = \"{Person.SayHello(names)}\"");
            Assert.IsTrue(Person.SayHello(names) == $"Hello!",
                       $"Expected for Person.SayHello(names) == \"Hello, {string.Join(", ", names)}!\"");
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow(" ")]
        [DataRow("")]
        public void SayHelloToEmptyTest(string name = "")
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"name = \"{name}\"");
            Trace.WriteLine($"Person.SayHello(name) = \"{Person.SayHello(name)}\"");
            Assert.IsTrue(Person.SayHello(name) == $"Hello!",
            $"Expected for Person.SayHello(name) == \"Hello!\"");
        }
        [TestMethod]
        [DataRow("John", "Doe")]
        public void FirstNameAndLastNameMatchTest(string firstName, string lastName = "")
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\"");
            Person p = new Person(firstName, lastName);
            Trace.WriteLine($"p.FirstName = \"{p.FirstName}\" p.LastName = \"{p.LastName}\"");

            Assert.IsTrue(p.FirstName == firstName,
                       $"Expected for p.FirstName == \"{firstName}\", Actual = \"{p.FirstName}\"");

            Assert.IsTrue(p.LastName == lastName,
                      $"Expected for p.LastName == \"{lastName}\", Actual = \"{p.LastName}\"");
        }

        [TestMethod]
        public void EmptyFirstNameInConstructorTest()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Person(string.Empty));
        }

        [TestMethod]
        [DataRow("John", "  ")]
        [DataRow("John", null)]
        [DataRow(null)]
        [DataRow(null, "  ")]
        [DataRow(null, null)]
        [DataRow("  ")]
        [DataRow("  ", "  ")]
        [DataRow("  ", null)]
        [DataRow("")]
        [DataRow("", "  ")]
        [DataRow("", null)]
        [ExpectedException(typeof(ArgumentNullException), "A ArgumentNullException was inappropriately handled.")]
        public void ConstructorExceptionTest(string firstName, string lastName = "")
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\"");
            Person p = new Person(firstName, lastName);
            Trace.WriteLine($"p.FirstName = \"{p.FirstName}\" p.LastName = \"{p.LastName}\"");
        }

    }
}
