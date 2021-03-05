using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonLib;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesLibTest
{
    [TestClass]
    public class DelegatesType
    {
        [TestMethod]
        [DataRow("Hello world!")]
        public void DelegateOneMethodOneTest(string message)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"message = \"{message}\"");

            DelegateOne one = new DelegateOne();
            Trace.WriteLine(one.MethodOne(message));
            Assert.IsTrue(one.MethodOne(message) == $"MethodOne: \"{message}\"",
           $"Expected for MethodOne: = \"Hello world!\"");
        }

        [TestMethod]
        [DataRow("Hello world!")]
        public void DelegateTwoMethodTwoTest(string message)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"message = \"{message}\"");

            DelegateOne one = new DelegateOne();
            DelegateTwo two = new DelegateTwo();
            Trace.WriteLine(two.MethodTwo(one.MethodOne));
            Assert.IsTrue(two.MethodTwo(one.MethodOne) == "MethodOne: \"Message form MethodTwo\"",
                       $"Expected for two.MethodTwo(one.MethodOne) = MethodOne: \"Message form MethodTwo\"");
        }

        [TestMethod]
        [DataRow("Hello world!")]
        public void DelegateThreeMethodThreeTest(string message)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"message = \"{message}\"");

            DelegateOne one = new DelegateOne();
            DelegateThree three = new DelegateThree();
            Trace.WriteLine(three.MethodThree(one.MethodOne));
            Assert.IsTrue(three.MethodThree(one.MethodOne) == "MethodOne: \"Message form MethodThree\"",
                       $"Expected for three.MethodThree(one.MethodOne) = MethodOne: \"Message form MethodThree\"");
        }

        [TestMethod]
        [DataRow("Hello world!")]
        public void DelegateOneIsSecoundETest(string message)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"message = \"{message}\"");

            DelegateOne one = new DelegateOne();
            Trace.WriteLine($"one.IsSecoundE(\"{message}\") = {one.IsSecoundE(message)}");
            Assert.IsTrue(one.IsSecoundE(message),
           $"Expected for one.IsSecoundE(\"{message}\") = True");
        }

        [TestMethod]
        [DataRow("Hello world!", "Hello!")]
        public void DelegateOneIsSecoundEInArrayTest(params string[] messages)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine($"messages = \"{messages[0]}\"");

            DelegateOne one = new DelegateOne();
            Trace.WriteLine($"one.IsSecoundE(\"{messages[0]}\") = {one.IsSecoundE(messages[0])}");
            Assert.IsTrue(one.IsSecoundE(messages[0]),
           $"Expected for one.IsSecoundE(\"{messages[0]}\") = True");
        }

        [TestMethod]
        [DataRow("Hello world!", "Jeremy", "John")]
        public void DelegateOneIsSecoundEInListTest(params string[] messages)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            for (int ii = 0; ii < messages.Length; ii++)
            {
                Trace.WriteLine($"messages[{ii}] = \"{messages[ii]}\"");
            }
            List<string> lstMessages = new List<string>();
            lstMessages.AddRange(messages);
            DelegateOne one = new DelegateOne();
            List<string> lstMessagesWithE = lstMessages.FindAll(one.IsSecoundE);
            Trace.WriteLine($"lstMessagesWithE.Count = {lstMessagesWithE.Count}");
            for (int ii = 0; ii < lstMessagesWithE.Count; ii++)
            {
                Trace.WriteLine($"lstMessagesWithE[{ii}] = \"{lstMessagesWithE[ii]}\"");
            }

            Assert.IsTrue(lstMessagesWithE.Count > 0, $"Expected for lstMessagesWithE.Count>0");
        }


        [TestMethod]
        [DataRow("Hello world!", "Jeremy", "John")]
        public void PredicateWithSecoundEInListTest(params string[] messages)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            for (int ii = 0; ii < messages.Length; ii++)
            {
                Trace.WriteLine($"messages[{ii}] = \"{messages[ii]}\"");
            }
            List<string> lstMessages = new List<string>();
            lstMessages.AddRange(messages);
            DelegateOne one = new DelegateOne();
            List<string> lstMessagesWithE = lstMessages.FindAll(x => x[1] == 'e');
            Trace.WriteLine($"lstMessagesWithE.Count = {lstMessagesWithE.Count}");
            for (int ii = 0; ii < lstMessagesWithE.Count; ii++)
            {
                Trace.WriteLine($"lstMessagesWithE[{ii}] = \"{lstMessagesWithE[ii]}\"");
            }

            Assert.IsTrue(lstMessagesWithE.Count > 0, $"Expected for lstMessagesWithE.Count>0");
        }

        [TestMethod]
        [DataRow("Hello world!", "Jeremy", "John")]
        public void DelegateWithSecoundEInListTest(params string[] messages)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            for (int ii = 0; ii < messages.Length; ii++)
            {
                Trace.WriteLine($"messages[{ii}] = \"{messages[ii]}\"");
            }
            List<string> lstMessages = new List<string>();
            lstMessages.AddRange(messages);
            DelegateOne one = new DelegateOne();
            List<string> lstMessagesWithE = lstMessages.FindAll(delegate (string x) { return x[1] == 'e'; });
            Trace.WriteLine($"lstMessagesWithE.Count = {lstMessagesWithE.Count}");
            for (int ii = 0; ii < lstMessagesWithE.Count; ii++)
            {
                Trace.WriteLine($"lstMessagesWithE[{ii}] = \"{lstMessagesWithE[ii]}\"");
            }

            Assert.IsTrue(lstMessagesWithE.Count > 0, $"Expected for lstMessagesWithE.Count>0");
        }


        [TestMethod]
        [DataRow("Hello world!", "Jeremy", "John")]
        public void FuncAndWhereWithSecoundEInListTest(params string[] messages)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            for (int ii = 0; ii < messages.Length; ii++)
            {
                Trace.WriteLine($"messages[{ii}] = \"{messages[ii]}\"");
            }
            List<string> lstMessages = new List<string>();
            lstMessages.AddRange(messages);
            DelegateOne one = new DelegateOne();
            Func<string, bool> fn = delegate (string x) { return x[1] == 'e'; };
            var lstMessagesWithE = lstMessages.Where(fn);
            int jj = 0;
            foreach (var message in lstMessagesWithE)
            {
                Trace.WriteLine($"lstMessagesWithE[{jj}] = \"{message}\"");
                jj++;
            }
            Assert.IsTrue(lstMessagesWithE != null, $"Expected for lstMessagesWithE != null");
        }

        [TestMethod]
        public void PersonLinqSelectDelegateTest()
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            List<Person> persons = new List<Person>(){
                    new Person("John"),
                    new Person("Jeremy", "Doe"),
                    new Person("Jane", "First")};

            int jj = 0;
            foreach (var p in persons)
            {
                Trace.WriteLine($"persons[{jj}].FirstName = \"{p.FirstName}\" persons[{jj}].LastName = \"{p.LastName}\"");
                jj++;
            }
            var personFirstNames = persons.Select(xx => xx.FirstName);
            jj = 0;
            foreach (var name in personFirstNames)
            {
                Trace.WriteLine($"personFirstNames[{jj}] = \"{name}\"");
                jj++;
            }
            Assert.IsTrue(personFirstNames.Count() > 0,
                       $"Expected for personFirstNames.Count() > 0, Actual = \"{personFirstNames.Count()}\"");
        }

        [TestMethod]
        public void PersonFuncSelectDelegateTest()
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            List<Person> persons = new List<Person>(){
                    new Person("John"),
                    new Person("Jeremy", "Doe"),
                    new Person("Jane", "First")};

            int jj = 0;
            foreach (var p in persons)
            {
                Trace.WriteLine($"persons[{jj}].FirstName = \"{p.FirstName}\" persons[{jj}].LastName = \"{p.LastName}\"");
                jj++;
            }
            Func<Person, string> fn = delegate (Person xx) { return xx.FirstName; };
            var personFirstNames = persons.Select(fn);
            jj = 0;
            foreach (var name in personFirstNames)
            {
                Trace.WriteLine($"personFirstNames[{jj}] = \"{name}\"");
                jj++;
            }
            Assert.IsTrue(personFirstNames.Count() > 0,
                       $"Expected for personFirstNames.Count() > 0, Actual = \"{personFirstNames.Count()}\"");
        }


        [TestMethod]
        public void PersonPredicateFindAllDelegateTest()
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            List<Person> persons = new List<Person>(){
                    new Person("John"),
                    new Person("Jeremy", "Doe"),
                    new Person("Jane", "First")};

            int jj = 0;
            foreach (var p in persons)
            {
                Trace.WriteLine($"persons[{jj}].FirstName = \"{p.FirstName}\" persons[{jj}].LastName = \"{p.LastName}\"");
                jj++;
            }
            Predicate<Person> fn = (xx) => { return xx.FirstName[1] == 'e'; };
            var personFirstNames = persons.FindAll(fn);
            jj = 0;
            foreach (var name in personFirstNames)
            {
                Trace.WriteLine($"personFirstNames[{jj}] = \"{name}\"");
                jj++;
            }
            Assert.IsTrue(personFirstNames.Count() > 0,
                       $"Expected for personFirstNames.Count() > 0, Actual = \"{personFirstNames.Count()}\"");
        }

        [TestMethod]
        public void PersonActionForEachDelegateTest()
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            List<Person> persons = new List<Person>(){
                    new Person("John"),
                    new Person("Jeremy", "Doe"),
                    new Person("Jane", "First")};

            int jj = 0;
            foreach (var p in persons)
            {
                Trace.WriteLine($"persons[{jj}].FirstName = \"{p.FirstName}\" persons[{jj}].LastName = \"{p.LastName}\"");
                jj++;
            }
            Action<Person> fn = (xx) => { Trace.WriteLine($"xx = \"{xx}\""); };
            persons.ForEach(fn);
            Assert.IsTrue(true);
        }
    }
}
