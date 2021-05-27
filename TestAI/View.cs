using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAI
{
    partial class View
    {
        List<Concept> concepts = new List<Concept>();

        public View()
        {
            AddBase();
        }

        public float Submit(Concept concept)
        {
            return 0f;
        }
    }
}
