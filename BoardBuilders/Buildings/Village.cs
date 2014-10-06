using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders.Buildings
{
    class Village:Settlement
    {
        public Village(int newID)
        {//settlements are created from the settler unit, thus no cost applies
            //set influence range
            range = 2;

            //set id
            ID = newID;

            //set space needed
            buildPlace.Add(FIELDTYPE.SETTLEMENT);

            //set active per default
            isActive = true;

            //set effect to hold cards, produce civil units and give defence bonus
            BuildingEffect card7 = new BuildingEffect(SPECIALBUIDLINGEFFECT.CARDCOUNT, 7),
                recruitCiv = new BuildingEffect(SPECIALBUIDLINGEFFECT.CIVILUNITS, 1),
                defense = new BuildingEffect(SPECIALBUIDLINGEFFECT.DEFENSE, 15);
            effects.Add(card7);
            effects.Add(recruitCiv);
            effects.Add(defense);

        }
    }
}
