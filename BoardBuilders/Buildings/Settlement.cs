using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Buildings
{
    class Settlement:SpecialBuilding
    {
        protected List<Building> buildingsInRange;
        protected int range;
        protected int ID;

        public Settlement()
        {

        }

        public Settlement(int newID)
        {
            //settlements are created from the settler unit, thus no cost applies
            //set influence range
            range = 1;

            //set id
            ID = newID;

            //set space needed
            buildPlace.Add(FIELDTYPE.EMPTY);

            //set active per default
            isActive = true;

            //set effect to hold cards, produce civil units and give defence bonus
            BuildingEffect card5 = new BuildingEffect(SPECIALBUIDLINGEFFECT.CARDCOUNT, 5),
                recruitCiv = new BuildingEffect(SPECIALBUIDLINGEFFECT.CIVILUNITS, 1),
                defense = new BuildingEffect(SPECIALBUIDLINGEFFECT.DEFENSE, 10);
            effects.Add(card5);
            effects.Add(recruitCiv);
            effects.Add(defense);
        }
    }
}
