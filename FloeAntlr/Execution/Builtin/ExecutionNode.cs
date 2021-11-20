using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloeAntlr.Execution
{
    public abstract class ExecutionNode
    {
        private List<INode> dependents;
        private List<NodeArgument> arguments;
        public abstract int DoComputation(int[] argv);
        public void Apply()
        {
            int[] argv = arguments.Select(arg => arg.ArgValue).ToArray();
            int result = DoComputation(argv);
            dependents.ForEach(dependent => dependent.Fufill(result)); 
        }
        public NodeArgument GetArgument(int index)
        {
            return arguments[index];
        }

    }
}
