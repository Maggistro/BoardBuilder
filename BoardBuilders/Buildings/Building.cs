using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders
{
    class Building
    {
        //init all building components
        protected List<Card> buildCostList = new List<Card>();
        protected List<Card> product = new List<Card>();
        protected bool isActive = false;
        protected List<Card> productionCostList = new List<Card>();
        protected List<FIELDTYPE> buildPlace = new List<FIELDTYPE>();

        //do some stuff the moment the building is placed
        public void build()
        {
            
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
            isActive = isActive^isActive;
        }

        public bool getActive()
        {
            return isActive;
        }

        public List<FIELDTYPE> getBuildPlace()
        {
            return buildPlace;
        }

    }
}
