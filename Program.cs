// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
namespace Singleton.Structural
{
    /// <summary>
    /// Singleton Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Constructor is protected -- cannot use new
            President s1 = President.Instance();
            President s2 = President.Instance();
            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("president are the same instance");
            }
            Directors i1 = new Directors();
            Directors i2 = new Directors();
            if (i1 == i2)
            {
                Console.WriteLine("directors are same instance");
            }
            else
            {
                Console.WriteLine("directors are not same instance");
            }
            // Wait for user
            Console.ReadKey();
        }
    }
    /// <summaryP
    /// The 'Singleton' class
    /// </summary>
    public class President
    {
        static President? instance;
        // Constructor is 'protected'
        protected President()
        {
        }
        public static President Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (instance == null)
            {
                instance = new President();
            }
            return instance;
        }
    }
    public class Directors
    {
        //director class 
    }
}
