using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardBuilders
{
    public enum FIELDTYPE
	{
	   EMPTY, GRASS, MOUNTAIN, WATER, WOODS, COALMOUNTAIN, IRONMOUNTAIN,SETTLEMENT,VILLAGE,CITY,MEGACITY   
	}

    class Field
    {
        public FIELDTYPE type;
        public Unit unit;
        public Building building;

        public Field(){
            type = FIELDTYPE.EMPTY;
            unit = new Unit();
            building = new Building();
        }

        public Field(int newType){
            type = (FIELDTYPE)newType;
            unit = new Unit();
            building = new Building();        
        }

    }
}
