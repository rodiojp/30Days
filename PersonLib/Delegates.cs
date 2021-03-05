using System;

namespace PersonLib
{
    public delegate string SayHello(string message);
    public class DelegateOne
    {
        public string MethodOne(string message)
        {
            return $"MethodOne: \"{message}\"";
        }

        public bool IsSecoundE(string message)
        {

            return (message.Length > 1) && message[1] == 'e';
        }
    }
    public class DelegateTwo
    {
        public string MethodTwo(SayHello fn)
        {
            return fn("Message form MethodTwo");
        }
    }

    public class DelegateThree
    {
        public string MethodThree(Func<string,string> fn)
        {
            return fn("Message form MethodThree");
        }
    }
}