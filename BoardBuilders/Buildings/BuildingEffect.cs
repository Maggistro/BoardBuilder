using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardBuilders.Buildings
{
    enum SPECIALBUIDLINGEFFECT
    {
        NONE,CARDCOUNT, STREET, CIVILUNITS, MILITARYUNITS,DEFENSE
    }

    //class contains a special effect type and an integer defyning the intensity or impact of said effect
    class BuildingEffect
    {
        //private variables
        private SPECIALBUIDLINGEFFECT effect;
        private int impact;

        //standart constructor
        public BuildingEffect()
        {
            effect = SPECIALBUIDLINGEFFECT.NONE;
            impact = 0;
        }

        //constructor for initating effect and impact
        public BuildingEffect(SPECIALBUIDLINGEFFECT newEffect, int effectImpact)
        {
            this.effect = newEffect;
            this.impact = effectImpact;
        }

        public SPECIALBUIDLINGEFFECT getEffect()
        {
            return effect;
        }

        public int getImpact()
        {
            return impact;
        }

    }
}
