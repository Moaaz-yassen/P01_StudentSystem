using System;
using P01_StudentSystem.Data;

namespace P01_StudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new StudentSystemContext();
            Console.WriteLine("Database connected successfully!");
        }
    }
}