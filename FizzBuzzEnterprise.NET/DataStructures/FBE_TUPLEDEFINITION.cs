/*
 * FizzBuzzEnterprise.NET
 * I was going to write a really long license at the start of this file, but we're too close to release to spend time on this
 * Lorem ipsum dolor sit amet,
 * consectetur adipiscing elit,
 * sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
 */

using System;

namespace FizzBuzzEnterprise.NET.DataStructures
{
    public class FBE_TUPLEDEFINITION<T1, T2> : FBE_IDEFINITION<Tuple<T1, T2>>
    {
        public T1 ONE;
        public T2 TWO;
        Tuple<T1, T2> FBE_IDEFINITION<Tuple<T1, T2>>.Evaluate()
        {
            return new Tuple<T1, T2>(ONE, TWO);
        }
    }
}
