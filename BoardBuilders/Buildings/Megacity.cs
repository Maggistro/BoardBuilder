using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Buildings
{
    class Megacity:Settlement
    {
        public Megacity(int newID)
        {//settlements are created from the settler unit, thus no cost applies
            //set influence range
            range = 4;

            //set id
            ID = newID;

            //set space needed
            buildPlace.Add(FIELDTYPE.CITY);

            //set active per default
            isActive = true;

            //set effect to hold cards, produce civil units and give defence bonus
            BuildingEffect card11 = new BuildingEffect(SPECIALBUIDLINGEFFECT.CARDCOUNT, 11),
                recruitCiv = new BuildingEffect(SPECIALBUIDLINGEFFECT.CIVILUNITS, 1),
                defense = new BuildingEffect(SPECIALBUIDLINGEFFECT.DEFENSE, 30);
            effects.Add(card11);
            effects.Add(recruitCiv);
            effects.Add(defense);
            
        }
    }
}
