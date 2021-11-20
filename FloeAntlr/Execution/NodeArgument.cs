using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Execution
{
    public class NodeArgument : INode
    {
        public int ArgValue { get; private set; }
        public void Fufill(int value)
        {
            ArgValue = value;
        }

        public void Apply()
        {

        }
       
    }
}
