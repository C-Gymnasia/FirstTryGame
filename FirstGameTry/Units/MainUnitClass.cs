using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameTry.Units
{
    public abstract class MainUnitClass
    {
        public abstract int HP { get; set; }
        public abstract string Name { get; set; }
        public abstract int Damage { get; set; }
        public abstract int Cost { get; set; }
        public abstract int RadiusAttack { get; set; }
        public abstract char ItemView { get; set; }
    }
}
