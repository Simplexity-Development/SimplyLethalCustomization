using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyLethalCustomization
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class SimplyLethalCustomizationBase : BaseUnityPlugin
    {
        private const string modGUID = "SimplexityDev.SimplyLethalCustomization";
        private const string modName = "Simply Lethal Customization";
        private const string modVersion = "0.0.0.1";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static SimplyLethalCustomizationBase instance;

        internal ManualLogSource logger;

        void Awake()
        {
            if (instance == null) instance = this;
            logger = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            harmony.PatchAll();
        }
    }
}
