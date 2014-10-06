using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Buildings
{
    class Stonemason:Building
    {
        public Stonemason()
        {
            //set building cost to 3 wood
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));

            //set product
            product.Add(new Card(CARDTYPE.STONE));

            //set active per default
            isActive = true;

            //set needed build space
            buildPlace.Add(FIELDTYPE.MOUNTAIN);
        }
    }
}
