using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonLib;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace PersonLibTest
{
    [TestClass]
    public class QueryType
    {
        private List<Employee> _lstEmployees;
        private List<Employee> lstEmployees { get { return _lstEmployees; } }
        public QueryType()
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            _lstEmployees = new List<Employee>(){
                new Employee("John","Doe",EmployeePosition.Owner,9000),
                new Employee("Jane","Fonda",EmployeePosition.Salesman,3000),
                new Employee("Jack","Born",EmployeePosition.Manager,4200),
                new Employee("Jeremy","Frist",EmployeePosition.Salesman,3050),
                new Employee("James","Redford",EmployeePosition.Manager,4100)};
            for (int i = 0; i < _lstEmployees.Count; i++)
            {
                Employee employee = this._lstEmployees[i];
                Trace.WriteLine($"\"{employee}\"");
            }
        }
        [TestMethod]
        public void LinqExtesionMethodIsSecoundEInListTest()
        {
            List<Employee> lstNamesWithE = lstEmployees.Where(xx => xx.FirstName[1] == 'e').ToList();
            Trace.WriteLine($"lstNamesWithE.Count = {lstNamesWithE.Count}");
            for (int ii = 0; ii < lstNamesWithE.Count; ii++)
            {
                Trace.WriteLine($"lstNamesWithE[{ii}] = \"{lstNamesWithE[ii]}\"");
            }

            Assert.IsTrue(lstNamesWithE.Count > 0, $"Expected for lstNamesWithE.Count>0");
        }

        [TestMethod]
        public void LinqQueryMethodIsSecoundEInListTest()
        {
            List<Employee> lstNamesWithE = (from employee in lstEmployees
                                            where employee.FirstName[1] == 'e'
                                            select employee
                                         ).ToList();

            Trace.WriteLine($"lstNamesWithE.Count = {lstNamesWithE.Count}");
            for (int ii = 0; ii < lstNamesWithE.Count; ii++)
            {
                Trace.WriteLine($"lstNamesWithE[{ii}] = \"{lstNamesWithE[ii]}\"");
            }

            Assert.IsTrue(lstNamesWithE.Count > 0, $"Expected for lstNamesWithE.Count>0");
        }

        [TestMethod]
        public void LinqQueryGroupInListTest()
        {
            Trace.WriteLine("---= LinqQueryGroupInListTest =---");
            var groupPosition = from employee in lstEmployees
                                group employee by employee.Position;


            //Trace.WriteLine($"groupPosition.Count = {groupPosition.}");
            foreach (var group in groupPosition)
            {
                Trace.WriteLine($"\"{group.Key}\"");
                foreach (var employee in group)
                {
                    Trace.WriteLine($"\"{employee}\"");
                }
                Trace.WriteLine("");
            }
            Assert.IsNotNull(groupPosition, $"Expected for groupPosition not null");
        }

        [TestMethod]
        public void LinqExtesionMethodGroupInListTest()
        {
            Trace.WriteLine("---= LinqExtesionMethodGroupInListTest =---");
            var groupPosition = lstEmployees.GroupBy(xx=>xx.Position);


            //Trace.WriteLine($"groupPosition.Count = {groupPosition.}");
            foreach (var group in groupPosition)
            {
                Trace.WriteLine($"\"{group.Key}\"");
                foreach (var employee in group)
                {
                    Trace.WriteLine($"\"{employee}\"");
                }
                Trace.WriteLine("");
            }
            Assert.IsNotNull(groupPosition, $"Expected for groupPosition not null");
        }
    }
}
