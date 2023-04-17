namespace AccessModifiers
{
    // Case 1: Accessing members of a class from same class of same project
   
    public class Program
    {
        private void Foo1() { Console.WriteLine("Private Foo."); }
        protected void Foo2() { Console.WriteLine("Protected Foo."); }
        public void Foo3() { Console.WriteLine("Public Foo."); }
        internal void Foo4() { Console.WriteLine("Internal Foo."); }
        protected internal void Foo5() { Console.WriteLine("Protected Internal Foo."); }
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.Foo3(); // public
            p.Foo1(); // private
            p.Foo2(); // protected
            p.Foo4(); // internal
            p.Foo5(); // protected internal
        }
    }
}