using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TransportPlan
{
    public enum TransportEnum
    {
        CAR,
        BUS,
        SUBWAY,
        BIKE,
        WALK
    }

    public static class TransportEnumExtensions
    {
        public static char GetChar(this TransportEnum transport)
        {
            switch (transport)
            {
                case TransportEnum.CAR: return 'C';
                case TransportEnum.BUS: return 'U';
                case TransportEnum.SUBWAY: return 'S';
                case TransportEnum.BIKE: return 'B';
                case TransportEnum.WALK: return 'W';
                default: throw new Exception("Unknown transport");
            }
        }

        public static ConsoleColor GetColor(this TransportEnum transport)
        {
            switch (transport)
            {
                case TransportEnum.CAR: return ConsoleColor.Black;
                case TransportEnum.BUS: return ConsoleColor.Blue;
                case TransportEnum.SUBWAY: return ConsoleColor.Magenta;
                case TransportEnum.BIKE: return ConsoleColor.Green;
                case TransportEnum.WALK: return ConsoleColor.Yellow;
                default: throw new Exception("Unknown transport");

            }
        }
    }

}
