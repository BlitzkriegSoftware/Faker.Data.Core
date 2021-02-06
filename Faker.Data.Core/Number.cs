//-----------------------------------------------------------------------
// <copyright file="Number.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Threading;

namespace Faker
{
    /// <summary>
    /// Number class used to generate random numbers
    /// </summary>
    public static class Number
    {
        private static int seed = Environment.TickCount;
        private static readonly ThreadLocal<Random> random = new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref seed)));

        /// <summary>
        /// Gets a random number
        /// </summary>
        /// <param name="min">Minimum value</param>
        /// <param name="max">Maximum value</param>
        /// <returns>Integer of the random number</returns>
        public static int RandomNumber(int min, int max)
        {
            if (max < min)
            {
                throw new ArgumentException("Max number must be greater than min");
            }

#pragma warning disable SCS0005 // Weak random generator
            return random.Value.Next(min, max);
#pragma warning restore SCS0005 // Weak random generator
        }

        /// <summary>
        /// Method to get a random long value
        /// </summary>
        /// <param name="min">Minimum long</param>
        /// <param name="max">Maximum long</param>
        /// <returns>A <see cref="long"/></returns>
        public static long RandomNumber(long min, long max)
        {
            var buf = new byte[8];
            NextBytes(buf);
            var longRand = BitConverter.ToInt64(buf, 0);

            return Math.Abs(longRand % (max - min)) + min;
        }

        /// <summary>
        /// Method to get the next bytes
        /// </summary>
        /// <param name="buffer">Byte Array</param>
        public static void NextBytes(byte[] buffer)
        { 
#pragma warning disable SCS0005 // Weak random generator
            random.Value.NextBytes(buffer);
#pragma warning restore SCS0005 // Weak random generator
        }

        /// <summary>
        /// Gets a random number from 0 to max variable
        /// </summary>
        /// <param name="max">Max integer to use</param>
        /// <returns>Integer number</returns>
        public static int RandomNumber(int max)
        {
#pragma warning disable SCS0005 // Weak random generator
            return random.Value.Next(Math.Abs(max));
#pragma warning restore SCS0005 // Weak random generator
        }

        /// <summary>
        /// Gets a random number from 0 to any
        /// </summary>
        /// <returns>Integer number</returns>
        public static int RandomNumber()
        {
#pragma warning disable SCS0005 // Weak random generator
            return random.Value.Next();
#pragma warning restore SCS0005 // Weak random generator
        }

        /// <summary>
        /// Gets a random negative number.  Pass in a positive value
        /// </summary>
        /// <param name="max">Max number positive</param>
        /// <returns>A negative integer</returns>
        public static int NegativeNumber(int max)
        {
#pragma warning disable SCS0005 // Weak random generator
            return random.Value.Next(1, Math.Abs(max)) * -1;
#pragma warning restore SCS0005 // Weak random generator
        }

        /// <summary>
        /// Gets the next even number
        /// </summary>
        /// <param name="min">Minimum value</param>
        /// <param name="max">Maximum value</param>
        /// <returns>Integer of even number</returns>
        public static int Even(int min, int max)
        {
            int result;
            do
            {
                result = RandomNumber(min, max);
            }
            while (result % 2 == 1);
            return result;
        }

        /// <summary>
        /// Gets the next odd number
        /// </summary>
        /// <param name="min">Minimum value</param>
        /// <param name="max">Maximum value</param>
        /// <returns>Integer of old number</returns>
        public static int Odd(int min = 0, int max = 1)
        {
            int result;
            do
            {
                result = RandomNumber(min, max);
            }
            while (result % 2 == 0);
            return result;
        }

        /// <summary>
        /// Gets the next double
        /// </summary>
        /// <returns>Random double value</returns>
        public static double Double()
        {
#pragma warning disable SCS0005 // Weak random generator
            return random.Value.NextDouble();
#pragma warning restore SCS0005 // Weak random generator
        }

        /// <summary>
        /// Gets a random boolean value
        /// </summary>
        /// <returns>Boolean of true or false</returns>
        public static bool Bool()
        {
            return RandomNumber(0, 100) % 2 == 0;
        }
    }
}
