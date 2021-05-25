using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1
{
    class Car
    {

        public string Make;
        public string Model;
        public decimal Value;
        public int Year;
        public string Color;

        public override string ToString()
        {
            return "Make: " + Make + "  Model: " + Model + "  Value: " + Value + "  Year: " + Year + "  Color: " + Color;
        }
        public override bool Equals(object obj)
        {
           
            return base.Equals(obj);
        }


    }
}
