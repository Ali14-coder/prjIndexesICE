using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjIndexesICE
{
    public class Planet
    {
        double planetMass;
        string planetName, planetType, planetColour;
        bool planetRings;

        public Planet(string planetName, string planetType, double planetMass, string planetColour, bool planetRings)
        {
            this.planetMass = planetMass;
            this.planetName = planetName;
            this.planetType = planetType;
            this.planetColour = planetColour;
            this.planetRings = planetRings;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.planetName;
                else if (index == 1)
                    return this.planetType;
                else if (index == 2)
                    return this.planetMass;
                else if (index == 3)
                    return this.planetColour;
                else if (index == 4)
                    return this.planetRings;
                return null; 
            }
            set
            {
                if (index == 0)
                    this.planetName = (string)value;
                else if (index == 1)
                    this.planetType = (string)value;
                else if (index == 2)
                    this.planetMass = (double)value;
                else if (index == 3)
                    this.planetColour = (string)value;
                else if (index == 4)
                    this.planetRings = (bool)value;
            }
        }

        public object this[string attrName] //allows you to call the attribute name via the string variable name. e.g. planet["planetName"] = "Earth" 
        {
            get
            {
                if (attrName.ToLower().Equals("planetname"))
                    return this.planetName;
                if (attrName.ToLower().Equals("planettype"))
                    return this.planetType;
                if (attrName.ToLower().Equals("planetmass"))
                    return this.planetMass;
                if (attrName.ToLower().Equals("planetcolour"))
                    return this.planetColour;
                if (attrName.ToLower().Equals("planetrings"))
                    return this.planetRings;
                return null;

            }

            set
            {
                if (attrName.ToLower().Equals("planetname"))
                    this.planetName = (string)value;
                if (attrName.ToLower().Equals("planettype"))
                    this.planetType = (string)value;
                if (attrName.ToLower().Equals("planetmass"))
                    this.planetMass = (double)value;
                if (attrName.ToLower().Equals("planetcolour"))
                    this.planetColour = (string)value;
                if (attrName.ToLower().Equals("planetrings"))
                    this.planetRings = (bool)value;
            }
        }
    }
}
