using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Reflection.Metadata.Ecma335;

namespace BubbleSort
{
    public static class RandomArray
    {
        // Method to generate a random 32-bit signed integer using RandomNumberGenerator
        private static int GetRandomInt()
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] randomBytes = new byte[4]; // 4 bytes = 32 bits
                rng.GetBytes(randomBytes);

                // Convert the bytes to an integer
                int randomNumber = BitConverter.ToInt32(randomBytes, 0);

                // Scale the random number to be between 0 and 5000
                return Math.Abs(randomNumber % 5001); // Absolute value to handle negative numbers
            }
        }

        public static int[] Generate()
        {
            int[] ints = new int[10];
            for (int i = 0; i < 10; i++)
            {
                ints[i] = GetRandomInt();
            }
            return ints;
        }

        public static int[] Generate(int length)
        {
            int[] ints = new int[length];
            for (int i = 0; i < length; i++)
            {
                ints[i] = GetRandomInt();
            }
            return ints;
        }
    }
}
