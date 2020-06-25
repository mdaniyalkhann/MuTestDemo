using System;

namespace MuTestDemo
{
    public class Log
    {
        public void Info(string message, int nMutants = 0)
        {
            Console.WriteLine(message + nMutants);
        }
    }
}
