using System;

namespace PersonLib
{
    public class Person
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public Person(string firstName, string lastName = "")
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentNullException("firstName cannot be null empty or white space");

            if (lastName == null || (lastName.Length > 0 && lastName.Trim() == string.Empty))
                throw new ArgumentNullException("lastName cannot be null or white space");

            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}".Trim();
        }

        public  static string SayHello(string name)
        {
            string greeting = "Hello";
            if (string.IsNullOrWhiteSpace(name))
                return $"{greeting}!";
            else
                return $"{greeting}, {name}!";
        }
        public static string SayHello(Person toPerson)
        {
            if (toPerson == null) throw new ArgumentNullException("Person cannot be null");
            return SayHello(toPerson.ToString());
        }


        public static string SayHello(params string[] names)
        {
            string joinedNames = null;
            if (names != null)
                joinedNames = string.Join(", ", names);
            return SayHello(joinedNames);
        }
    }
}
