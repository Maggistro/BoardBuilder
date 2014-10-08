using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Units
{
    class Scout:Unit
    {
        public Scout()
        {
            //set cost to 4 food
            recruitCostList.Add(new Card(CARDTYPE.FOOD));
            recruitCostList.Add(new Card(CARDTYPE.FOOD));
            recruitCostList.Add(new Card(CARDTYPE.FOOD));
            recruitCostList.Add(new Card(CARDTYPE.FOOD));

            //set movement, attack and defense points
            movementPoints = 2;
            defensePoints = 1;
            attackPoints = 0;

            //set allowed actions
            allowedActions.Add(UNITACTION.MOVE);
            allowedActions.Add(UNITACTION.SCOUT);
        }
    }
}
