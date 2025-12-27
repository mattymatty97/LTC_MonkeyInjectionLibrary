using System;
using BepInEx.Bootstrap;
using HarmonyLib;

namespace InjectionLibrary.Patches;

[HarmonyPatch(typeof(Chainloader))]
internal static class TerminationPatch
{
    [HarmonyPatch("ReplayPreloaderLogs")]
    [HarmonyFinalizer]
    internal static void TerminateAfterLogging()
    {
        Preloader.Log.LogFatal("An unrecoverable error occurred. Shutting down the process.");
        Environment.Exit(999);
    }
}