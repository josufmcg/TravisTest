using System;

namespace Arithmetics
{
    public class Arithmetic
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subs(int a, int b)
        {
            if (a <b)
            {
                string msg = "a should be higher than b";
                throw new InvalidOperationException(msg);
            }
            return a - b;
        }
    }
}
