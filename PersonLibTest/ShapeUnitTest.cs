using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonLib;
using System;
using System.Diagnostics;

namespace ShapeLibTest
{
    [TestClass]
    public class SquareType
    {
        [TestMethod]
        public void ShapeColorRedToStringTest()
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            //Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\" position =\"{position}\"");
            ShapeColor red = ShapeColor.Red;
            Trace.WriteLine($"ShapeColor.Red.ToString() = \"{red}\"");
            Assert.IsTrue(red.ToString() == "Red",
                       $"Expected for ShapeColor.Red.ToString() = \"Red\"");
        }
        
        [TestMethod]
        public void ShapeColorGreenToStringTest()
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            //Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\" position =\"{position}\"");
            ShapeColor green = ShapeColor.Green;
            Trace.WriteLine($"ShapeColor.Green.ToString() = \"{green}\"");
            Assert.IsTrue(green.ToString() == "Green",
                       $"Expected for ShapeColor.Green.ToString() = \"Green\"");
        }
        [TestMethod]
        [DataRow(2)]
        public void SquareColorEqualsTest(double sideLength)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            //Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\" position =\"{position}\"");
            Square s = new Square(sideLength, ShapeColor.Red);
            Trace.WriteLine($"s.SideLength = {s.SideLength} s.Area = {s.Area}");
            Assert.IsTrue(s.Color.Equals(ShapeColor.Red),
                       $"Expected for s.Color == ShapeColor.Red");
        }

        [TestMethod]
        [DataRow(2)]
        public void SquareColorTest(double sideLength)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            //Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\" position =\"{position}\"");
            Square s = new Square(sideLength, ShapeColor.Red);
            Trace.WriteLine($"s.SideLength = {s.SideLength} s.Area = {s.Area}");
            Assert.IsTrue(s.Color == ShapeColor.Red,
                       $"Expected for s.Color == ShapeColor.Red");
        }

        [TestMethod]
        [DataRow(2)]
        public void SquareAreaTest(double sideLength)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            //Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\" position =\"{position}\"");
            Square s = new Square(sideLength, ShapeColor.Red);
            Trace.WriteLine($"s.SideLength = {s.SideLength} s.Area = {s.Area}");
            Assert.IsTrue(s.Area == 4,
                       $"Expected for s.Area() == 4");
        }

        [TestMethod]
        [DataRow(2)]
        public void SquarePerimeterTest(double sideLength)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            //Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\" position =\"{position}\"");
            Square s = new Square(sideLength, ShapeColor.Red);
            Trace.WriteLine($"s.SideLength = {s.SideLength} s.Perimeter = {s.Perimeter}");
            Assert.IsTrue(s.Perimeter == 8,
                       $"Expected for s.Perimeter() == 8");
        }

        [TestMethod]
        [DataRow(2)]
        public void SquareIsPoligonTest(double sideLength)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            //Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\" position =\"{position}\"");
            Square s = new Square(sideLength, ShapeColor.Red);
            Trace.WriteLine($"s.SideLength = {s.SideLength} ShapeUtility.IsPoligon(s) = {ShapeUtility.IsPoligon(s)}");
            Assert.IsTrue(ShapeUtility.IsPoligon(s),
                       $"Expected for ShapeUtility.IsPoligon(s) == True");
        }
        [TestMethod]
        [DataRow(2)]
        public void SquareIsPoligonExtensionTest(double sideLength)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            //Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\" position =\"{position}\"");
            Square s = new Square(sideLength, ShapeColor.Red);
            Trace.WriteLine($"s.SideLength = {s.SideLength} s.IsPoligon() = {s.IsPoligon()}");
            Assert.IsTrue(s.IsPoligon(),
                       $"Expected for s.IsPoligon() == True");
        }
        [TestMethod]
        [DataRow(2)]
        public void CircleIsPoligonTest(double radius)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            //Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\" position =\"{position}\"");
            Circle c = new Circle(radius, ShapeColor.White);
            Trace.WriteLine($"c.Radius = {c.Radius} ShapeUtility.IsPoligon(c) = {ShapeUtility.IsPoligon(c)}");
            Assert.IsTrue(!ShapeUtility.IsPoligon(c),
                       $"Expected for ShapeUtility.IsPoligon(c) == False");
        }
        [TestMethod]
        [DataRow(2)]
        public void CircleIsPoligonExtensionTest(double radius)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            //Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\" position =\"{position}\"");
            Circle c = new Circle(radius, ShapeColor.White);
            Trace.WriteLine($"c.Radius = {c.Radius} c.IsPoligon() = {c.IsPoligon()}");
            Assert.IsTrue(!c.IsPoligon(),
                       $"Expected for c.IsPoligon() == False");
        }

        [TestMethod]
        [DataRow(2)]
        public void CircleAreaTest(double radius)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // or Trace.Listeners.Add(new ConsoleTraceListener());
            //Trace.WriteLine($"firstName = \"{firstName}\" lastName = \"{lastName}\" position =\"{position}\"");
            Circle c = new Circle(radius, ShapeColor.White);
            Trace.WriteLine($"c.Radius = {c.Radius} c.Area = {c.Area}");
            Assert.IsTrue(c.Area == c.Radius * c.Radius * Math.PI,
                       $"Expected for c.Radius = 2 c.Area = 12.566370614359172");
        }
    }
}
