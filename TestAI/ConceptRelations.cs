using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAI
{
    class ConceptRelations
    {
        Dictionary<Concept, List<Concept>> relations = new Dictionary<Concept, List<Concept>>();

        public bool TryGet(Concept relation, out List<Concept> concepts)
        {
            return relations.TryGetValue(relation, out concepts);
        }

        public void Add(Concept concept, Concept relation)
        {
            if (TryGet(relation, out var existing)) existing.Add(concept);
            else relations.Add(relation, new List<Concept> { concept });
        }
    }
}
