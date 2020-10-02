using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk_Meim
{
    //list of material using enum method
    public enum SurfaceMaterial
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    };

    //Getter and Setter for width, depth and number of drawers

    class Desk
    {
        private int width, depth, numDrawers;
        public int Width { get { return width; } set { width = value; } }
        public int Depth { get { return depth; } set { depth = value; } }
        public int NumDrawers { get { return numDrawers; } set { numDrawers = value; } }
       
        public Desk(int w, int d, int nd)
        {
            Width = w;
            Depth = d;
            NumDrawers = nd;
        }
        //4 constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

       
    }
}
