namespace Inheritance
{

    class Program
    {
        public Program(int a) {
            Console.WriteLine($"Constructor.Program {a}");
        }
        public void Foo1()
        {
            Console.WriteLine("Called Foo1 -> Program.Foo1");
        }

        public void Foo2()
        {
            Console.WriteLine("Called Foo2 -> Program.Foo2");
        }
        static void Main(string[] args)
        {
            /*Object obj = new Object(); // Root class 

            Program p; // p is a variable of class Program
           
            Class2 c = new Class2(); // c is an instance of class2
            p = c;
            p.Foo1();
            p.Foo2();*/
            //p.Foo3(); // cannot called child class method
        }
    }
}