using System.Collections.Generic;


namespace CollectionsImplementation
{
    internal class DictionaryExample
    {
        static void Main()
        {
            /* When you run this script and you will observe that the 
                output is in the order in which you insert the elements in the dictionary 
                but in case of HashTable it was first generating the hashCode and then 
                storing the data so the order of the data got changed 
            ||
                - It always maintain the order of stored values.
            */
            Dictionary<string,object> dict = new Dictionary<string,object>();
            dict.Add("EmpID", 1001);
            dict.Add("EmpName", "Atul Mishra");
            dict.Add("Phone", +91-1234567890);
            dict.Add("Address", "Delhi");
            dict.Add("Salary", 100000.00);

            foreach(string key in dict.Keys)
            {
                Console.WriteLine(key + " : " + dict[key]);
            }
        }
    }
}
