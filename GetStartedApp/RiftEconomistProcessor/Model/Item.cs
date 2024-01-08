using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiftEconomistProcessor.Model;

public class Item : ICloneable
{
    public double AttackDamage { get; set; }
    public double AbilityPower { get; set; }
    public double Armor { get; set; }
    public double MagicResist { get; set; }
    public double Lethality { get; set; }
    public double ArmorPenetrationPercent { get; set; }
    public double MagicPenetration { get; set; }
    public double MagicPenetrationPercent { get; set; }

    public object Clone()
    {
        return MemberwiseClone();
    }
}
