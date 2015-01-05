using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders
{
    enum BUILDINGACTION
    {
        NONE, DESTROY, REPAIR, TOGGLEPRODUKTION, UPGRADE
    }
    class Building
    {
        //init all building components
        protected List<Card> buildCostList = new List<Card>();
        protected List<Card> product = new List<Card>();
        protected bool isActive,damaged = false;
        protected List<Card> productionCostList = new List<Card>();
        protected List<BUILDINGACTION> allowedActions = new List<BUILDINGACTION>();
        protected List<FIELDTYPE> buildPlace = new List<FIELDTYPE>();
        protected int[] position = new int[2];
        protected string name = "";

        //return allowed actions
        public List<BUILDINGACTION> getAllowedActions()
        {
            return allowedActions;
        }

        //place building at position newPos
        public void build(int x, int y)
        {
            position = new int[2]{x,y};
        }

        //return costs for build building
        public List<Card> getBuildCost()
        {
            return buildCostList;
        }

        //return product produced by the building if building is active
        public List<Card> getProduct()
        {
            if (isActive)
                return product;
            else
                return new List<Card>();
        }

        //toggle if building is active
        public void toggleActive()
        {
            if (!damaged)
            {
                isActive = !isActive;
            }
        }

        public bool getActive()
        {
            return isActive;
        }

        public List<FIELDTYPE> getBuildPlace()
        {
            return buildPlace;
        }

        public string getName()
        {
            return name;
        }

        //returns current repair cost needed to fix building ( half the build cost from the start )
        public List<Card> getRepairCost()
        {
            return this.getBuildCost().GetRange(0, buildCostList.Count/2);
        }

        //repair building
        internal void repair()
        {
            this.damaged = false;
            toggleActive();
        }
    }
}
