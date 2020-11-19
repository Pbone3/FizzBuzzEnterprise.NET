/*
 * FizzBuzzEnterprise.NET
 * I was going to write a really long license at the start of this file, but we're too close to release to spend time on this
 * Lorem ipsum dolor sit amet,
 * consectetur adipiscing elit,
 * sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
 */

using System;
using System.Runtime.InteropServices;
using System.Threading;
using FizzBuzzEnterprise.NET.Builders;
using FizzBuzzEnterprise.NET.DataStructures;
using FizzBuzzEnterprise.NET.Factories;
using FizzBuzzEnterprise.NET.net.csharp.fbenterprise.utils.outputers;

namespace FizzBuzzEnterprise.NET
{
    class Program
    {
        public const int FIZZBUZZENTERPRISE_ITERATIONAMOUNTS = 100;
        public const string FIZZ = "FIZZ";
        public const string BUZZ = "BUZZ";
        static void Main()
        {
            IntPtr MEMLOC_MEMTEST = Marshal.AllocHGlobal(sizeof(byte));
            Marshal.WriteByte(MEMLOC_MEMTEST, byte.MaxValue);
            if (Marshal.ReadByte(MEMLOC_MEMTEST) == byte.MaxValue)
            {
                Marshal.FreeHGlobal(MEMLOC_MEMTEST);
                FactoryFactory MasterObjectProducer = new FactoryFactory();
                IntegerBuilderFactory IntegerBuilderProducer = MasterObjectProducer.func_produce_new_object_of_type<IntegerBuilderFactory>();
                IntegerBuilderProducer.SetGivenName("TODO: NAME THIS");
                ConsoleOutputer Outputer = MasterObjectProducer.func_produce_new_object_of_type<ConsoleOutputer>();
                for (int i = 0; i < FIZZBUZZENTERPRISE_ITERATIONAMOUNTS; i++)
                {
                    IntegerBuilder IntBuilder = IntegerBuilderProducer.ProduceNew();
                    IntBuilder.INIT();
                    while (true)
                    {
                        if (((FBE_IDEFINITION<int>)(IntBuilder.Build())).Evaluate() == i)
                            break;
                        IntBuilder.INTEGER_BUILDER_PLUSONE();
                    }
                    string ConsoleOutput = "";
                    if (((FBE_IDEFINITION<int>)(IntBuilder.Build())).Evaluate() % 3 == 0)
                    {
                        ConsoleOutput += FIZZ;
                    }
                    if (((FBE_IDEFINITION<int>)(IntBuilder.Build())).Evaluate() % 5 == 0)
                    {
                        ConsoleOutput += BUZZ;
                    }
                    Outputer._output_string_of_characters((ConsoleOutput.Equals("") ? i.ToString() : ConsoleOutput).ToCharArray());
                    System.Threading.Thread.Sleep(100);
                }
                Console.ReadKey();
            }
        }
    }
}
