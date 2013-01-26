﻿using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        {
            for (int i; (i = input.Read()) != -1; ) // Read char by char
            {
                if (i == '>' && input.Peek() != '<') // Inside text node
                {
                    string text = String.Empty;

                    while ((i = input.Read()) != '<' && i != -1) text += (char)i;

                    if (!String.IsNullOrWhiteSpace(text)) Console.WriteLine(text);
                }
            }
        }
    }
}
