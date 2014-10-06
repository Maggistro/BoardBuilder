using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Buildings
{
    class Street:SpecialBuilding
    {
        public Street()
        {
            //set build cost to 1 stone
            buildCostList.Add(new Card(CARDTYPE.STONE));

            //set active per default
            isActive = true;

            //set needed build space 
            //TODO: think of something

            //set effect to be a street beetween to fields
            BuildingEffect street = new BuildingEffect(SPECIALBUIDLINGEFFECT.STREET, 0);
            effects.Add(street);
        }
    }
}
