using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Buildings
{
    class Bowyer:Building
    {
        public Bowyer()
        {

            //set build cost to 6 wood and 3 stone
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));

            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));

            //set product
            product.Add(new Card(CARDTYPE.BOW));

            //set production cost
            productionCostList.Add(new Card(CARDTYPE.WOOD));
            productionCostList.Add(new Card(CARDTYPE.WOOD));
            productionCostList.Add(new Card(CARDTYPE.WOOD));

            //set needed build space
            buildPlace.Add(FIELDTYPE.EMPTY);
        }
    }
}
