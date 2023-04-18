using System.Collections.Generic;

namespace CollectionsImplementation
{
    internal class GenericExample1
    {
        // Here the problem is each time it is doing boxing and unboxing and It's not type safe
       /* public bool Compare(Object a , Object b)
        {
            if(a.Equals(b)) return true;
            return false;
        }*/

        // ***************************************************************
        // Solution is Generics
        // ***************************************************************

        public bool Compare<T>(T a, T b)
        {
            if(a.Equals(b)) return true;
            return false;
        }
        static void Main(string[] args)
        {
            // Here if you will input any incorrect data type it will accept and proceed further ....
            /*GenericExample1 obj = new GenericExample1();
            bool res = obj.Compare(1, 2.2);
            Console.WriteLine(res);*/


            // *********************** Solution Implementation ****************
            // Here if you will input any incorrect data type it will not accept and show the error....
            GenericExample1 obj = new GenericExample1();
            bool res = obj.Compare<int>(12, 14);
            Console.WriteLine(res);

            
        }
    }
}
