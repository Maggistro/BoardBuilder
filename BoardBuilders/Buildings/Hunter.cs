using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Buildings
{
    class Hunter:Building
    {
        public Hunter()
        {

            //set build cost to 5 wood
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            buildCostList.Add(new Card(CARDTYPE.WOOD));

            //set product
            product.Add(new Card(CARDTYPE.FOOD));

            //set active per default
            isActive = true;


            //set needed build space
            buildPlace.Add(FIELDTYPE.WOODS);
        }
    }
}
