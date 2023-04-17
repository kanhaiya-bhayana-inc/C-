namespace MethodHiding_Shadowing
{
    class Parent
    {
        public virtual void Test()
        {
            Console.WriteLine("Called Test.Parent");
        }
        public void Show()
        {
            Console.WriteLine("Called Show.Parent");
        }
    }
    class Program : Parent
    {
        public override void Test()
        {
            Console.WriteLine("Called Test.Program");
        }
        public new void Show()
        {
            Console.WriteLine("Called Show.Program");
        }
        public void ParentTest()
        {
            base.Test();
        }
        public void ParentShow()
        {
            base.Show();
        }

        /*
            The above two methods in a child class
            are going to act as an interface in calling
            the Parent class methods from the child class
        */
        static void Main(string[] args)
        {
            // Approach 1st - directly create the instance of the parent class
            /*Parent pr = new Parent();
            pr.Test();
            pr.Show();*/

            // Approach 2nd - using the this and base keyword but keep in mind that these keywords can't be used from static blocks
            Program p = new Program();
            p.Test();
            p.Show();
            p.ParentShow();
            p.ParentTest(); 
        }
    }
}