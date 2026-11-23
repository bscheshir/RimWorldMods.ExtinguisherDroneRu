using Verse;
using RimWorld;

namespace ExtinguisherDroneRu
{
    [StaticConstructorOnStartup]
    public static class PowerCellTranslator
    {
        static PowerCellTranslator()
        {
            var def = DefDatabase<ThingDef>.GetNamedSilentFail("Drone_FirefoamPopper");
            var comp = def?.GetCompProperties<CompProperties_MechPowerCell>();
            if (comp != null)
            {
                if ("ExtinguisherDrone.BatteryLabel".CanTranslate())
                    comp.labelOverride = "ExtinguisherDrone.BatteryLabel".Translate();
                if ("ExtinguisherDrone.BatteryTooltip".CanTranslate())
                    comp.tooltipOverride = "ExtinguisherDrone.BatteryTooltip".Translate();
            }
        }
    }
}
