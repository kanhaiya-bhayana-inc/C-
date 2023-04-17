namespace MethodOverloading
{
    // Changing the behaviour based on the input
    class Program
    {
        public void Test()
        {
            Console.WriteLine("1. Zero Parameters.");
        }

        public void Test(int a)
        {
            Console.WriteLine("2. With 1 Parameter.");
        }
        public void Test(string s)
        {
            Console.WriteLine("3. With 1 Parameters but dift signature.");
        }
        public void Test(int a, string s)
        {
            Console.WriteLine("4. With 2 Parameters.");
        }
        public void Test(string s, int a)
        {
            Console.WriteLine("5. With 2 Parameters but parameters order is different.");
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test();
            p.Test(1);
            p.Test("2");
            p.Test(10, "110");
            p.Test("3",3);


            // Real Example
            // here methods name are same but parameters are different
            string str = "Hello World";
            int pos = str.IndexOf('o'); // return 1st occurance
            if (pos != -1)
            {
                pos = str.IndexOf('o',pos+1); // return 2nd occcurance
                int pos1 = str.IndexOf("ll"); // reuturn the occurance of string ll
                Console.WriteLine($"next Occurance of O is at {pos}");
                Console.WriteLine($"Occurance of string ll is at {pos1}");
            }
        }
    }
}