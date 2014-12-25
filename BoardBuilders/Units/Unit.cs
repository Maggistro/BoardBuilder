using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders
{
    enum UNITACTION
    {
        NONE, ATTACK, SETTLE, MOVE, SCOUT
    }

    class Unit
    {
        //init all unit components
        protected List<Card> recruitCostList = new List<Card>();
        protected List<UNITACTION> allowedActions = new List<UNITACTION>();
        protected List<FIELDTYPE> spawnPlace = new List<FIELDTYPE>();
        protected int movementPoints = 0;
        protected int attackPoints = 0;
        protected int defensePoints = 0;
        protected int range = 0;
        protected int[] position = new int[2];
        protected string name = "";


        public void rectruit(int x, int y)
        {
            position = new int[2] { x, y };
        }

        //return costs for recruiting
        public List<Card> getRecruitmentCost()
        {
            return recruitCostList;
        }

        public List<FIELDTYPE> getSpawningPlace()
        {
            return spawnPlace;
        }

        //return movement points
        public int getMovementPoints()
        {
            return movementPoints;
        }

        //return attack points
        public int getAttackPoints()
        {
            return attackPoints;
        }

        //return defense points
        public int getDefensePoints()
        {
            return defensePoints;
        }

        //set defense points
        public void setDefensePoints(int newDefensePoints)
        {
            defensePoints = newDefensePoints;
        }

        //return position
        public int[] getPosition()
        {
            return position;
        }

        //return allowed actions
        public List<UNITACTION> getAllowedActions()
        {
            return allowedActions;
        }


        public string getName()
        {
            return name;
        }
    }
}
