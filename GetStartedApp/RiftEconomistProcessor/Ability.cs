using RiftEconomistProcessor.Interfaces;
using RiftEconomistProcessor.Model;

namespace RiftEconomistProcessor;
public class Ability : IAbility
{
    public DamageType DamageType { get; set; }
    public double BaseDamage { get; set; }
    public double AbilityPowerScaling { get; set; }
    public double AttackDamageScaling { get; set; }
    public IChampion Champion { get; set; }

    /// <summary>
    /// returns the raw damage of the ability before resists
    /// </summary>
    /// <returns></returns>
    public DamageEvent CalculateDamage()
    {
        var damage = BaseDamage;
        damage += Champion.AttackDamage * AttackDamageScaling;
        damage += Champion.AbilityPower * AbilityPowerScaling;
        return new DamageEvent { DamageType = DamageType, DamageValue = damage };
    }
}
