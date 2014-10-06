using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders
{
    class Player
    {
        List<Card> hand;
        List<Unit> units;
        List<Building> buildings;


        public void startTurn()
        {
            evaluateBuildings();
        }

        private void evaluateBuildings()
        {

        }

        public void endTurn()
        {

        }
    }
}
