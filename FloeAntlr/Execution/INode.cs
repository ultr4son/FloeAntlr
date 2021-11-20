using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Execution
{
    public interface INode
    {
        /**
         * Accept value
         */
        public void Fufill(int value);

        /**
         * Do computation and send result to other nodes
         */
        public void Apply();
    }
}
