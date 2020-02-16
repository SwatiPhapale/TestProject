using System;
using System.Collections.Generic;
using System.Text;

namespace ParsetheParcel
{
    public interface IParseTheParcel
    {
        decimal CalculateParcelCost(int Length, int Breadth, int Height, double Weight);
    }
    public struct Dimension
    {
        public int length { get; set; }

        public int breadth { get; set; }

        public int height { get; set; }


        public Dimension(int Length, int Breadth, int Height)
        {
            length = Length;
            breadth = Breadth;
            height = Height;
        }
    }

}
