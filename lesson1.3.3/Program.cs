using System;
using lesson1._3._3.Math;

namespace lesson1._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            vector3 up = new vector3();
            up.Y = 1;
            vector3 forward = new vector3();
            forward.Z = 1;

            Console.WriteLine(up.add(forward));
            Console.WriteLine(up.Subtract(forward));
            Console.WriteLine(up.Multiply(5.5f));
            Console.WriteLine(up.Divide(8.0f));
        }
    }
}
