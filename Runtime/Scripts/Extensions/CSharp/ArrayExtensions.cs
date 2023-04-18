using UnityEngine;

namespace Monpl.Utils.Extensions
{
    public static class ArrayExtensions
    {
        public static T GetRandom<T>(this T[] arr)
        {
            return arr[Random.Range(0, arr.Length)];
        }

        public static T GetLast<T>(this T[] arr)
        {
            return arr[^1];
        }
    }
}