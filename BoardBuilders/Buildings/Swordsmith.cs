using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Buildings
{
    class Swordsmith:Building
    {
        public Swordsmith()
        {



            //set build cost to 5 wood and 5 stone
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

            //set product
            product.Add(new Card(CARDTYPE.SWORD));

            //set production cost
            productionCostList.Add(new Card(CARDTYPE.IRON));
            productionCostList.Add(new Card(CARDTYPE.COAL));

            //set needed build space
            buildPlace.Add(FIELDTYPE.EMPTY);
        }
    }
}
