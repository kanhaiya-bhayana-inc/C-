using System.Collections;


namespace CollectionsImplementation
{
    internal class NGArrayList
    {
        static void Main()
        {
            ArrayList al = new ArrayList();

            // Auto resizing
            al.Add(100);al.Add(200);al.Add(300);al.Add(400);al.Add(500);
            /*Console.WriteLine(al.Capacity);*/

            // Insert at the mid
            al.Insert(4,450);

            // Remove specific value
            //al.Remove(450); // It takes the value as a parameter that user want to delete...

            // Remove form the position
            al.RemoveAt(4); // It takes the index value as a parameter and value at that index will be deleted..

            // For reversing the arrayList...
            al.Reverse();

            foreach (int i in al)
                Console.Write(i + " ");
        }
        
    }
}
