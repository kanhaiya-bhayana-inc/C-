﻿namespace InterfaceImplementation
{
    interface ItestInnterface1
    {
        void Add(int a,int b); // by default this method is public and abstract.... and while overriding do not need to use override keyword
    }
    interface ItestInnterface2 : ItestInnterface1
    {
        void Sub(int a,int b);
    }
    class ImplementsInterface : ItestInnterface2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a+b}");
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        static void Main()
        {
            ImplementsInterface imp = new ImplementsInterface();
            imp.Add(1,2);
            imp.Sub(11,2);
        }
    }
}