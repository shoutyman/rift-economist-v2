using RiftEconomistProcessor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiftEconomistProcessor.Interfaces;
public interface IChampion
{
    public double MaxHealth { get; }
    public double AttackDamage { get; }
    public double AbilityPower { get;}
    public double Armor { get; }
    public double MagicResist { get; }
    public double ArmorPenetration { get; }
    public double PercentArmorPenetration { get; }
    public double MagicPenetration { get;}
    public double PercentMagicPenetration { get; }
    public ICollection<Item> Items { get; }
    public void AddItem(Item item);
    public bool TryRemoveItem(Item item);
}
