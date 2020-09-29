using System;
using System.Collections.Generic;

namespace StarWars.Resistance
{
    /// <summary>
    /// BB8 - Algorithm
    /// </summary>
    public static class Solution3
    {
        public static int Solution(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            return array.Length < 3 ? 0 : GetMaxCannons(array);
        }

        private static int GetMaxCannons(IList<int> array)
        {
            var peaks = new List<int>();

            for (var i = 1; i < array.Count - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    peaks.Add(i);
            }

            var n = peaks.Count;
            if (n <= 2)
                return n;

            var maxCannons = Math.Min(n, (int)Math.Sqrt(array.Count));
            var distance = maxCannons;
            var rightPeak = peaks[n - 1];

            for (var k = maxCannons - 2; k > 0; k--)
            {
                var cannons = k;
                var leftPeak = peaks[0];

                for (var i = 1; i <= n - 2; i++)
                {
                    if (peaks[i] - leftPeak >= distance && rightPeak - peaks[i] >= distance)
                    {
                        if (cannons == 1)
                            return k + 2;

                        cannons--;
                        leftPeak = peaks[i];
                    }

                    if (rightPeak - peaks[i] <= cannons * (distance + 1))
                        break;
                }

                if (cannons == 0)
                    return k + 2;

                distance--;
            }
            return 2;
        }
    }
}
