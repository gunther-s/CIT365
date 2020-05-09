using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Schurr
{
    public enum DesktopMaterial1
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    public class Desk
    {
        public const short MIN_WIDTH = 24;
        public const short MAX_WIDTH = 96;
        public const short MIN_DEPTH = 12;
        public const short MAX_DEPTH = 48;

        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public DesktopMaterial1 DesktopMaterial { get; set; }
    }
}
