using System.Collections.Generic;
using System.Net;

namespace SwissArmy
{
    public static class Settings
    {
        public static readonly string SOFTWARE_NAME = "SwissArmy";
        public static readonly string VERSION = "v1.0";
        public static WebClient client = null;

        public static readonly List<string> LOWERALPHA = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        public static readonly List<string> UPPERALPHA = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public static readonly List<string> NUMERIC = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    }
}
