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
        string name = "";

        //init player with 2 wood cards and name
        public Player(string newName)
        {
            hand.Add(new Card(CARDTYPE.WOOD));
            hand.Add(new Card(CARDTYPE.WOOD));
            hand.Add(new Card(CARDTYPE.WOOD));
            hand.Add(new Card(CARDTYPE.WOOD));
            hand.Add(new Card(CARDTYPE.WOOD));
            hand.Add(new Card(CARDTYPE.WOOD));
            hand.Add(new Card(CARDTYPE.WOOD));
            hand.Add(new Card(CARDTYPE.WOOD));
            hand.Add(new Card(CARDTYPE.WOOD));
            hand.Add(new Card(CARDTYPE.WOOD));
            hand.Add(new Card(CARDTYPE.STONE));
            hand.Add(new Card(CARDTYPE.STONE));
            hand.Add(new Card(CARDTYPE.STONE));
            hand.Add(new Card(CARDTYPE.STONE));
            hand.Add(new Card(CARDTYPE.STONE));
            hand.Add(new Card(CARDTYPE.STONE));
            hand.Add(new Card(CARDTYPE.STONE));
            hand.Add(new Card(CARDTYPE.STONE));
            hand.Add(new Card(CARDTYPE.STONE));
            hand.Add(new Card(CARDTYPE.STONE));
            name = newName;
        }

        //start turn action ( e.g. get ressources)
        public void startTurn()
        {
            evaluateBuildings();
        }

        //get all ressources from buildings as new hand cards
        private void evaluateBuildings()
        {
            foreach(Building element in buildings)
            {
                hand.AddRange(element.getProduct());  
            }
        }

        //end turn actions
        public void endTurn()
        {

        }

        //return player name
        public string getName()
        {
            return name;
        }

        //add building to players building list
        public void addBuilding(Building newBuilding)
        {
            buildings.Add(newBuilding);
        }

        public List<Card> getHand()
        {
            return hand;
        }

        //adds one card
        public void addCard(Card newCard)
        {
            hand.Add(newCard);
        }

        //adds a range of cards
        public void addCard(List<Card> newCards)
        {
            hand.AddRange(newCards);
        }

        //check if player can pay for building, and if so, remove cards to pay for it
        public bool pay(List<Card> cost)
        {
            bool foundAll = true;

            foreach (Card price in cost) //check if enough ressources
            {
                foundAll &= hand.Exists(i => price.getType() == i.getType());
            }

            if (foundAll) //if all ressources found, remove them from hand
            {
                foreach (Card price in cost) //check if enough ressources
                {
                    hand.Remove(price);
                }
            }
            return foundAll;
        }
    }
}
