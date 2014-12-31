using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Units
{
    class Settler:Unit
    {
        public Settler()
        {
            //set cost to 3 food, 3 wood and 3 stone
            recruitCostList.Add(new Card(CARDTYPE.FOOD));
            recruitCostList.Add(new Card(CARDTYPE.FOOD));
            recruitCostList.Add(new Card(CARDTYPE.FOOD));

            recruitCostList.Add(new Card(CARDTYPE.WOOD));
            recruitCostList.Add(new Card(CARDTYPE.WOOD));
            recruitCostList.Add(new Card(CARDTYPE.WOOD));

            recruitCostList.Add(new Card(CARDTYPE.STONE));
            recruitCostList.Add(new Card(CARDTYPE.STONE));
            recruitCostList.Add(new Card(CARDTYPE.STONE));
            
            //set allowed spawns
            spawnPlace.Add(FIELDTYPE.GRASS);
            spawnPlace.Add(FIELDTYPE.CITY);
            spawnPlace.Add(FIELDTYPE.COALMOUNTAIN);
            spawnPlace.Add(FIELDTYPE.IRONMOUNTAIN);
            spawnPlace.Add(FIELDTYPE.MEGACITY);
            spawnPlace.Add(FIELDTYPE.MOUNTAIN);
            spawnPlace.Add(FIELDTYPE.WOODS);
            spawnPlace.Add(FIELDTYPE.SETTLEMENT);

            //set movement, attack and defense points
            movementPoints = 1;
            defensePoints = 1;
            attackPoints = 0;

            //set name
            name = "Settler";

            //set allowed actions
            allowedActions.Add(UNITACTION.MOVE);
            allowedActions.Add(UNITACTION.SETTLE);

        }

    }
}
