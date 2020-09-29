using System;
using System.Collections.Generic;

namespace StarWars.Resistance
{
    /// <summary>
    /// C3P0 - Algorithm
    /// </summary>
    public static class Solution2
    {
        public static int Solution(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            return array.Length < 3 ? 0 : GetMaxCannons(array);
        }

        private static int GetMaxCannons(IList<int> array)
        {
            var peakList = GetPeakList(array);
            var cannonNumber = 1;
            var maxCannons = 0;

            while ((cannonNumber - 1) * cannonNumber <= array.Count)
            {
                var cannonPosition = 0;
                var cannonsAllocated = 0;

                while (cannonPosition < array.Count && cannonsAllocated < cannonNumber)
                {
                    cannonPosition = peakList[cannonPosition];

                    if (cannonPosition == -1)
                        break;

                    cannonsAllocated++;
                    cannonPosition += cannonNumber;
                }
                maxCannons = Math.Max(maxCannons, cannonsAllocated);
                cannonNumber++;
            }
            return maxCannons;
        }

        private static IList<int> GetPeakList(IList<int> array)
        {
            var peaks = new bool[array.Count];
            for (var i = 1; i < array.Count - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i] > array[i + 1])
                    peaks[i] = true;
            }

            var peakList = new int[array.Count];

            peakList[array.Count - 1] = -1;

            for (var i = array.Count - 2; i >= 0; i--)
                peakList[i] = peaks[i] ? i : peakList[i + 1];

            return peakList;
        }
    }
}
