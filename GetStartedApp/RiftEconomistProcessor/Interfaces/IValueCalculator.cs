using RiftEconomistProcessor.Model;

namespace RiftEconomistProcessor.Interfaces;

public interface IValueCalculator
{
    public double CalculateDamageIncrease(IChampion player, IChampion enemy, Item item, DamageType damageType);
}
