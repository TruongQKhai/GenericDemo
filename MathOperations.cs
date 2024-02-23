﻿using System.Numerics;

namespace GenericDemo
{
    public class MathOperations<T> where T : INumber<T>
    {
        public T Add(T x, T y)
        {
            return x + y;
        }
    }
}
