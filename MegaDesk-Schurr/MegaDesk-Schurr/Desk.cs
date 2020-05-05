using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Schurr
{
    public class Desk
    {

        public enum DesktopMaterial1
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }
        public Desk() { }



        public int Width { get; set; }

        public int Depth { get; set; }

        public int NumberOfDrawers { get; set; }
    }
}
