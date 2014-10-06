using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Units
{
    class Swordsman:Unit
    {
        public Swordsman(int[] position)
            : base(position)
        {
            //set cost to 5 food and 1 bow
            recruitCostList.Add(new Card(CARDTYPE.FOOD));
            recruitCostList.Add(new Card(CARDTYPE.FOOD));
            recruitCostList.Add(new Card(CARDTYPE.FOOD));
            recruitCostList.Add(new Card(CARDTYPE.FOOD));
            recruitCostList.Add(new Card(CARDTYPE.FOOD));
            recruitCostList.Add(new Card(CARDTYPE.FOOD));

            recruitCostList.Add(new Card(CARDTYPE.SWORD));

            recruitCostList.Add(new Card(CARDTYPE.ARMOR));

            //set movement, attack and defense points
            movementPoints = 1;
            defensePoints = 4;
            attackPoints = 2;
            range = 1;

            //set allowed actions
            allowedActions.Add(UNITACTION.MOVE);
            allowedActions.Add(UNITACTION.ATTACK);
        }
    }
}
