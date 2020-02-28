using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorMegaDesk.Models
{
    public class Desk
    {
        public int ID { get; set; }
        // Desk Variable Declarations
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public string DeskMaterial { get; set; }

        // Desk Constraints
        public const int MINWIDTH = 24; // 24 inches.
        public const int MAXWIDTH = 96; // 96 inches.
        public const int MINDEPTH = 12; // 12 inches.
        public const int MAXDEPTH = 48; // 48 inches.
        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 7;
    }

    //public enum SurfaceMaterial
    //{
    //    Laminate,
    //    Oak,
    //    Rosewood,
    //    Veneer,
    //    Pine
    //};
}