/*
using HarmonyLib;
using System.Reflection;

namespace SRML.Patches
{
    [HarmonyPatch]
    [HarmonyPatch(typeof(AutoSaveDirector))]
    internal static class SaveGameLoadPatch
    {
        static MethodBase TargetMethod()
        {
            return typeof(AutoSaveDirector).GetMethod("PushSavedGame", AccessTools.all);
        }
        static void PostFix(AutoSaveDirector __instance)
        {
            // do something on save game loads
        }
    }
}
*/
