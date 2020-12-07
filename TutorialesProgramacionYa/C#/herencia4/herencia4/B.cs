using System;

namespace herencia4
{
    public class B : A 
    {
        public B(int b) : base(b/2)
        {
            Console.WriteLine(b);
        }
    }
}
