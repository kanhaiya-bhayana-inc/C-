using System.Collections;


namespace CollectionsImplementation
{
    internal class HashCollection
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("EmpID",1001);
            ht.Add("EmpName", "Atul Mishra");
            ht.Add("Phone", "+91-1234567890");
            ht.Add("Address", "Delhi");

            foreach (string key in ht.Keys)
            {
                Console.WriteLine(key + ": " + ht[key]);
            }
        }
    }
}
