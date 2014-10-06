using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Buildings
{
    class Coalmine:Building
    {
        public Coalmine()
        {

            //set build cost to 7 wood and 4 stone
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));

            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));

            //set product
            product.Add(new Card(CARDTYPE.COAL));

            //set active per default
            isActive = true;

            //set needed build space
            buildPlace.Add(FIELDTYPE.COALMOUNTAIN);
        }
    }
}
