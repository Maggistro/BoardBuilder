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
    }
}
