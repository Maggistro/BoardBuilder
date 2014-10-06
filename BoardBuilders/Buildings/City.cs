using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Buildings
{
    class City:Settlement
    {
        public City(int newID)
        {
            //settlements are created from the settler unit, thus no cost applies
            //set influence range
            range = 3;

            //set id
            ID = newID;

            //set space needed
            buildPlace.Add(FIELDTYPE.VILLAGE);

            //set active per default
            isActive = true;

            //set effect to hold cards, produce civil units and give defence bonus
            BuildingEffect card9 = new BuildingEffect(SPECIALBUIDLINGEFFECT.CARDCOUNT, 9),
                recruitCiv = new BuildingEffect(SPECIALBUIDLINGEFFECT.CIVILUNITS, 1),
                defense = new BuildingEffect(SPECIALBUIDLINGEFFECT.DEFENSE, 20);
            effects.Add(card9);
            effects.Add(recruitCiv);
            effects.Add(defense);
        }
    }
}
