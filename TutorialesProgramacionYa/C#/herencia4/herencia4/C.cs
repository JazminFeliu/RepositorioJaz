using System;

namespace herencia4
{
    public class C : B
    {
        public C(int c) : base(c/3)
        {
            Console.WriteLine(c);
        }
    }
}
