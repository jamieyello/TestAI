using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAI
{
    partial class View
    {
        void AddBase()
        {
            _AddBase();
        }

        void _AddBase()
        {
            concepts.Add(InternalConcepts.Base);
        }
    }
}
