namespace AccessModifiers
{
    class Four : Program
    {
        // Case 4: Accessing members of a class from child class of different    project
        static void Main(string[] args)
        {
            Four four = new Four();
            four.Foo5();
            four.Foo2();
            four.Foo3();
            
        }
    }
}