using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Buildings
{
    class Storage:SpecialBuilding
    {
        public Storage()
        {
            //set build cost to 4 stone
            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));

            //set active per default
            isActive = true;

            //set needed build space
            buildPlace.Add(FIELDTYPE.EMPTY);

            //set effect to hold 10 more cards
            BuildingEffect card10 = new BuildingEffect(SPECIALBUIDLINGEFFECT.CARDCOUNT, 10);
            effects.Add(card10);
        }
    }
}
