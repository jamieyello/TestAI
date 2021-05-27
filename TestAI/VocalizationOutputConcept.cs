using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAI
{
    class VocalizationOutputConcept : Concept
    {
        public readonly char Vocalization;

        public VocalizationOutputConcept(Concept parent, Concept relation, char vocalization) : base(parent, relation) 
        { 
            Vocalization = vocalization; 
        }
    }
}
