using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Buildings
{
    class SpecialBuilding:Building
    {
        //effect type list
        protected List<BuildingEffect> effects = new List<BuildingEffect>();

        public List<BuildingEffect> getEffects()
        {
            if (isActive)
                return effects;
            else
                return new List<BuildingEffect>();
        }
    }
}
