using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAI
{
    class Concept
    {
        ConceptRelations relations = new ConceptRelations();

        protected Concept() 
        {
            if (GetType() != typeof(BaseConcept) && GetType() != typeof(InheritanceConcept)) throw new Exception("Parameterless constructor reserved for base/inheritance concept.");
        }
        public Concept(Concept parent, Concept relation)
        {
            parent.relations.Add(this, relation);
        }
    }
}
