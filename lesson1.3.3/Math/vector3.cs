using System;
using System.Collections.Generic;
using System.Text;

namespace lesson1._3._3.Math
{
    public struct vector3
    {
        public float X;
        public float Y;
        public float Z;

        public vector3 add(vector3 other)
        {
            vector3 result = new vector3()
            {
                X = X + other.X,
                Y = Y + other.Y,
                Z = Z + other.Z,
            };
            return result;
        }

        public vector3 Subtract (vector3 other)
        {
            vector3 result = new vector3()
            {
                X = X - other.X,
                Y = Y - other.Y,
                Z = Z - other.Z,
            };
            return result;
        }

        public vector3 Multiply(float number)
        {
            vector3 result = new vector3()
            {
                X = X * number,
                Y = Y * number,
                Z = Z * number,
            };
            return result;
        }

        public vector3 Divide(float number)
        {
            vector3 result = new vector3()
            {
                X = X / number,
                Y = Y / number,
                Z = Z / number,
            };
            return result;
        }

        public override string ToString()
        {
            return "(" + X + "; " + Y + "; " + Z + ")";
        }

    }
}
