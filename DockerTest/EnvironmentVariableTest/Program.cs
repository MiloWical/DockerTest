using System;

namespace EnvironmentVariableTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Beginning property dump...\n");

            foreach(string key in Environment.GetEnvironmentVariables().Keys)
            {
                Console.WriteLine($"Environment Key: {key}, Value: {Environment.GetEnvironmentVariable(key)}");
            }

            Console.WriteLine("Changing value for 'TestKey'...\n");

            Environment.SetEnvironmentVariable("TestKey", "NewKeyValue");

            foreach (string key in Environment.GetEnvironmentVariables().Keys)
            {
                Console.WriteLine($"Environment Key: {key}, Value: {Environment.GetEnvironmentVariable(key)}");
            }

            Console.WriteLine("\nDump completed.");
        }
    }
}
