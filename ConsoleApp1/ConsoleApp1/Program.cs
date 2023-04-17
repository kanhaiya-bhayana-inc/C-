using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*var nums = new[] { "Ashish", 2, 3 };*/
            object[] nums = { 1, 2, "Aashish" };
            int[,] a = new int[3, 3];
            Console.WriteLine(nums[2].GetType());
        }
    }
}