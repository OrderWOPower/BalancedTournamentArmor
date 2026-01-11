using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace BalancedTournamentArmor
{
    public class BalancedTournamentArmorSettings : AttributeGlobalSettings<BalancedTournamentArmorSettings>
    {
        public override string Id => "BalancedTournamentArmor";

        public override string DisplayName => "Balanced Tournament Armor";

        public override string FolderName => "BalancedTournamentArmor";

        public override string FormatType => "json2";

        [SettingPropertyBool("{=BTA03}Toggle Change Armor", Order = 0, RequireRestart = false, HintText = "{=BTA04}Change armor of tournament participants. Enabled by default.", IsToggle = true)]
        [SettingPropertyGroup("{=BTA02}Change Armor", GroupOrder = 0)]
        public bool ShouldChangeArmor { get; set; } = true;

        [SettingPropertyInteger("{=BTA05}Troop Tier", 1, 7, "0", Order = 1, RequireRestart = false, HintText = "{=BTA06}Troop tier for armor worn by tournament participants. Default is 1.")]
        [SettingPropertyGroup("{=BTA02}Change Armor", GroupOrder = 0)]
        public int TroopTier { get; set; } = 1;
    }
}
