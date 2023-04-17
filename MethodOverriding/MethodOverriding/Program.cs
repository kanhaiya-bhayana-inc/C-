namespace MethodOverriding
{
    class Parent
    {
        public void Test()
        {
            Console.WriteLine("Called Test.Parent");
        }
        public virtual void Show()
        {
            Console.WriteLine("Called Show.Parent");
        }
    }
    class Program : Parent
    {
        // Overloading Parent's Test method is Program class
        public void Test(int i)
        {
            Console.WriteLine("Called Test.Program");
        }

        // Overriding Parent's Show method in Program class
        public override void Show() // Overriding
        {
            Console.WriteLine("Called Show.Program");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test();
            p.Test(10);
            p.Show();
        }

    }
}