using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        internal int name;
        internal Element element;



        internal void UseOn(ConsoleMon target, ConsoleMon caster) 
        {
            if (target.weakness == element)
            {
                target.TakeDamage(this.damage/2);
            }
            caster.DepleteEnergy(this.energyCost);
            target.TakeDamage(this.damage);
        }
    }
}
