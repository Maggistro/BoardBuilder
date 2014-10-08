using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Buildings
{
    class Woodcutter : Building
    {
        public Woodcutter()
        {
            //set build cost
            buildCostList.Add(new Card(CARDTYPE.WOOD));
            //set product
            product.Add(new Card(CARDTYPE.WOOD));
            //set active per default
            isActive = true;
            //set needed build space
            buildPlace.Add(FIELDTYPE.WOODS);
            //set name
            name = "Holzfäller";
        }

    }
}
