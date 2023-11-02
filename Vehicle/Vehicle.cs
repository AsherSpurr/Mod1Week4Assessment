using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//some changes
//Another Change

namespace Vehicle
{
    public class Vehicle
    {
        public int NumberOfWheels { get; }
        public string Color { get; private set;  } 
        public int MilesDriven { get; private set; }

        public Vehicle(int numberOfWheels, string color)
        {
            NumberOfWheels = numberOfWheels;
            Color = color;
            MilesDriven = 0;
        }

        public string Summary()
        {
            string summary = $"This {Color} vehicle has {NumberOfWheels} wheels, and has driven {MilesDriven} miles.";
            return summary;
        }

        public int Drive() //Had to edit this method to return int type - was getting error CS1503 before
        {
           int drive = MilesDriven += 5;
            return drive;
        }

        public string Paint(string newColor)
        {
            Color = newColor;
            return newColor;
        }
    }
}
