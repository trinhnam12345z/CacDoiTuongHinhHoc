using System;
using System.Collections.Generic;
using System.Text;

namespace BtKeThua
{
    public class Shape
    {
        public string color = "green";
        public bool filled = true;

        public Shape()
        {

        }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public String getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public bool GetFilled()
        {
            return filled;
        }

        public void setFilled(bool filled)
        {
            this.filled = filled;
        }

        public override string ToString()
        {
            return "A Shape with color of " + getColor() + " and " + (GetFilled() ? "filled" : "not filled");
        }

        




    }
}
