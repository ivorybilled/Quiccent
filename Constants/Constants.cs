using System.Collections.Generic;
using System.Windows.Forms;

namespace Quiccent.Constants
{
    public static class Constants
    {
        public const int WM_HOTKEY_MSG_ID = 0x0312;

        public const int JustTilde = 0;

        public const int TildeAndShift = 1;

        public static readonly Dictionary<Keys, string> PossibleAccentedKeys = new Dictionary<Keys, string>()
        {
            { Keys.None, string.Empty },
            { Keys.E, "e" },
            { Keys.S, "s" },
            { Keys.A, "a" },
            { Keys.C, "c" },
            { Keys.N, "n" },
            { Keys.U, "u" },
            { Keys.I, "i" },
            { Keys.O, "o" }
        };

        public static readonly Dictionary<Keys, string> PossibleCapitalizedAccentedKeys = new Dictionary<Keys, string>()
        {
            { Keys.None, string.Empty },
            { Keys.E, "E" },
            { Keys.S, "S" },
            { Keys.A, "A" },
            { Keys.C, "C" },
            { Keys.N, "N" },
            { Keys.U, "U" },
            { Keys.I, "I" },
            { Keys.O, "O" }
        };
    }
}
