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
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace FizzBuzzEnterprise.NET.Builders
{
    public class IntegerBuilder : IBuilder<FBE_INTDEFINITION>
    {
        protected enum INTEGER_BUILDER_ACTIONS
        {
            INTBUILDER_ACTION_PLUSONE,
            INTBUILDER_ACTION_MINUSONE,
            INTBUILDER_ACTION_TIMESTWO
        }

        private List<INTEGER_BUILDER_ACTIONS> BUILDER_ACTIONS;
        public object New() => new object() as IntegerBuilder;
        public void INIT()
        {
            BUILDER_ACTIONS = new List<INTEGER_BUILDER_ACTIONS>();
        }
        public void INTEGER_BUILDER_PLUSONE()
        {
            BUILDER_ACTIONS.Add(INTEGER_BUILDER_ACTIONS.INTBUILDER_ACTION_PLUSONE);
        }
        public void INTEGER_BUILDER_MINUSONE()
        {
            BUILDER_ACTIONS.Add(INTEGER_BUILDER_ACTIONS.INTBUILDER_ACTION_MINUSONE);
        }
        public void INTEGER_BUILDER_TIMESTWO()
        {
            BUILDER_ACTIONS.Add(INTEGER_BUILDER_ACTIONS.INTBUILDER_ACTION_TIMESTWO);
        }
        public FBE_INTDEFINITION Build()
        {
            FactoryFactory MASTERFACTORY = new FactoryFactory();
            FBE_INTDEFINITION RETURNVALUE = MASTERFACTORY.func_produce_new_object_of_type<FBE_INTDEFINITION>();
            for (int i = 0; i < BUILDER_ACTIONS.Count; i++)
            {
                if (BUILDER_ACTIONS[i] == INTEGER_BUILDER_ACTIONS.INTBUILDER_ACTION_PLUSONE)
                {
                    RETURNVALUE.FBE_REGISTERACTION(FBE_INTDEFINITION.FIZZBUZZENTERPRISENET_OPERANDS.FBE_ADD, FBE_INTDEFINITION.FIZZBUZZENTERPRISENET_NUMBERS.FBE_ONE);
                }
                else if (BUILDER_ACTIONS[i] == INTEGER_BUILDER_ACTIONS.INTBUILDER_ACTION_MINUSONE)
                {
                    RETURNVALUE.FBE_REGISTERACTION(FBE_INTDEFINITION.FIZZBUZZENTERPRISENET_OPERANDS.FBE_SUBTRACT, FBE_INTDEFINITION.FIZZBUZZENTERPRISENET_NUMBERS.FBE_ONE);
                }
                else if (BUILDER_ACTIONS[i] == INTEGER_BUILDER_ACTIONS.INTBUILDER_ACTION_TIMESTWO)
                {
                    RETURNVALUE.FBE_REGISTERACTION(FBE_INTDEFINITION.FIZZBUZZENTERPRISENET_OPERANDS.FBE_MULTIPLY, FBE_INTDEFINITION.FIZZBUZZENTERPRISENET_NUMBERS.FBE_TWO);
                }
            }
            return RETURNVALUE;
        }
    }
}
