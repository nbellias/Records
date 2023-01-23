using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records.MyCommonClassLibrary
{
    public class Utility
    {
        public static void WriteTitle(string message)
        {
            int screenWidth = Console.WindowWidth;
            int stringWidth = message.Length;
            int spaces = (screenWidth / 2) + (stringWidth / 2);
            Console.SetCursorPosition(spaces, Console.CursorTop);
            Console.WriteLine(message);
        }
    }
}
