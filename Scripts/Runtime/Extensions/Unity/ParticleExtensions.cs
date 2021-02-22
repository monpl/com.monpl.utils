using UnityEngine;

namespace Monpl.Utils.Extensions
{
    public static class ParticleExtensions
    {
        public static void StopAndClear(this ParticleSystem particleSystem)
        {
            particleSystem.Clear();
            particleSystem.Stop();
        }
    }
}