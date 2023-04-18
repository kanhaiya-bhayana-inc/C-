using System.Collections.Generic;


namespace CollectionsImplementation
{
    internal class GenericList
    {
        static void Main()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            for (int i = 0; i < list.Count; i++) { Console.Write(list[i] + " "); }
            Console.WriteLine();

            foreach(int i in list) Console.Write(i + " ");
        }
    }
}
