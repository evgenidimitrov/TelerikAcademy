﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
#if DEBUG
        Console.SetIn(new System.IO.StreamReader("../../input.txt"));
#endif

        Console.WriteLine((long)Math.Pow(2, Regex.Matches(Console.ReadLine(), @"\*").Count));
    }
}
