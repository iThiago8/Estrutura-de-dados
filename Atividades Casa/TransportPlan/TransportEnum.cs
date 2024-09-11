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
                case TransportEnum.BIKE: return 'B';
                default: return 'W';
            }
        }

        public static ConsoleColor GetColor(this TransportEnum transport)
        {
            switch (transport)
            {
                case TransportEnum.CAR: return 'C';
                case TransportEnum.BUS: return 'U';
                case TransportEnum.BIKE: return 'B';
                default: return 'W';
            }
        }
    }

}
