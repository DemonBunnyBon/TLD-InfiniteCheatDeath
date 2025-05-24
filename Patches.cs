using MelonLoader;
using UnityEngine;
using Il2CppInterop;
using Il2CppInterop.Runtime.Injection;
using System.Collections;
using Il2CppTLD.Gear;
using Il2Cpp;
using Il2CppTLD.IntBackedUnit;
using Il2CppVLB;
using Il2CppNodeCanvas.Tasks.Actions;
using Il2CppSteamworks;
using Il2CppTLD.UI;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.UIElements;
using Il2CppTLD.Gameplay;


namespace InfiniteCheatDeath
{

    internal static class Patches
    {
        [HarmonyPatch(typeof(LifeAfterDeathManager), "PerformRespawn")]

        public class LifeAfterDeathCountPatch
        {
            public static void Postfix(ref LifeAfterDeathManager __instance)
            {

               __instance.m_LifeAfterDeathState.m_LivesUsed = 0;

            }

        }


    }
}

