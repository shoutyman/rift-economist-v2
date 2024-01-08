using RiftEconomistProcessor.Interfaces;
using System;
using System.Reflection.Metadata.Ecma335;

namespace RiftEconomistProcessor.Model;
public class Champion : IChampion, ICloneable
{
    public double MaxHealth { get; set; }
    public double AttackDamage { get; set; }
    public double AbilityPower { get; set; }
    public double Armor { get; set; }
    public double MagicResist { get; set; }
    public double ArmorPenetration { get; set; }
    public double PercentArmorPenetration { get; set; }
    public double MagicPenetration { get; set; }
    public double PercentMagicPenetration { get; set; }

    public ICollection<Item> Items { get; set; } = new List<Item>();

    public void AddItem(Item item)
    {
        Items.Add(item);
    }

    public object Clone()
    {
        var newItemList = new List<Item>();
        foreach (var item in Items)
        {
            newItemList.Add((Item)item.Clone());
        }
        return new Champion
        {
            MaxHealth = MaxHealth,
            AttackDamage = AttackDamage,
            AbilityPower = AbilityPower,
            Armor = Armor,
            MagicResist = MagicResist,
            ArmorPenetration = ArmorPenetration,
            PercentArmorPenetration = PercentArmorPenetration,
            MagicPenetration = MagicPenetration,
            PercentMagicPenetration = PercentMagicPenetration,
            Items = newItemList
        };
    }

    public bool TryRemoveItem(Item item)
    {
        return Items.Remove(item);
    }
}
