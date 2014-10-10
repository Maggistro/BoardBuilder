using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders
{
    enum CARDTYPE
    {
        NOCARD,WOOD,STONE,COAL,IRON,BOW,ARMOR,SWORD,FOOD,IRONORE
    }
    class Card
    {
        private CARDTYPE type;

        public Card(CARDTYPE newType)
        {
            this.type = newType;
        }

        public CARDTYPE getType()
        {
            return type;
        }

        public override string ToString()
        {
            return type.ToString();
        }

        public override bool Equals(object obj)
        {
            return ((Card)obj).getType() == this.type;
        }
    }
}
