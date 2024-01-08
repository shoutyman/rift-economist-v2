using RiftEconomistProcessor.Interfaces;

namespace RiftEconomistProcessor.Model;
public class DamageEvent : IDamageEvent
{
    public Champion Source { get; set; }
    public Champion Target { get; set; }
    public DamageType DamageType { get; set; }
    public double DamageValue { get; set; }

    //Damage formulas taken from LoL Fandom: https://leagueoflegends.fandom.com/wiki/Magic_resistance
    //Formulas are current as of 1/7/2024
    public double GetNetDamage()
    {
        switch (DamageType)
        {
            case DamageType.Physical:
                var netArmor = (1 - Source.PercentArmorPenetration) * Target.Armor - Source.ArmorPenetration;
                if (netArmor > 0)
                {
                    return 100 / (100 + netArmor);
                }
                return 2 - (100 / (100 - netArmor));
            case DamageType.Magic:
                var netMagicResist = (1 - Source.PercentMagicPenetration) * Target.MagicResist - Source.MagicPenetration;
                if (netMagicResist > 0)
                {
                    return 100 / (100 + netMagicResist);
                }
                return 2 - (100 / (100 - netMagicResist));
            default:
                return DamageValue;
        }
    }
}
