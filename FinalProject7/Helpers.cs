using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject7;
internal static class Helpers
{
    public static void ClearCurrentConsoleLine(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, y);
        Console.Write("Ввод: ");
    }
}

