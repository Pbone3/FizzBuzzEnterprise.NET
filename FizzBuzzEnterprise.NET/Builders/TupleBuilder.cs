/*
 * FizzBuzzEnterprise.NET
 * I was going to write a really long license at the start of this file, but we're too close to release to spend time on this
 * Lorem ipsum dolor sit amet,
 * consectetur adipiscing elit,
 * sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
 */

using FizzBuzzEnterprise.NET.DataStructures;
using FizzBuzzEnterprise.NET.Factories;
using System;

namespace FizzBuzzEnterprise.NET.Builders
{
    public class TupleBuilder<T1, T2>
    {
        public FBE_TUPLEDEFINITION<T1, T2> payload = new FBE_TUPLEDEFINITION<T1, T2>();

        public static TupleBuilder<LT1, LT2> @new<LT1, LT2>(FactoryFactory producer) {
            return producer.func_produce_new_object_of_type<TupleBuilder<LT1, LT2>>();
        }

        public TupleBuilder<T1, T2> item1(T1 value, FactoryFactory producer) {
            TupleBuilder<T1, T2> next = producer.func_produce_new_object_of_type<TupleBuilder<T1, T2>>();
            next.payload.ONE = value;
            return next;
        }

        public TupleBuilder<T1, T2> item2(T2 value, FactoryFactory producer) {
            TupleBuilder<T1, T2> next = producer.func_produce_new_object_of_type<TupleBuilder<T1, T2>>();
            next.payload.TWO = value;
            return next;
        }

        public FBE_TUPLEDEFINITION<T1, T2> Build() {
            return payload;
        }
    }
}
