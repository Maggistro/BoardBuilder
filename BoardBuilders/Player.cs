using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders
{
    class Player
    {
        List<Card> hand = new List<Card>();
        List<Unit> units = new List<Unit>();
        List<Building> buildings = new List<Building>();

        public Player()
        {
            hand.Add(new Card(CARDTYPE.WOOD));
            hand.Add(new Card(CARDTYPE.WOOD));
        }

        public void startTurn()
        {
            evaluateBuildings();
        }

        private void evaluateBuildings()
        {
            foreach(Building element in buildings)
            {
                hand.AddRange(element.getProduct());  
            }
        }

        public void endTurn()
        {

        }

        public void addBuilding(Building newBuilding)
        {
            buildings.Add(newBuilding);
        }

        public bool pay(List<Card> cost)
        {
            bool foundAll = true;

            foreach (Card price in cost)
            {
                foundAll &= hand.Exists(i => price.getType() == i.getType());
            }

            if (foundAll)
            {
                hand.RemoveAll(i => cost.Contains(i));
            }
            return foundAll;
        }
    }
}
