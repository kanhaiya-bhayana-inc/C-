namespace SealedClass
{
     class A
    {
         protected virtual void Foo() {
            Console.WriteLine("A.Foo.");
        }
    }
    class B : A
    {
        protected sealed override void Foo()
        {
            Console.WriteLine("B.Foo.");
        }
    }
    class C : B 
    {
        protected override Foo()
        {

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            A a = new A();
            a.Foo();
        }
    }
}