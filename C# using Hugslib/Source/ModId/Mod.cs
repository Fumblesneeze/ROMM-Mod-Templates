using HarmonyLib;
using HugsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace {ModId}
{
    public class Mod : ModBase
    {
        public override string ModIdentifier { get; } = "{ModId}";

        public override void Initialize()
        {
            var harmony = new Harmony("{ModId}");
            harmony.PatchAll();
        }
    }
}
