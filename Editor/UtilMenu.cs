using UnityEditor;
using UnityEngine;

namespace Monpl.Utils.Editors
{
    public static class UtilMenu
    {
        [MenuItem("MonsterPlanet/Data/Clear PlayerPrefs")]
        public static void ClearPlayerPrefs()
        {
            PlayerPrefs.DeleteAll();
        }
    }
}