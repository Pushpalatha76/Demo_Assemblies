using System;
using System.Reflection;
using Demo_Assemblies;

namespace Demo_Assemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing Assemblies in csharp!");
            Stringer myStringInstance = new Stringer();
            Console.WriteLine("client code excecutes");
            myStringInstance.stringermethod();
        }
    }
}
