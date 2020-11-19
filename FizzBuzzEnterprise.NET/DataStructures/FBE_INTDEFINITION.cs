/*
 * FizzBuzzEnterprise.NET
 * I was going to write a really long license at the start of this file, but we're too close to release to spend time on this
 * Lorem ipsum dolor sit amet,
 * consectetur adipiscing elit,
 * sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
 */

using FizzBuzzEnterprise.NET.Builders;
using FizzBuzzEnterprise.NET.Factories;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace FizzBuzzEnterprise.NET.DataStructures
{
    public class FBE_INTDEFINITION : FBE_IDEFINITION<int>
    {
        public enum FIZZBUZZENTERPRISENET_OPERANDS
        {
            FBE_ADD,
            FBE_SUBTRACT,
            FBE_MULTIPLY
        }
        public enum FIZZBUZZENTERPRISENET_NUMBERS
        {
            FBE_ZERO,
            FBE_ONE,
            FBE_TWO
        }
        public enum FIZZBUZZENTERPRISENET_BOOL
        {
            FBE_FALSE,
            FBE_TRUE
        }
        protected List<Tuple<FIZZBUZZENTERPRISENET_OPERANDS, FIZZBUZZENTERPRISENET_NUMBERS>> ACTIONCHAIN = new List<Tuple<FIZZBUZZENTERPRISENET_OPERANDS, FIZZBUZZENTERPRISENET_NUMBERS>>();
        public void FBE_REGISTERACTION(FIZZBUZZENTERPRISENET_OPERANDS operand, FIZZBUZZENTERPRISENET_NUMBERS number)
        {
            FactoryFactory MASTERFACTORY = new FactoryFactory();
            ACTIONCHAIN.Add(((FBE_IDEFINITION<Tuple<FIZZBUZZENTERPRISENET_OPERANDS, FIZZBUZZENTERPRISENET_NUMBERS>>)TupleBuilder<FIZZBUZZENTERPRISENET_OPERANDS, FIZZBUZZENTERPRISENET_NUMBERS>.@new<FIZZBUZZENTERPRISENET_OPERANDS, FIZZBUZZENTERPRISENET_NUMBERS>(MASTERFACTORY).item1(operand, MASTERFACTORY).item2(number, MASTERFACTORY).Build()).Evaluate());
        }
        int FBE_IDEFINITION<int>.Evaluate()
        {
            int RETURN_VALUE = 0;
            for (int i = 0; i < ACTIONCHAIN.Count; i++)
            {
                if (ACTIONCHAIN[i].Item1 == FIZZBUZZENTERPRISENET_OPERANDS.FBE_ADD)
                {
                    RETURN_VALUE += (int)ACTIONCHAIN[i].Item2;
                }
                else if (ACTIONCHAIN[i].Item1 == FIZZBUZZENTERPRISENET_OPERANDS.FBE_SUBTRACT)
                {
                    RETURN_VALUE -= (int)ACTIONCHAIN[i].Item2;
                }
                else if (ACTIONCHAIN[i].Item1 == FIZZBUZZENTERPRISENET_OPERANDS.FBE_MULTIPLY)
                {
                    RETURN_VALUE *= (int)ACTIONCHAIN[i].Item2;
                }
            }
            return RETURN_VALUE;
        }
    }
}
