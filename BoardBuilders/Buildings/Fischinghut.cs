using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Buildings
{
    class Fischinghut:Building
    {
        public Fischinghut()
        {
            //set build cost to 5 wood and 2 stone
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));

            buildCostList.Add(new Card(CARDTYPE.STONE));
            buildCostList.Add(new Card(CARDTYPE.STONE));

            //set product
            product.Add(new Card(CARDTYPE.FOOD));
            product.Add(new Card(CARDTYPE.FOOD));

            //set active per default
            isActive = true;

            //set needed build space
            buildPlace.Add(FIELDTYPE.GRASS);
            buildPlace.Add(FIELDTYPE.WATER);
        }
    }
}
