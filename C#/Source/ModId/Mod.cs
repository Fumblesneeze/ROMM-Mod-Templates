using Harmony;
using System;
using Verse;

namespace {ModId}
{
    public class Mod : Verse.Mod
    {
        public Mod(ModContentPack content) : base(content)
        {
            var harmony = HarmonyInstance.Create("{Author}.{ModId}");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
