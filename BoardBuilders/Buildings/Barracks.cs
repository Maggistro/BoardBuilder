using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Buildings
{
    class Barracks:SpecialBuilding
    {
        public Barracks()
        {
            //set build cost to 5 wood and 10 stone
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));

            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));

            //set active per default
            isActive = true;

            //set needed build space
            buildPlace.Add(FIELDTYPE.EMPTY);
            buildPlace.Add(FIELDTYPE.EMPTY);
            buildPlace.Add(FIELDTYPE.EMPTY);
            buildPlace.Add(FIELDTYPE.EMPTY);

            //set effect to recruiting military units
            BuildingEffect recruitMil = new BuildingEffect(SPECIALBUIDLINGEFFECT.MILITARYUNITS, 1);
            effects.Add(recruitMil);
        }
    }
}
