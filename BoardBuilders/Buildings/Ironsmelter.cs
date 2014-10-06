using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Buildings
{
    class Ironsmelter:Building
    {
        public Ironsmelter()
        {


            //set build cost to 4 wood and 4 stone
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
  
            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));

            //set product
            product.Add(new Card(CARDTYPE.IRON));

            //set production cost
            productionCostList.Add(new Card(CARDTYPE.IRONORE));
            productionCostList.Add(new Card(CARDTYPE.COAL));

            //set needed build space
            buildPlace.Add(FIELDTYPE.EMPTY);
        }
    }
}
