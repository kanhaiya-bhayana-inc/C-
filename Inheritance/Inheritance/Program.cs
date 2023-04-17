namespace Inheritance
{

    class Program
    {
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
            Program p; // p is a variable of class Program
           
            Class2 c = new Class2(); // c is an instance of class2
            p = c;
            p.Foo1();
            p.Foo2();
        }
    }
}