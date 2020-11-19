/*
 * FizzBuzzEnterprise.NET
 * I was going to write a really long license at the start of this file, but we're too close to release to spend time on this
 * Lorem ipsum dolor sit amet,
 * consectetur adipiscing elit,
 * sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
 */

using FizzBuzzEnterprise.NET.Builders;

namespace FizzBuzzEnterprise.NET.Factories
{
    public class IntegerBuilderFactory : IFactory<IntegerBuilder>
    {
        public string GivenName;
        public string GetGivenName() => GivenName;
        public void SetGivenName(string value) => GivenName = value;
        public IntegerBuilder ProduceNew() => new IntegerBuilder();
    }
}
