/*
 * FizzBuzzEnterprise.NET
 * I was going to write a really long license at the start of this file, but we're too close to release to spend time on this
 * Lorem ipsum dolor sit amet,
 * consectetur adipiscing elit,
 * sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
 */

using System;
using System.Linq;

namespace FizzBuzzEnterprise.NET.net.csharp.fbenterprise.utils.outputers
{
    public class ConsoleOutputer
    {
        public static string IDENTIFIER = "CONSOLE_OUTPUTER";

        internal void _output_string_of_characters(char[] chars) => _INTERNAL_output_string_of_characters(chars);
        internal void _INTERNAL_output_string_of_characters(char[] chars)
        {
            chars.ToList().ForEach((c) => { Console.Write(c); });
            Console.Write("\n");
        }
    }
}
