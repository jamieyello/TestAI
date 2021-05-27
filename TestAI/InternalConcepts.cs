using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAI
{
    static class InternalConcepts
    {
        static InternalConcepts()
        {
            Base = new BaseConcept();
            BaseRelation = new InheritanceConcept();
            InputOutput = new InputOutputConcept(Base, BaseRelation);
            Vocalizations = new VocalizationOutputConcept[26];
            int i = 0;
            for (char c = 'a'; c <= 'z'; c++)
                Vocalizations[i++] = new VocalizationOutputConcept(Base, InputOutput, c);
        }

        public static readonly BaseConcept Base;
        public static readonly InheritanceConcept BaseRelation;
        public static readonly 
        public static readonly InputOutputConcept InputOutput;
        public static readonly VocalizationOutputConcept[] Vocalizations;
    }
}
