using HarmonyLib;
using Il2CppMonomiPark.SlimeRancher.UI.IntroSequence;
using UnityEngine;

namespace SkipIntroSequence
{
    [HarmonyPatch(typeof(IntroSequenceUIRoot), nameof(IntroSequenceUIRoot.Start))]
    internal class IntroSequenceUIRootStartFramePatch : Entry
    {
        public static void Postfix(IntroSequenceUIRoot __instance)
        {
            GameObject.Destroy(__instance.gameObject);
        }
    }
}