﻿/*
 * FizzBuzzEnterprise.NET
 * I was going to write a really long license at the start of this file, but we're too close to release to spend time on this
 * Lorem ipsum dolor sit amet,
 * consectetur adipiscing elit,
 * sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
 */

namespace FizzBuzzEnterprise.NET.Factories
{
    public interface IFactory<T>
    {
        public string GetGivenName();
        public void SetGivenName(string value);
        public T ProduceNew();
    }
}
