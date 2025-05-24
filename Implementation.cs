using MelonLoader;
using UnityEngine;
using Il2CppInterop;
using Il2CppInterop.Runtime.Injection; 
using System.Collections;
using Il2CppTLD.Gear;
using Il2Cpp;
using Il2CppTLD.IntBackedUnit;
using Il2CppVLB;
using Il2CppSystem;
using Il2CppSWS;
using Harmony;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace InfiniteCheatDeath
{
	public class InfiniteCheatDeathMelon : MelonMod
	{
        public override void OnInitializeMelon()
		{
            MelonLogger.Msg("I always come back...");
        }


    }
}