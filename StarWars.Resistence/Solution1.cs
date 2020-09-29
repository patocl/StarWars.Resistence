using System;
using System.Collections.Generic;
using System.Linq;

namespace StarWars.Resistance
{
    /// <summary>
    /// R2D2 - Algorithm
    /// </summary>
    public static class Solution1
    {
        public static int Solution(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            // Note: I cloned the array because it's passed by reference
            return array.Length < 3 ? 0 : GetMaxCannons(array);
        }

        private static int GetMaxCannons(int[] array)
        {
            var peakPositions = FillPeakPositions((IList<int>)array.Clone());
            var lower = 0;
            var upper = (int)Math.Sqrt(peakPositions.Count) + 2;

            while (lower < upper - 1)
            {
                var next = (lower + upper) / 2;
                if (CanPlaceCannon(peakPositions, next))
                    lower = next;
                else
                    upper = next;
            }
            return lower;
        }

        private static IList<int> FillPeakPositions(IList<int> array)
        {
            var maxPeakPosition = array.Count;
            var lastPosition = array.Last();
            for (var i = array.Count - 1; i >= 1; i--)
            {
                if (array[i - 1] < array[i] && array[i] > lastPosition)
                    maxPeakPosition = i;

                lastPosition = array[i];
                array[i] = maxPeakPosition;
            }
            array[0] = maxPeakPosition;
            return array;
        }

        private static bool CanPlaceCannon(IList<int> array, int k)
        {
            var cannon = 1 - k;
            for (var i = 0; i < k; i++)
            {
                if (cannon + k > array.Count - 1)
                    return false;

                cannon = array[cannon + k];
            }
            return cannon < array.Count;
        }
    }
}
