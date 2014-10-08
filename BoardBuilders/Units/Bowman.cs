using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Units
{
    class Bowman:Unit
    {
        public Bowman()
        {
            //set cost to 5 food and 1 bow
            recruitCostList.Add(new Card(CARDTYPE.FOOD));
            recruitCostList.Add(new Card(CARDTYPE.FOOD));
            recruitCostList.Add(new Card(CARDTYPE.FOOD));
            recruitCostList.Add(new Card(CARDTYPE.FOOD));
            recruitCostList.Add(new Card(CARDTYPE.FOOD));

            recruitCostList.Add(new Card(CARDTYPE.BOW));

            //set movement, attack and defense points
            movementPoints = 1;
            defensePoints = 1;
            attackPoints = 1;
            range = 2;

            //set allowed actions
            allowedActions.Add(UNITACTION.MOVE);
            allowedActions.Add(UNITACTION.ATTACK);
        }
    }
}
