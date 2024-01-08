using RiftEconomistProcessor.Interfaces;
using RiftEconomistProcessor.Model;

namespace RiftEconomistProcessor
{
    public class ValueCalculator
    {
        public double CalculateDamageIncrease(IChampion enemy, Item item)
        {
            //calculate the damage of the ability before the item is purchased
            var beforeDamage = CalculateNetDamage(100, enemy.MagicResist);
            //calculate the damage of the ability after the item is purchased
            var newMagicResist = enemy.MagicResist * (1 - item.MagicPenetrationPercent) - item.MagicPenetration;
            var afterDamage = CalculateNetDamage(100, newMagicResist);
            //return the percent increase
            return (afterDamage - beforeDamage) / beforeDamage;
        }

        public double CalculateNetDamage(double damage, double damageReductionStat)
        {
            if (damageReductionStat > 0)
            {
                return damage * (100 / (100 + damageReductionStat));
            }
            return damage * (2 - (100 / (100 - damageReductionStat)));
        }
    }
}
